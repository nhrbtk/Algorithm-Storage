using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


using algStorage.DAL_ADO.Domain;

namespace algStorage.DAL_ADO.Repositories
{
    public class UserRepository:IRepository<User>
    {
        string ConnectString;

        SqlConnection sqlConnection = null;
        public UserRepository()
        {
            //ConnectString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            ConnectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBConnection;Integrated Security=True";

            sqlConnection = new SqlConnection(ConnectString);
        }

        public virtual IEnumerable<User> GetAll()
        {
            var users = new List<User>();

            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, Username, Password, Role FROM Users";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);


            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Role = reader.GetBoolean(3)
                });
            }

            sqlConnection.Close();

            return users;
        }

        public virtual void Create(User user)
        {
            sqlConnection.Open();

            const string sqlExpression =
                "INSERT INTO Users (Username, Password, Role)" +
                "VALUES (@Username, @Password, @Role)";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            var parameters = new[]
            {
                    new SqlParameter("@Username", user.Username),
                    new SqlParameter("@Password", user.Password),
                    new SqlParameter("@Role", user.Role)
                };
            command.Parameters.AddRange(parameters);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public User Read(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, Username, Password, Role FROM Users WHERE Id=@Id";

            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            SqlDataReader reader = command.ExecuteReader();
            
            reader.Read();
            User user = new User { Id = reader.GetInt32(0), Username = reader.GetString(1), Password = reader.GetString(2), Role = reader.GetBoolean(3) };

            sqlConnection.Close();
            return user;
        }

        public void Update(User user)
        {
            sqlConnection.Open();

            const string sqlExpression = "UPDATE Users SET Username=@Username, Password=@Password, Role=@Role WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            var param = new[]
            {
                new SqlParameter("@Id", user.Id),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Role", user.Role)
            };

            command.Parameters.AddRange(param);
            command.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void Delete(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "DELETE FROM Users WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
