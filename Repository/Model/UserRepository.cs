using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
    public class UserRepository : IUserRepository
    {
        protected string _connectionString;
        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(User user)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var sentencia = "INSERT INTO User (Name, Age) VALUES (@Name, @Age)";

                    SqlCommand cmd = new SqlCommand(sentencia, connection);

                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Age", user.Age);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Articulo registrado con éxito.");
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM Usuarios WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Artículo eliminado con éxito");
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public IEnumerable<User> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT Id, Name, Age FROM User";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<User> userList = new List<User>();

                while (reader.Read())
                {
                    User user = new User();
                    user.Id = reader.GetInt32(0);
                    user.Name = reader.GetString(1);
                    user.Age = reader.GetInt32(2);

                    userList.Add(user);
                }

                return userList;
            }
        }

        public User GetByID(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var query = "SELECT Id, Name, Age FROM User WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    User user = new User();

                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Age = reader.GetInt32(2);
                    }

                    return user;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(User user)
        {

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var query = "UPDATE Usuarios SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@Name", user.Name);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Artículo modificado con éxito");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
