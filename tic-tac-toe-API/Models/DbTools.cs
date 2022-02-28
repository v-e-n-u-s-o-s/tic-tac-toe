using MySql.Data.MySqlClient;
using System.Text;

namespace tic_tac_toe_API.Models
{
    public class DbTools
    {
        private MySqlConnection connection;
        private readonly string server, database, user, password;

        //Constructor
        public DbTools(string server, string database, string user, string password)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            connection = new MySqlConnection("Data source=" + server + ";" + "Initial Catalog=" + database + ";" + "User ID=" + user + ";" + "Password=" + password + ";");
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username and/or password, please try again.");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string table, string[] columns, string[] values)
        {
            StringBuilder string_builder = new StringBuilder();
            for (int i = 0; i < columns.Length; i++)
            {
                string_builder.Append(columns[i]);
                string_builder.Append(", ");
            }
            string columns_string = string_builder.ToString();
            columns_string = columns_string.Remove(columns_string.Length - 2);
            string_builder.Clear();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i][1] == 'S')
                {
                    string_builder.Append("\"" + values[i].Remove(0, 3) + "\"");
                }
                else if (values[i][1] == 'I')
                {
                    string_builder.Append(values[i].Remove(0, 3));
                }

                string_builder.Append(", ");
            }
            string values_string = string_builder.ToString();
            values_string = values_string.Remove(values_string.Length - 2);

            string query = $"INSERT INTO {table} ({columns_string}) VALUES({values_string})";

            if (OpenConnection() is true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Update statement
        public void Update(string table, string[] columns, string[] values, string conditions)
        {
            StringBuilder string_builder = new StringBuilder();
            for (int i = 0; i < columns.Length; i++)
            {
                string_builder.Append(columns[i]);
                string_builder.Append(" = ");
                if (values[i][1] is 'S')
                {
                    string_builder.Append("\"" + values[i].Remove(0, 3) + "\"");
                }
                else if (values[i][1] is 'I')
                {
                    string_builder.Append(values[i].Remove(0, 3));
                }

                string_builder.Append(", ");
            }

            string columns_values_string = string_builder.ToString();
            columns_values_string = columns_values_string.Remove(columns_values_string.Length - 2);

            string query = $"UPDATE {table} SET {columns_values_string} WHERE {conditions}";

            if (OpenConnection() is true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string table, string conditions)
        {
            string query = $"DELETE FROM {table} WHERE {conditions};";

            if (OpenConnection() is true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(string table, string[] columns, string conditions = "")
        {
            StringBuilder string_builder = new StringBuilder();
            for (int i = 0; i < columns.Length; i++)
            {
                string_builder.Append(columns[i]);
                string_builder.Append(", ");
            }
            string columns_string = string_builder.ToString();
            columns_string = columns_string.Remove(columns_string.Length - 2);

            string query = $"SELECT {columns_string} FROM `{table}`{(conditions.Length > 0 ? " WHERE " + conditions : "")};";

            List<string>[] list = new List<string>[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                list[i] = new List<string>();
            }

            if (OpenConnection() is true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int j = 0; j < columns.Length; j++)
                    {
                        list[j].Add(dataReader[columns[j]] + "");
                    }
                }
                dataReader.Close();
                CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
