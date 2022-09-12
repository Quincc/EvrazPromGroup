using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EvrazPromGroup
{
    public static class Repository
    {
        public static SqlConnection CreateConnection()
        {
            string connectionString = @"Integrated Security=true; Initial Catalog = EvrazUsers; Server = DESKTOP-IK91KL6";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
        public static void Add(Product product)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("insert into Users output INSERTED.ID values(@Codebar, @Customer, @Price, @Quantity, @Status)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Codebar", product.Codebar);
            sqlCommand.Parameters.AddWithValue("@Customer", product.Сustomer);
            sqlCommand.Parameters.AddWithValue("@Price", product.Price);
            sqlCommand.Parameters.AddWithValue("@Quantity", product.Quantity);
            sqlCommand.Parameters.AddWithValue("@Status", product.Status);
            product.Id = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
        }
        public static void Remove(Product product)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("Delete from Users where id = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ID", product.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static void Update(Product product)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("Update Employee set Codebar = @Codebar, " +
                "Customer = @Customer, Price = @Price, Quantity = @Quantity where ID = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Codebar", product.Codebar);
            sqlCommand.Parameters.AddWithValue("@Customer", product.Сustomer);
            sqlCommand.Parameters.AddWithValue("@Price", product.Price);
            sqlCommand.Parameters.AddWithValue("@Quantity", product.Quantity);
            sqlCommand.Parameters.AddWithValue("@Status", product.Status);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static List<Product> Products 
        {
            get
            {
                List<Product> products = new List<Product>();
                SqlConnection sqlConnection = CreateConnection();
                SqlCommand sqlCommand = new SqlCommand("Select * from Users", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Id = reader.GetInt32(0);
                    product.Codebar = reader.GetString(1);
                    product.Сustomer = reader.GetString(2);
                    product.Price = (decimal)reader.GetSqlMoney(3);
                    product.Quantity = reader.GetInt32(4);
                    product.Status = (Status)reader.GetInt32(5);
                    products.Add(product);
                }
                sqlConnection.Close();
                return products;
            }
        }
    }
}
