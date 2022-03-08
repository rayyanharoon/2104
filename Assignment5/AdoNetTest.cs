using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class AdoNetTest
    {
        public SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection();

            return connection;
        }
        public void CreateStudents()
        {
            var connection = this.OpenConnection();
            var command = connection.CreateCommand();
            command.CommandText = "CREATE table students (name VARCHAR(50), email VARCHAR(50), address VARCCHAR(100), id INTEGER)";
            connection.Open();
            command.ExecuteNonQuery();
            var insertCommand = connection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO students (name, email, address, id) VALUES (@name, @email, @address, @id)";
            insertCommand.Parameters.AddWithValue("@name", "ricky bowen");
            insertCommand.Parameters.AddWithValue("@email", "sk8rricky@gmail.com");
            insertCommand.Parameters.AddWithValue("@address", "1234 ehs drive");
            insertCommand.Parameters.AddWithValue("@id", 111219);
            var queryCommand = connection.CreateCommand();
            queryCommand.CommandText = "SELECT * FROM students";
            var reader = queryCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("----------");
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
                Console.WriteLine(reader[2]);
                Console.WriteLine(reader[3]);

            }
            connection.Close();
        }
    }
}
