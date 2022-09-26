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
            SqlCommand sqlCommand = new SqlCommand("Update Users set Codebar = @Codebar, " +
                "Customer = @Customer, Price = @Price, Quantity = @Quantity where ID = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Codebar", product.Codebar);
            sqlCommand.Parameters.AddWithValue("@Customer", product.Сustomer);
            sqlCommand.Parameters.AddWithValue("@Price", product.Price);
            sqlCommand.Parameters.AddWithValue("@Quantity", product.Quantity);
            sqlCommand.Parameters.AddWithValue("@Status", product.Status);
            //sqlCommand.Parameters.AddWithValue("@ID", product.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static void Add(Employee employee)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("insert into Employes output INSERTED.ID values(@FirstName, " +
                "@SecondName, @Birthday, @Email, @Phone, @Post, @Login, @Password)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@SecondName", employee.SecondName);
            sqlCommand.Parameters.AddWithValue("@Birthday", employee.Birthday);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Post", employee.Post);
            sqlCommand.Parameters.AddWithValue("@Login", employee.Login);
            sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
            employee.Id = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
        }
        public static void Remove(Employee employee)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("Delete from Employes where id = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ID", employee.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static void Update(Employee employee)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand("Update Employes set FirstName = @FirstName, " +
                "SecondName = @SecondName, Birthday = @Birthday, Email = @Email, Phone = @Phone, Post = @Post, Login = @Login, Password = @Password where ID = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@SecondName", employee.SecondName);
            sqlCommand.Parameters.AddWithValue("@Birthday", employee.Birthday);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Post", employee.Post);
            sqlCommand.Parameters.AddWithValue("@Login", employee.Login);
            sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
            sqlCommand.Parameters.AddWithValue("@ID", employee.Id);
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
        public static List<Employee> Employees
        {
            get
            {
                List<Employee> employees = new List<Employee>();
                SqlConnection sqlConnection = CreateConnection();
                SqlCommand sqlCommand = new SqlCommand("Select * from Employes", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = reader.GetInt32(0);
                    employee.FirstName = reader.GetString(1);
                    employee.SecondName = reader.GetString(2);
                    employee.Birthday= reader.GetDateTime(3);
                    employee.Email = reader.GetString(4);
                    employee.Phone = reader.GetString(5);
                    employee.Post = reader.GetString(6);
                    employee.Login = reader.GetString(7);
                    employee.Password = reader.GetString(8);
                    employees.Add(employee);
                }
                sqlConnection.Close();
                return employees;
            }
        }
        public static Employee FindEmployee(string login, string password)
        {
            SqlConnection sqlConnection = CreateConnection();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Employes Where Login = '{login}' AND Password = '{password}'", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                Employee employee = new Employee();
                while (reader.Read())
                {
                    employee.Id = reader.GetInt32(0);
                    employee.FirstName = reader.GetString(1);
                    employee.SecondName = reader.GetString(2);
                    employee.Birthday = reader.GetDateTime(3);
                    employee.Email = reader.GetString(4);
                    employee.Phone = reader.GetString(5);
                    employee.Post = reader.GetString(6);
                    employee.Login= reader.GetString(7);
                    employee.Password = reader.GetString(8);
                }
                return employee;
            }
            sqlConnection.Close();
            return null;
        }
        public static bool CheackLogin(string login)
        {
            if (Employees.Count(t => t.Login == login) > 0)
                return true;
            else
                return false;
        }
    }
}
