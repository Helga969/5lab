using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace _5lab
{
    class DataBase
    {
        public static MySqlConnection GetConnection()
        {
            string sql = @"server=192.168.1.105;port=3306; database=mydb;uid=root;pwd=123456;";
            MySqlConnection mycon = new MySqlConnection(sql);
            try
            {
                mycon.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка подключения ! " + er.Message, "Information");
            }
            return mycon;
        }
        //auto
        public static void AddAuto(Model.Auto std)
        {
            string sql = "INSERT INTO Auto (idAuto, number) VALUES (NULL, @number);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@id_Sportsmen", MySqlDbType.Int32).Value = std.id_Sportsmen;
            cmd.Parameters.Add("@number", MySqlDbType.String).Value = std.Number;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChAuto(Model.Auto std)
        {
            string sql = "UPDATE Auto SET  number=@number WHERE  idAuto=@idAuto";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idAuto", MySqlDbType.Int32).Value = std.IdAuto;
            cmd.Parameters.Add("@number", MySqlDbType.String).Value = std.Number;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelAuto(Model.Auto std)
        {
            string sql = "DELETE FROM Auto WHERE idAuto=@idAuto";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idAuto", MySqlDbType.Int32).Value = std.IdAuto;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutAuto(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Auto", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        //driver
        public static void AddDriver(Model.Driver std)
        {
            string sql = "INSERT INTO Driver (idDriver, FIO) VALUES (NULL, @FIO);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@FIO", MySqlDbType.String).Value = std.FIO;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChDriver(Model.Driver std)
        {
            string sql = "UPDATE Driver SET  FIO=@fio WHERE  idDriver=@idDriver";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idDriver", MySqlDbType.Int32).Value = std.IdDriver;
            cmd.Parameters.Add("@fio", MySqlDbType.String).Value = std.FIO;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelDriver(Model.Driver std)
        {
            string sql = "DELETE FROM Driver WHERE idDriver=@idDriver";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idDriver", MySqlDbType.Int32).Value = std.IdDriver;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutDriver(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Driver", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        //Garage
        public static void AddGarage(Model.Garage std)
        {
            string sql = "INSERT INTO Garage (idGarage, Address) VALUES (NULL, @address);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@address", MySqlDbType.String).Value = std.Address;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChGarage(Model.Garage std)
        {
            string sql = "UPDATE Garage SET  address=@address WHERE  idGarage=@idGarage";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idGarage", MySqlDbType.Int32).Value = std.IdGarage;
            cmd.Parameters.Add("@address", MySqlDbType.String).Value = std.Address;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelGarage(Model.Garage std)
        {
            string sql = "DELETE FROM Garage WHERE idGarage=@idGarage";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idGarage", MySqlDbType.Int32).Value = std.IdGarage;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutGarage(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Garage", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        //autobase
        public static void AddAutobase(Model.Autobase std)
        {
            string sql = "INSERT INTO Autobase (idAutobase, name) VALUES (NULL, @name);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.String).Value = std.Name;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChAutobase(Model.Autobase std)
        {
            string sql = "UPDATE Autobase SET  name=@name WHERE  idAutobase=@idAutobase";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idAutobase", MySqlDbType.Int32).Value = std.IdAutobase;
            cmd.Parameters.Add("@name", MySqlDbType.String).Value = std.Name;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelAutobase(Model.Autobase std)
        {
            string sql = "DELETE FROM Autobase WHERE idAutobase=@idAutobase";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idAutobase", MySqlDbType.Int32).Value = std.IdAutobase;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutAutobase(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Autobase", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        //statement
        public static void AddStatement(Model.Statement std)
        {
            string sql = "INSERT INTO Statement (idStatement, date, flue, volume, driver, autobase, garage, auto) VALUES (NULL, @date, @flue, @volume, @driver, @autobase, @garage, @auto);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@id_Sportsmen", MySqlDbType.Int32).Value = std.id_Sportsmen;
            cmd.Parameters.Add("@date", MySqlDbType.String).Value = std.Date;
            cmd.Parameters.Add("@flue", MySqlDbType.String).Value = std.Flue;
            cmd.Parameters.Add("@volume", MySqlDbType.Float).Value = std.Volume;
            cmd.Parameters.Add("@autobase", MySqlDbType.Int32).Value = std.Autobase;
            cmd.Parameters.Add("@driver", MySqlDbType.Int32).Value = std.Driver;
            cmd.Parameters.Add("@garage", MySqlDbType.Int32).Value = std.Garage;
            cmd.Parameters.Add("@auto", MySqlDbType.Int32).Value = std.Auto;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChStatement(Model.Statement std)
        {
            string sql = "UPDATE Statement SET  date=@date, flue=@flue, volume=@volume, driver=@driver, autobase=@autobase, garage=@garage, auto=@auto WHERE  idStatement=@idStatement";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idStatement", MySqlDbType.Int32).Value = std.IdStatement;
            cmd.Parameters.Add("@date", MySqlDbType.Date).Value = std.Date;
            cmd.Parameters.Add("@flue", MySqlDbType.String).Value = std.Flue;
            cmd.Parameters.Add("@volume", MySqlDbType.Float).Value = std.Volume;
            cmd.Parameters.Add("@driver", MySqlDbType.Int32).Value = std.Driver;
            cmd.Parameters.Add("@autobase", MySqlDbType.Int32).Value = std.Autobase;
            cmd.Parameters.Add("@garage", MySqlDbType.Int32).Value = std.Garage;
            cmd.Parameters.Add("@auto", MySqlDbType.Int32).Value = std.Auto;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelStatement(Model.Statement std)
        {
            string sql = "DELETE FROM Statement WHERE idStatement=@idStatement";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idStatement", MySqlDbType.Int32).Value = std.IdStatement;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutStatement(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Statement", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        //users
        public static void auth(Model.Users std)
        {
            string sql = "SELECT login, password FROM Users WHERE login=@login AND password=@password;";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@login", MySqlDbType.String).Value = std.Login;
            cmd.Parameters.Add("@password", MySqlDbType.String).Value = std.Password;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void AddUsers(Model.Users std)
        {
            string sql = "INSERT INTO Users (idUsers, login, password) VALUES (NULL, @login, @password);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@login", MySqlDbType.String).Value = std.Login;
            cmd.Parameters.Add("@password", MySqlDbType.String).Value = std.Password;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void ChUsers(Model.Users std)
        {
            string sql = "UPDATE Users SET  login=@login, password=@password WHERE  idUsers=@idUsers";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idUsers", MySqlDbType.Int32).Value = std.IdUsers;
            cmd.Parameters.Add("@password", MySqlDbType.String).Value = std.Password;
            cmd.Parameters.Add("@login", MySqlDbType.String).Value = std.Login;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }

        public static void DelUsers(Model.Users std)
        {
            string sql = "DELETE FROM Users WHERE idUsers=@idUsers";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idUsers", MySqlDbType.Int32).Value = std.IdUsers;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutUsers(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Users", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void Txt_driver(ComboBox std)
        {
            try
            {

                MySqlConnection mycon = GetConnection();
                string sql = "SELECT idDriver FROM Driver";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    std.Items.Add(reader.GetValue(0).ToString());

                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Txt_auto(ComboBox std)
        {
            try
            {

                MySqlConnection mycon = GetConnection();
                string sql = "SELECT idAuto FROM Auto";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    std.Items.Add(reader.GetValue(0).ToString());

                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Txt_garage(ComboBox std)
        {
            try
            {

                MySqlConnection mycon = GetConnection();
                string sql = "SELECT idGarage FROM Garage";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    std.Items.Add(reader.GetValue(0).ToString());

                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Txt_autobase(ComboBox std)
        {
            try
            {

                MySqlConnection mycon = GetConnection();
                string sql = "SELECT idAutobase FROM Autobase";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    std.Items.Add(reader.GetValue(0).ToString());

                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
