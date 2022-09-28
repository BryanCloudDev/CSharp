using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlConnection.Models
{
    internal class CervezaDB
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fundamentoscsharp";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            string query = "SELECT name, brand, alcohol, amount FROM cerveza";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int amount = reader.GetInt32(3);
                    string name = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(name,amount);

                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Brand = reader.GetString(1);

                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }
            return cervezas;
        }

        public void Add(Cerveza cerveza)
        {
            string query = "INSERT INTO cerveza(name,brand,alcohol,amount) VALUES(@name, @brand, @alcohol, @amount)";

            using (var connection = new MySqlConnection(connectionString))
            {
                var command = new MySqlCommand(query,connection);

                command.Parameters.AddWithValue("@name",cerveza.Name);
                command.Parameters.AddWithValue("@brand", cerveza.Brand);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@amount", cerveza.Amount);

                connection.Open();
                command.ExecuteNonQuery(); // con esto indicamos que sera una insercion

                connection.Close();
            }
        }

        public void Edit(Cerveza cerveza, int Id)
        {
            string query = "UPDATE cerveza SET name=@name, brand=@brand, alcohol=@alcohol, amount=@amount WHERE id=@id";

            using (var connection = new MySqlConnection(connectionString))
            {
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", cerveza.Name);
                command.Parameters.AddWithValue("@brand", cerveza.Brand);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@amount", cerveza.Amount);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery(); // con esto indicamos que sera una insercion

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "DELETE FROM cerveza WHERE id=@id";

            using (var connection = new MySqlConnection(connectionString))
            {
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery(); // con esto indicamos que sera una insercion

                connection.Close();
            }
        }
    }
}
