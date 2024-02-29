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
    internal class ClientProcesses : IProcessesSharing<Client>
    {
        public DB_Context connection = new DB_Context();

        AccountProcesses accountProcesses = new AccountProcesses();

        public void Add(Client Client)
        {
            connection.open();

            new SqlCommand($@"
                                INSERT INTO [dbo].[Clients]
                               ([Name]
                               ,[AccountId]
                               ,[IdentityImage]
                               ,[Gender])
                                VALUES
                               ('{Client.Name}', {Client.AccountId}, '{Client.IdentityImage}', '{Client.Gender}')
                            "
                    , connection.sqlConnection).ExecuteNonQuery();


            connection.close();
        }

        public Client Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Clients] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Client Client = new Client
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
                IdentityImage = dt.Rows[0][2].ToString(),
                Gender = dt.Rows[0][3].ToString(),
                AccountId = Convert.ToInt32(dt.Rows[0][4].ToString()),
            };


            return Client;

        }

        public ICollection<Client> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Clients]",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Client> Clients = new List<Client>();

            for (int i = 0; i < dt.Rows.Count; i++) //get all Clients
            {
                Clients.Add(
                    _ = new Client
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        IdentityImage = dt.Rows[i][2].ToString(),
                        Gender = dt.Rows[i][3].ToString(),
                        AccountId = Convert.ToInt32(dt.Rows[i][4].ToString()),
                        Account = accountProcesses.Find(Convert.ToInt32(dt.Rows[i][4].ToString()))
                    }
                );
            }



            connection.close();
            return Clients;
        }

        public void RemoveAt(int Id)
        {
            connection.open();
            int accountId = Find(Id).AccountId;
            new SqlCommand($@"DELETE FROM [dbo].[Clients] WHERE {nameof(Id)}={Id}"
                    , connection.sqlConnection).ExecuteNonQuery();
            accountProcesses.RemoveAt(accountId);

            connection.close();
        }

        public void Update(Client Client)
        {
            connection.open();
            new SqlCommand($@"UPDATE [dbo].[Clients] SET [Name]='{Client.Name}' WHERE AccountId = {Client.Account.Id}"
                    , connection.sqlConnection).ExecuteNonQuery();
            accountProcesses.Update(Client.Account);
            connection.close();
        }

        public bool IsUsernameNew(string username)
        {
            DataTable dt = new DataTable();
            connection.open();

            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT Username FROM [dbo].[Accounts] WHERE [Username] = '{username}' AND [PermissionId] = 4"
                , connection.sqlConnection);

            adapter.Fill(dt);

            connection.close();

            if (dt.Rows.Count == 0) //no result = Username not used befor
            {
                return true;
            }
            return false; //Username already used..
        }

        public int GetId(Client table)
        {
            throw new NotImplementedException();
        }


    }
}
