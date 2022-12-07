using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stadionok
{
    internal class Database
    {
        static public MySqlCommand command;
        static public MySqlConnection connection;

        public Database(string server = "localhost", string user = "root", string password = "", string db = "stadionok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolatok())
            {
                command = connection.CreateCommand();
            }
        }
        private bool Kapcsolatok()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<stadion_adat> getAllStadion()
        {
            List<stadion_adat> list = new List<stadion_adat>();
            command.CommandText = "SELECT * FROM stadion;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    stadion_adat Stadion_adat = new stadion_adat(dr.GetInt32("id"), dr.GetString("stadion"), dr.GetInt32("ferohely"), dr.GetString("varos"),dr.GetInt32("epult"));
                    list.Add(Stadion_adat);
                }
            }
            connection.Close();
            return list;
        }
        public bool updateStadion(stadion_adat updateStadion)
        {

            command.CommandText = "UPDATE stadion SET `stadion`= @stadion,`ferohely`= @ferohely,`varos`= @varos, epult = @epult WHERE `id`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.Modositstadion.textBox_id.Text);
            command.Parameters.AddWithValue("@stadion", Program.Modositstadion.textBox_nev.Text);
            command.Parameters.AddWithValue("@ferohely", Program.Modositstadion.textBox_ferohely.Text);
            command.Parameters.AddWithValue("@varos", Program.Modositstadion.textBox_varos.Text);
            command.Parameters.AddWithValue("@epult", Program.Modositstadion.textBox_epult.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool deleteStadion(stadion_adat deleteStadion)
        {

            command.CommandText = "DELETE FROM stadion WHERE `id`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.Stadiontorlese.textBox_id.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool insertStadion(stadion_adat insertStadion)
        {

            command.CommandText = "INSERT INTO stadion (id,stadion,ferohely,varos,epult) VALUES(null,@stadion,@ferohely,@varos,@epult)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@stadion", Program.Ujstadion.textBox_nev.Text);
            command.Parameters.AddWithValue("@ferohely", Program.Ujstadion.textBox_ferohely.Text);
            command.Parameters.AddWithValue("@varos", Program.Ujstadion.textBox_varos.Text);
            command.Parameters.AddWithValue("@epult", Program.Ujstadion.textBox_epult.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
