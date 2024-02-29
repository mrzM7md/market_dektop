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
    internal class AdminProcesses : IProcessesSharing<Admin>
    {
        public DB_Context connection = new DB_Context();
        
        AccountProcesses accountProcesses = new AccountProcesses();

        public void Add(Admin admin)
        {
            connection.open();

            new SqlCommand($@"
                                INSERT INTO [dbo].[Admins]
                               ([Name]
                               ,[AccountId])
                                VALUES
                               ('{admin.Name}', {admin.AccountId})
                            "
                    , connection.sqlConnection).ExecuteNonQuery();


            connection.close();
        }

        public Admin Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Admins] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Admin admin = new Admin
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
                AccountId = Convert.ToInt32(dt.Rows[0][2].ToString()),
            };


            return admin;

        }

        public ICollection<Admin> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Admins]",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Admin> admins = new List<Admin>();

            for (int i = 0; i < dt.Rows.Count; i++) //get all admins
            {
                admins.Add(
                    _ = new Admin
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        AccountId = Convert.ToInt32(dt.Rows[i][2].ToString()),
                        Account = accountProcesses.Find(Convert.ToInt32(dt.Rows[i][2].ToString()))
                    }
                ) ;
            }

            
            
            connection.close();
            return admins;
        }

        public void RemoveAt(int Id)
        {
            connection.open();
            int accountId = Find(Id).AccountId;
            new SqlCommand($@"DELETE FROM [dbo].[Admins] WHERE {nameof(Id)}={Id}"
                    , connection.sqlConnection).ExecuteNonQuery();
            accountProcesses.RemoveAt(accountId);
           
            connection.close();
        }

        public ICollection<Admin> SearchByItem(string taleName, string item)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[AdminRoom] WHERE {taleName} = '{item}'",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Admin> admins = new List<Admin>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                admins.Add(
                    _ = new Admin
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString()
                    }
                );
            }
            
            connection.close();

            return admins;
        }

        public void Update(Admin admin)
        {
            connection.open();
            new SqlCommand($@"UPDATE [dbo].[Admins] SET [Name]='{admin.Name}' WHERE AccountId = {admin.Account.Id}"
                    , connection.sqlConnection).ExecuteNonQuery();
            accountProcesses.Update(admin.Account);
            connection.close();
        }

        public bool IsUsernameNew(string username)
        {
            DataTable dt = new DataTable();
            connection.open();

            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT Username FROM [dbo].[Accounts] WHERE [Username] = '{username}' AND [PermissionId] = 2"
                , connection.sqlConnection);

            adapter.Fill(dt);

            connection.close();

            if (dt.Rows.Count == 0) //no result = Username not used befor
            {
                return true;
            }
            return false; //Username already used..
        }

        public int GetId(Admin table)
        {
            throw new NotImplementedException();
        }

      
    }
}
