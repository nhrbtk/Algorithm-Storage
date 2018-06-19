using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algStorage.DAL_ADO.Domain;
using System.Data.SqlClient;
using System.Configuration;


namespace algStorage.DAL_ADO.Repositories
{
    public class AlgorithmRepository : IRepository<Algorithm>
    {
        string ConnectString;

        SqlConnection sqlConnection = null;
        public AlgorithmRepository()
        {
            //ConnectString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            ConnectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBConnection;Integrated Security=True";
            sqlConnection = new SqlConnection(ConnectString);
        }

        public IEnumerable<Algorithm> GetAll()
        {
            List<Algorithm> algorithms = new List<Algorithm>();

            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, Title, Path, Input, Output, UserId FROM Algorithms";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                algorithms.Add(new Algorithm
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Path = reader.GetString(2),
                    Input = reader.GetString(3),
                    Output = reader.GetString(4),
                    UserId = reader.GetInt32(5)
                });
            }

            sqlConnection.Close();

            return algorithms;
        }

        public void Create(Algorithm algorithm)
        {
            sqlConnection.Open();

            const string sqlExpression = "INSERT INTO Algorithms (Title, Path, Input, Output, UserId) VALUES (@Title, @Path, @Input, @Output, @UserId)";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            SqlParameter[] parameters = new[]
            {
                    new SqlParameter("@Title", algorithm.Title),
                    new SqlParameter("@Path", algorithm.Path),
                    new SqlParameter("@Input", algorithm.Input),
                    new SqlParameter("@Output", algorithm.Output),
                    new SqlParameter("@UserId", algorithm.UserId)
                };
            command.Parameters.AddRange(parameters);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public Algorithm Read(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, Title, Path, Input, Output, UserId FROM Algorithms WHERE Id=@Id";

            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Algorithm algorithm = new Algorithm
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Path = reader.GetString(2),
                Input = reader.GetString(3),
                Output = reader.GetString(4),
                UserId = reader.GetInt32(5)
            };

            sqlConnection.Close();
            return algorithm;
        }

        public void Update(Algorithm algorithm)
        {
            sqlConnection.Open();

            const string sqlExpression = "UPDATE Algorithms SET Title=@Title, Path=@Path, Input=@Input, Output=@Output, UserId=@UserId WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            SqlParameter[] param = new[]
            {
                new SqlParameter("@Id", algorithm.Id),
                new SqlParameter("@Title", algorithm.Title),
                new SqlParameter("@Path", algorithm.Path),
                new SqlParameter("@Input", algorithm.Input),
                new SqlParameter("@Output", algorithm.Output),
                new SqlParameter("@UserId", algorithm.UserId)
            };

            command.Parameters.AddRange(param);
            command.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void Delete(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "DELETE FROM Algorithms WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
