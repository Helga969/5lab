using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace _5lab
{
    class DataBase
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        }
        public static async Task<MySqlConnection> GetConnection()
        {
            var connectionString = GetConnectionString();
            var mycon = new MySqlConnection(connectionString);
            try
            {
                await mycon.OpenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Information");
            }
            return mycon;
        }
        //auto
        public static async Task AddAuto(Model.Auto std)
        {
            string sql = "INSERT INTO Auto (number) VALUES (@number);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@number", std.Number);
                    await cmd.ExecuteNonQueryAsync();
                } 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChAuto(Model.Auto std)
        {
            string sql = "UPDATE Auto SET  number=@number WHERE  idAuto=@idAuto";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idAuto", std.IdAuto);
                    cmd.Parameters.AddWithValue("@number", std.Number);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelAuto(Model.Auto std)
        {
            string sql = "DELETE FROM Auto WHERE idAuto=@idAuto";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idAuto", std.IdAuto);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutAuto(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Auto", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl; 
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //driver
        public static async Task AddDriver(Model.Driver std)
        {
            string sql = "INSERT INTO Driver (FIO) VALUES (@FIO);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FIO", std.FIO);
                    await cmd.ExecuteNonQueryAsync();
                }
                    
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChDriver(Model.Driver std)
        {
            string sql = "UPDATE Driver SET  FIO=@fio WHERE  idDriver=@idDriver";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idDriver", std.IdDriver);
                    cmd.Parameters.AddWithValue("@fio", std.FIO);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelDriver(Model.Driver std)
        {
            string sql = "DELETE FROM Driver WHERE idDriver=@idDriver";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idDriver", std.IdDriver);
                    await cmd.ExecuteNonQueryAsync();
                }
                    
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutDriver(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Driver", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Garage
        public static async Task AddGarage(Model.Garage std)
        {
            string sql = "INSERT INTO Garage (Address) VALUES (@address);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@address", std.Address);
                    await cmd.ExecuteNonQueryAsync();
                }
                    
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChGarage(Model.Garage std)
        {
            string sql = "UPDATE Garage SET  address=@address WHERE  idGarage=@idGarage";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idGarage", std.IdGarage);
                    cmd.Parameters.AddWithValue("@address", std.Address);
                    await cmd.ExecuteNonQueryAsync();
                }
                    
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelGarage(Model.Garage std)
        {
            string sql = "DELETE FROM Garage WHERE idGarage=@idGarage";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idGarage", std.IdGarage);
                    await cmd.ExecuteNonQueryAsync();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutGarage(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Garage", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //autobase
        public static async Task AddAutobase(Model.Autobase std)
        {
            string sql = "INSERT INTO Autobase (name) VALUES (@name);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", std.Name);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChAutobase(Model.Autobase std)
        {
            string sql = "UPDATE Autobase SET  name=@name WHERE  idAutobase=@idAutobase";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@idAutobase", std.IdAutobase);
                    cmd.Parameters.AddWithValue("@name", std.Name);
                    await cmd.ExecuteNonQueryAsync();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelAutobase(Model.Autobase std)
        {
            string sql = "DELETE FROM Autobase WHERE idAutobase=@idAutobase";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idAutobase", std.IdAutobase);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutAutobase(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Autobase", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //statement
        public static async Task AddStatement(Model.Statement std)
        {
            string sql = "INSERT INTO Statement (date, flue, volume, driver, autobase, garage, auto) VALUES (@date, @flue, @volume, @driver, @autobase, @garage, @auto);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@date", std.Date);
                    cmd.Parameters.AddWithValue("@flue", std.Flue);
                    cmd.Parameters.AddWithValue("@volume", std.Volume);
                    cmd.Parameters.AddWithValue("@autobase", std.Autobase);
                    cmd.Parameters.AddWithValue("@driver", std.Driver);
                    cmd.Parameters.AddWithValue("@garage", std.Garage);
                    cmd.Parameters.AddWithValue("@auto", std.Auto);
                    await cmd.ExecuteNonQueryAsync();
            }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChStatement(Model.Statement std)
        {
            string sql = "UPDATE Statement SET  date=@date, flue=@flue, volume=@volume, driver=@driver, autobase=@autobase, garage=@garage, auto=@auto WHERE  idStatement=@idStatement";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idStatement", std.IdStatement);
                    cmd.Parameters.AddWithValue("@date", std.Date);
                    cmd.Parameters.AddWithValue("@flue", std.Flue);
                    cmd.Parameters.AddWithValue("@volume", std.Volume);
                    cmd.Parameters.AddWithValue("@driver", std.Driver);
                    cmd.Parameters.AddWithValue("@autobase", std.Autobase);
                    cmd.Parameters.AddWithValue("@garage", std.Garage);
                    cmd.Parameters.AddWithValue("@auto", std.Auto);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelStatement(Model.Statement std)
        {
            string sql = "DELETE FROM Statement WHERE idStatement=@idStatement";
            
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idStatement", std.IdStatement);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutStatement(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Statement", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //users
        public static async Task auth(Model.Users std)
        {
            string sql = "SELECT login, password FROM Users WHERE login=@login AND password=@password;";
            
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                { 
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@login", std.Login);
                    cmd.Parameters.AddWithValue("@password", std.Password);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task AddUsers(Model.Users std)
        {
            string sql = "INSERT INTO Users (idUsers, login, password) VALUES (NULL, @login, @password);";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@login", std.Login);
                    cmd.Parameters.AddWithValue("@password", std.Password);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task ChUsers(Model.Users std)
        {
            string sql = "UPDATE Users SET  login=@login, password=@password WHERE  idUsers=@idUsers";
            
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idUsers", std.IdUsers);
                    cmd.Parameters.AddWithValue("@password", std.Password);
                    cmd.Parameters.AddWithValue("@login", std.Login); 
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task DelUsers(Model.Users std)
        {
            string sql = "DELETE FROM Users WHERE idUsers=@idUsers";
            
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idUsers", std.IdUsers);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task OutUsers(DataGridView dgv)
        {
            try
            {
                using (var mycon = await GetConnection())
                using (var ad = new MySqlDataAdapter("select * from Users", mycon))
                {
                    DataTable tbl = new DataTable();
                    await Task.Run(() => ad.Fill(tbl));
                    dgv.DataSource = tbl;
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task Txt_driver(ComboBox std)
        {
            string sql = "SELECT idDriver FROM Driver";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                using (var reader = await cmd.ExecuteReaderAsync())
                { 
                    std.Items.Clear();
                    while (await reader.ReadAsync())
                    {

                        std.Items.Add(reader.GetValue(0).ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static async Task Txt_auto(ComboBox std)
        {   
            string sql = "SELECT idAuto FROM Auto";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    std.Items.Clear();
                    while (await reader.ReadAsync())
                    {

                        std.Items.Add(reader.GetValue(0).ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static async Task Txt_garage(ComboBox std)
        {
            string sql = "SELECT idGarage FROM Garage";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    std.Items.Clear();
                    while (await reader.ReadAsync())
                    {

                        std.Items.Add(reader.GetValue(0).ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static async Task Txt_autobase(ComboBox std)
        {
            string sql = "SELECT idAutobase FROM Autobase";
            try
            {
                using (var mycon = await GetConnection())
                using (var cmd = new MySqlCommand(sql, mycon))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    std.Items.Clear();
                    while (await reader.ReadAsync())
                    {
                        std.Items.Add(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
