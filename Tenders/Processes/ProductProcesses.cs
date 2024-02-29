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
    internal class ProductProcesses : IProcessesSharing<Product>
    {
        public DB_Context connection = new DB_Context();

        AccountProcesses accountProcesses = new AccountProcesses();

        public void Add(Product product)
        {
            connection.open();

            new SqlCommand($@"
                                DECLARE @Id INT
                                WITH CTE AS
                                (
                                    SELECT ROW_NUMBER() OVER (ORDER BY Id) AS RowNumber, *
                                    FROM Categories
                                )
                                SELECT @Id = Id FROM CTE WHERE RowNumber = {product.CategoryId};

                                INSERT INTO [dbo].[Products]
                                   (
                                    [Name]
                                   ,[Price]
                                   ,[FirmId]
                                   ,[CategoryId]
                                   ,[Image]
                                   ,[Description]
                                   ,[Quantity]
                                    )
                                VALUES
                               ('{product.Name}',
                                 {product.Price},
                                 {product.FirmId},
                                  @Id,
                                 '{product.Image}',
                                 '{product.Description}',
                                  {product.Quantity}
                                )
                            "
                    , connection.sqlConnection).ExecuteNonQuery();


            connection.close();
        }

        public Product Find(int Id)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Products] WHERE {nameof(Id)} = {Id}",
                connection.sqlConnection);

            adapter.Fill(dt);

            Product product = new Product
            {
                Id = Convert.ToInt32(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
                Price = Convert.ToInt32(dt.Rows[0][2].ToString()),
                FirmId = Convert.ToInt32(dt.Rows[0][3].ToString()),
                CategoryId = Convert.ToInt32(dt.Rows[0][4].ToString()),
                Image = dt.Rows[0][5].ToString(),
                Description = dt.Rows[0][6].ToString(),
                Quantity = Convert.ToInt32(dt.Rows[0][7].ToString()),

            };
            /*
           ([Name]
           ,[Price]
           ,[FirmId]
           ,[CategoryId]
           ,[Image]
           ,[Description])
             */


            return product;

        }

        public ICollection<Product> GetAll()
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Products]",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Product> products = new List<Product>();

            /*
           ([Name]
           ,[Price]
           ,[FirmId]
           ,[CategoryId]
           ,[Image]
           ,[Description]
           ,[Quantity])
             */

            FirmProcesses firmProcesses = new FirmProcesses();
                
            for (int i = 0; i < dt.Rows.Count; i++) //get all products
            {
                products.Add(
                    _ = new Product
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        Price = float.Parse(dt.Rows[i][2].ToString()),
                        FirmId= Convert.ToInt32(dt.Rows[i][3].ToString()),
                        CategoryId= Convert.ToInt32(dt.Rows[i][4].ToString()),
                        Image =  dt.Rows[i][5].ToString(),
                        Description= dt.Rows[i][6].ToString(),
                        Quantity = int.Parse(dt.Rows[i][7].ToString()),
                        Firm = firmProcesses.Find(Convert.ToInt32(dt.Rows[i][3].ToString())) // FIRM ID
                    }
                );;
            }



            connection.close();
            return products;
        }

        public ICollection<Product> GetAllByFirmId(int firmId)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                $@"SELECT * FROM [dbo].[Products] WHERE FirmId = {firmId}",
                connection.sqlConnection);

            adapter.Fill(dt);

            ICollection<Product> products = new List<Product>();

            /*
           ([Name]
           ,[Price]
           ,[FirmId]
           ,[CategoryId]
           ,[Image]
           ,[Description]
           ,[Quantity])
             */

            FirmProcesses firmProcesses = new FirmProcesses();

            for (int i = 0; i < dt.Rows.Count; i++) //get all products
            {
                products.Add(
                    _ = new Product
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        Price = float.Parse(dt.Rows[i][2].ToString()),
                        FirmId = Convert.ToInt32(dt.Rows[i][3].ToString()),
                        CategoryId = Convert.ToInt32(dt.Rows[i][4].ToString()),
                        Image = dt.Rows[i][5].ToString(),
                        Description = dt.Rows[i][6].ToString(),
                        Quantity = int.Parse(dt.Rows[i][7].ToString()),
                        Firm = firmProcesses.Find(Convert.ToInt32(dt.Rows[i][3].ToString())), // FIRM ID
                    }
                ); ;
            }



            connection.close();
            return products;
        }

        public ICollection<Product> GetAllByCategoryId(int? CategoryId)
        {
            DataTable dt = new DataTable();
            connection.open();
            SqlDataAdapter adapter;

            if (CategoryId != null)
            {
                adapter = new SqlDataAdapter(
                    $@"
                DECLARE @Id INT
                    WITH CTE AS
                    (
                        SELECT ROW_NUMBER() OVER (ORDER BY Id) AS RowNumber, *
                        FROM Categories
                    )
                    SELECT @Id = Id FROM CTE WHERE RowNumber = {CategoryId};



                SELECT * FROM [dbo].[Products] WHERE {nameof(CategoryId)} = @Id",
                    connection.sqlConnection);
            }
            else
            {
                adapter = new SqlDataAdapter(
                    $@"SELECT * FROM [dbo].[Products]",
                    connection.sqlConnection);
            }

            adapter.Fill(dt);

            ICollection<Product> products = new List<Product>();

            /*
           ([Name]
           ,[Price]
           ,[FirmId]
           ,[CategoryId]
           ,[Image]
           ,[Description]
           ,[Quantity])
             */

            FirmProcesses firmProcesses = new FirmProcesses();

            for (int i = 0; i < dt.Rows.Count; i++) //get all products
            {
                products.Add(
                    _ = new Product
                    {
                        Id = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        Name = dt.Rows[i][1].ToString(),
                        Price = float.Parse(dt.Rows[i][2].ToString()),
                        FirmId = Convert.ToInt32(dt.Rows[i][3].ToString()),
                        CategoryId = Convert.ToInt32(dt.Rows[i][4].ToString()),
                        Image = dt.Rows[i][5].ToString(),
                        Description = dt.Rows[i][6].ToString(),
                        Quantity = int.Parse(dt.Rows[i][7].ToString()),
                        Firm = firmProcesses.Find(Convert.ToInt32(dt.Rows[i][3].ToString())), // FIRM ID
                    }
                ); ;
            }



            connection.close();
            return products;
        }

        public void RemoveAt(int Id)
        {
            connection.open();
            new SqlCommand($@"DELETE FROM [dbo].[Products] WHERE {nameof(Id)}={Id}"
                    , connection.sqlConnection).ExecuteNonQuery();

            connection.close();
        }


        public void Update(Product product)
        {

            /*
         	[Id] [int] IDENTITY(1,1) NOT NULL,
	        [Name] [varchar](50) NOT NULL,
	        [Price] [money] NOT NULL,
	        [FirmId] [int] NOT NULL,
	        [CategoryId] [int] NOT NULL,
            [Image] VARCHAR(MAX) NOT NULL
            Description VARCHAR(MAX) NOT NULL
            Quantity INT NOT NULL
         */
            connection.open();
            new SqlCommand($@"
                DECLARE @Id INT
                    WITH CTE AS
                    (
                        SELECT ROW_NUMBER() OVER (ORDER BY Id) AS RowNumber, *
                        FROM Categories
                    )
                    SELECT @Id = Id FROM CTE WHERE RowNumber = {product.CategoryId};





              UPDATE [dbo].[Products] SET 
                [Name]='{product.Name}',
                [Price]={product.Price},
                [FirmId]={product.FirmId},
                [CategoryId]=@Id,
                [Image]='{product.Image}',
                [Description]='{product.Description}',
                [Quantity]= {product.Quantity}
                
            WHERE [Id] = {product.Id}"
                    , connection.sqlConnection).ExecuteNonQuery();

            connection.close();
        }

        public int GetId(Product table)
        {
            throw new NotImplementedException();
        }


    }
}
