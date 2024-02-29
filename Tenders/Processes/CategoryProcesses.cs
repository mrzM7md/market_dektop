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
    internal class CategoryProcesses : IProcessesSharing<Category>
    {
        private DB_Context connection = new DB_Context();
        public void Add(Category Category)
        {
            connection.open();

            new SqlCommand($@"
                                INSERT INTO [dbo].[Categories]
                                   ([Name])
                             VALUES
                                   ('{Category.Name}')
                            "
                    , connection.sqlConnection).ExecuteNonQuery();

            connection.close();
        }

        public Category Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Categories] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Category Category = new Category
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
            };

            connection.close();

            return Category;
        }

        public ICollection<Category> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Categories] ORDER BY Id",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Category> categories = new List<Category>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categories.Add(
                    new Category
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString()
                    });
            }


            connection.close();

            return categories;
        }

        public int GetId(Category Category)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"
                    SELECT [Id]  
                    FROM [dbo].[Categories]
                    WHERE
	                [Name] = '{Category.Name}'
                  ",
                connection.sqlConnection);

            adapter.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }


        public void RemoveAt(int Id)
        {
            try
            {
                connection.open();
                new SqlCommand($@"DELETE FROM [dbo].[Categories] WHERE {nameof(Id)}={Id}"
                        , connection.sqlConnection).ExecuteNonQuery();


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

            connection.close();
        }

        public ICollection<Category> SearchByItem(string taleName, string item)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            connection.open();
            new SqlCommand($@"
                                UPDATE [dbo].[Categories]
                                SET [Name] = '{category.Name}'
                                WHERE [Id] = {category.Id}
                            "
                    , connection.sqlConnection).ExecuteNonQuery();
            connection.close();
        }


    }
}
