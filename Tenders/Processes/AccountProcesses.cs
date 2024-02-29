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
    internal class AccountProcesses : IProcessesSharing<Account>
    {
        private DB_Context connection = new DB_Context();
        public void Add(Account account)
        {
            connection.open();

            new SqlCommand($@"
                                INSERT INTO [dbo].[Accounts]
                                   ([Username]
                                   ,[Password]
                                   ,[PermissionId]
                                   ,[Email]
                                   ,[Phone])
                             VALUES
                                   ('{account.Username}',
                                   '{account.Password}',
                                   '{account.PermissionId}',
                                   '{account.Email}',
                                   '{account.Phone}')
                            "
                    , connection.sqlConnection).ExecuteNonQuery();

            connection.close();
        }

        public Account Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Accounts] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Account account = new Account
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Username = dt.Rows[0][1].ToString(),
                Password = dt.Rows[0][2].ToString(),
                PermissionId = Convert.ToInt16(dt.Rows[0][3].ToString()),
                Email = dt.Rows[0][4].ToString(),
                Phone = dt.Rows[0][5].ToString(),
            };

            connection.close();

            return account;
        }

        public ICollection<Account> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Accounts]",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Account> accounts = new List<Account>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _ = new Account
                {
                    Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                    Username = dt.Rows[0][1].ToString(),
                    Password = dt.Rows[0][2].ToString(),
                    Email = dt.Rows[0][3].ToString(),
                    Phone = dt.Rows[0][4].ToString(),
                    PermissionId = Convert.ToInt16(dt.Rows[0][5].ToString()),
                };

            }

            connection.close();

            return accounts;
        }

        public int GetId(Account account)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"
                    SELECT [Id]  
                    FROM [dbo].[Accounts]
                    WHERE
	                [Username] = '{account.Username}'
                  ",
                connection.sqlConnection);

            adapter.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }


        public int GetIdByUserName(string Username)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT Id FROM [dbo].[Accounts] WHERE {nameof(Username)} = '{Username}'",
                connection.sqlConnection);

            adapter.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }


        public void RemoveAt(int Id)
        {
            connection.open();
            new SqlCommand($@"DELETE FROM [dbo].[Accounts] WHERE {nameof(Id)}={Id}"
                    ,connection.sqlConnection).ExecuteNonQuery();
            connection.close();
        }

        public ICollection<Account> SearchByItem(string taleName, string item)
        {
            throw new NotImplementedException();
        }

        public void Update(Account account)
        {
            connection.open();
            new SqlCommand($@"
                                UPDATE [dbo].[Accounts]
                                SET [Username] = '{account.Username}'
                                  ,[Password] = '{account.Password}'
                                  ,[PermissionId] = '{account.PermissionId}'
                                  ,[Email] = '{account.Email}'
                                  ,[Phone] = '{account.Phone}'
                                WHERE Id = {account.Id}
                            "
                    , connection.sqlConnection).ExecuteNonQuery();
            connection.close();
        }

     

        internal Account IsLoginedSuccessfully(Account account)
        {
            EncryptionDecryption.EncryptionDecryptionText encryptionDecryption = new EncryptionDecryption.EncryptionDecryptionText();
            
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM Accounts WHERE Username = '{account.Username}' AND password = '{account.Password}'",
                connection.sqlConnection);

            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Account signinSelected = new Account
                {
                    Id = int.Parse(dt.Rows[0][0].ToString()),
                    Username = encryptionDecryption.Decryption(dt.Rows[0][1].ToString()),
                    Password = encryptionDecryption.Decryption(dt.Rows[0][2].ToString()),
                    PermissionId = short.Parse(dt.Rows[0][3].ToString()),
                    Email = encryptionDecryption.Decryption(dt.Rows[0][4].ToString()),
                    Phone = encryptionDecryption.Decryption(dt.Rows[0][5].ToString()),
                };
                connection.close();
                return signinSelected;
            }
            connection.close();
            return null;
        }
    }
}
