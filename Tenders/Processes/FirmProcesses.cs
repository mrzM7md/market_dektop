using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenders.Database;
using Tenders.Models;

namespace Tenders.Processes
{
    internal class FirmProcesses : IProcessesSharing<Firm>
    {
        public DB_Context connection = new DB_Context();

        AccountProcesses accountProcesses = new AccountProcesses();

        public void Add(Firm Firm)
        {
            connection.open();

            new SqlCommand($@"
                                INSERT INTO [dbo].[Firms]
                               ([Name]
                               ,[Location]
                               ,[AccountId])
                                VALUES
                               ('{Firm.Name}', '{Firm.Location}', {Firm.AccountId})
                            "
                    , connection.sqlConnection).ExecuteNonQuery();


            connection.close();
        }

        public Firm Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Firms] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Firm Firm = new Firm
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
                Location = dt.Rows[0][2].ToString(),
                AccountId = Convert.ToInt32(dt.Rows[0][3].ToString()),
            };


            return Firm;

        }

        public ICollection<Firm> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Firms]",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Firm> listFirms = new List<Firm>();

            for (int i = 0; i < dt.Rows.Count; i++) //get all Firms
            {
                listFirms.Add(
                    _ = new Firm
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        Location = dt.Rows[i][2].ToString(),
                        AccountId = Convert.ToInt32(dt.Rows[i][3].ToString()),
                        Account = accountProcesses.Find(Convert.ToInt32(dt.Rows[i][3].ToString()))
                    }
                );
            }



            connection.close();
            return listFirms;
        }

        public void RemoveAt(int Id)
        {
            connection.open();
            try
            {
                int accountId = Find(Id).AccountId;
                new SqlCommand($@"DELETE FROM [dbo].[Firms] WHERE {nameof(Id)}={Id}"
                        , connection.sqlConnection).ExecuteNonQuery();
                accountProcesses.RemoveAt(accountId);

            }
            catch (Exception ex)
            {
                ErrorDialogs.Error error = new ErrorDialogs.Error();
                error.Title = "Database Error !!";
                error.Description = $"This error occurse the relationship between tables\nError Details: {ex.Message}";
                error.ShowDialog();
            }
            finally
            {
                connection.close();
            }

        }

        public ICollection<Firm> SearchByItem(string taleName, string item)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Firm] WHERE {taleName} = '{item}'",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Firm> Firms = new List<Firm>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Firms.Add(
                    _ = new Firm
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString()
                    }
                );
            }

            connection.close();

            return Firms;
        }

        public void Update(Firm Firm)
        {
            connection.open();
            new SqlCommand($@"UPDATE [dbo].[Firms] SET [Name]='{Firm.Name}', [Location]='{Firm.Location}' WHERE AccountId = {Firm.Account.Id}"
                    , connection.sqlConnection).ExecuteNonQuery();
            accountProcesses.Update(Firm.Account);
            connection.close();
        }

        public bool IsUsernameNew(string username)
        {
            DataTable dt = new DataTable();
            connection.open();

            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT Username FROM [dbo].[Accounts] WHERE [Username] = '{username}' AND [PermissionId] = 3"
                , connection.sqlConnection);

            adapter.Fill(dt);

            connection.close();

            if (dt.Rows.Count == 0) //no result = Username not used befor
            {
                return true;
            }
            return false; //Username already used..
        }








    }
}
