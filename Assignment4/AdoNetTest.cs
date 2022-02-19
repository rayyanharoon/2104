using System;
namespace Assignment4
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
            var connection1 = this.OpenConnection();
            var command = connection1.CreateCommand();
            command.CommandText = "CREATE table students (name VARCHAR(20), id INTEGER, address VARCCHAR(20), city VARCHAR(20), province VARCHAR(20), country VARCHAR(20), postalCode VARCHAR(6), email VARCHAR(25), phoneNumber INTEGER, programID INTEGER)";
            connection1.Open();
            command.ExecuteNonQuery();
            var insertCommand = connection1.CreateCommand();
            insertCommand.CommandText = "INSERT INTO students (name, email, address, id) VALUES (@name, @email, @address, @id)";
            insertCommand.Parameters.AddWithValue("@name", "ricky");
            insertCommand.Parameters.AddWithValue("@email", "sk8rricky@gmail.com");
            insertCommand.Parameters.AddWithValue("@address", "1234 ehs drive");
            insertCommand.Parameters.AddWithValue("@id", 111219);
            int result = insertCommand.ExecuteNonQuery();
            var queryCommand = connection1.CreateCommand();
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
            connection1.Close();
        }
        public void CreateProgram()
        {
            var connection2 = this.OpenConnection();
            var command = connection2.CreateCommand();
            command.CommandText = "CREATE table programCourse(programID INTEGER, courseID INTEGER, required BOOLEAN)";
            connection2.Open();
            command.ExecuteNonQuery();

            var insertCommand = connection2.CreateCommand();
            insertCommand.CommandText = "INSERT INTO programCourse (programID INTEGER, courseID INTEGER, required BOOLEAN) VALUES (@programID, @courseID, @required)";
            insertCommand.Parameters.AddWithValue("@programID", "0110");
            insertCommand.Parameters.AddWithValue("@courseID", "2104");
            insertCommand.Parameters.AddWithValue("@required", "true");

            var queryCommand = connection2.CreateCommand();
            queryCommand.CommandText = "SELECT * FROM programCourse";
            var reader = queryCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("--------");
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
                Console.WriteLine(reader[2]);
            }
            connection2.Close();
        }
        public void CreateCourse()
        {
            var connection = this.OpenConnection();
            var command = connection.CreateCommand();
            command.CommandText = "CREATE table course (id INTEGER, name VARCHAR(50), description VARCHAR(140), credit INTEGER)";
            connection.Open();
            command.ExecuteNonQuery();

            var insertCommand = connection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO course (id INTEGER, name VARCHAR(50), description VARCHAR(140), credit INTEGER)";
            insertCommand.Parameters.AddWithValue("@id", "2104");
            insertCommand.Parameters.AddWithValue("@name", "windows app prog");
            insertCommand.Parameters.AddWithValue("@description", "developing and creating windows applications");
            insertCommand.Parameters.AddWithValue("@credit", "3");
            var queryCommand = connection.CreateCommand();
            queryCommand.CommandText = "SELECT * FROM course";
            var reader = queryCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
                Console.WriteLine(reader[2]);
                Console.WriteLine(reader[3]);
            }
            connection.Close();
        }

    }
}