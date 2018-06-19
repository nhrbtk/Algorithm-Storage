using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using algStorage.DAL_ADO.Domain;
using algStorage.DAL_ADO.Repositories;

namespace algStorage.DAL_ADO.Repositories
{
    public class AccessGroupRepository : IRepository<AccessGroup>
    {
        string ConnectString;

        SqlConnection sqlConnection = null;
        public AccessGroupRepository()
        {
            //ConnectString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            ConnectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBConnection;Integrated Security=True";
            sqlConnection = new SqlConnection(ConnectString);
        }

        public IEnumerable<AccessGroup> GetAll()
        {
            List<AccessGroup> groups = new List<AccessGroup>();

            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, UserId, AlgorithmId FROM AccessGroups";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                groups.Add(new AccessGroup
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    AlgorithmId = reader.GetInt32(2)
                });
            }

            sqlConnection.Close();

            return groups;
        }

        public void Create(AccessGroup group)
        {
            sqlConnection.Open();

            const string sqlExpression = "INSERT INTO AccessGroups (UserId, AlgorithmId) VALUES (@UserId, @AlgorithmId)";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            SqlParameter[] parameters = new[]
            {
                    new SqlParameter("@UserId", group.UserId),
                    new SqlParameter("@AlgorithmId", group.AlgorithmId)
                };
            command.Parameters.AddRange(parameters);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public AccessGroup Read(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "SELECT Id, UserId, AlgorithmId FROM AccessGroups WHERE Id=@Id";

            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            AccessGroup group = new AccessGroup
            {
                Id = reader.GetInt32(0),
                UserId = reader.GetInt32(1),
                AlgorithmId = reader.GetInt32(2)
            };

            sqlConnection.Close();
            return group;
        }

        public void Update(AccessGroup group)
        {
            sqlConnection.Open();

            const string sqlExpression = "UPDATE AccessGroups SET UserId=@UserId, AlgorithmId=@AlgorithmId WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            SqlParameter[] param = new[]
            {
                new SqlParameter("@UserId", group.UserId),
                new SqlParameter("@AlgortihmId", group.AlgorithmId)
            };

            command.Parameters.AddRange(param);
            command.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void Delete(int id)
        {
            sqlConnection.Open();

            const string sqlExpression = "DELETE FROM AccessGroups WHERE Id=@Id";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            command.Parameters.AddWithValue("Id", id);
            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
