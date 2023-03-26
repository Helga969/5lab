using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5lab.View
{
    public partial class View_Bowser : Form
    {
        public View_Bowser()
        {
            InitializeComponent();
            DataBase.OutAuto(dgvAuto);
            DataBase.OutDriver(dgvDriver);
            DataBase.OutGarage(dgvGarage);
            DataBase.OutAutobase(dgvAutobase);
            DataBase.OutStatement(dgvStatement);
            DataBase.Txt_driver(Txt_driver);
            DataBase.Txt_auto(Txt_Auto);
            DataBase.Txt_garage(Txt_garage);
            DataBase.Txt_autobase(Txt_autobase);
        }

        private void AddAuto_Click(object sender, EventArgs e)
        {
            if (Txt_num.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller au = new Controller(this);
                au.AddAuto_Click();
                DataBase.OutAuto(dgvAuto);
            }
        }

        private void ChAuto_Click(object sender, EventArgs e)
        {
            if (Txt_num.Text == string.Empty||Txt_id_auto.Text==string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller au = new Controller(this);
                au.ChAuto_Click();
                DataBase.OutAuto(dgvAuto);
            }
        }

        private void DelAuto_Click(object sender, EventArgs e)
        {
            if (Txt_id_auto.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller au = new Controller(this);
                au.DelAuto_Click();
                DataBase.OutAuto(dgvAuto);
            }
        }
        public int idAu { get => Convert.ToInt32(this.Txt_id_auto.Text); set => this.Txt_id_auto.Text = value.ToString(); }
        public string Num { get => this.Txt_num.Text; set => this.Txt_num.Text = value; }
        

        private void AddDriver_Click(object sender, EventArgs e)
        {
            if (Txt_FIO_Driver.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller dr = new Controller(this);
                dr.AddDriver_Click();
                DataBase.OutDriver(dgvDriver);
            }
        }

        private void ChDriver_Click(object sender, EventArgs e)
        {
            if (Txt_FIO_Driver.Text == string.Empty||Txt_id_driver.Text==string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller dr = new Controller(this);
                dr.ChDriver_Click();
                DataBase.OutDriver(dgvDriver);
            }
        }

        private void DelDriver_Click(object sender, EventArgs e)
        {
            if (Txt_id_driver.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller dr = new Controller(this);
                dr.DelDriver_Click();
                DataBase.OutDriver(dgvDriver);
            }
        }
        public int idDr { get => Convert.ToInt32(this.Txt_id_driver.Text); set => this.Txt_id_driver.Text = value.ToString(); }
        public string fio { get => this.Txt_FIO_Driver.Text; set => this.Txt_FIO_Driver.Text = value; }
        private void AddGarage_Click(object sender, EventArgs e)
        {
            if (Txt_address.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller gr = new Controller(this);
                gr.AddGarage_Click();
                DataBase.OutGarage(dgvGarage);
            }
        }

        private void ChGarage_Click(object sender, EventArgs e)
        {
            if (Txt_address.Text == string.Empty||Txt_id_garage.Text==string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller gr = new Controller(this);
                gr.ChGarage_Click();
                DataBase.OutGarage(dgvGarage);
            }
        }

        private void DelGarage_Click(object sender, EventArgs e)
        {
            if (Txt_id_garage.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller gr = new Controller(this);
                gr.DelGarage_Click();
                DataBase.OutGarage(dgvGarage);
            }
        }
        public int idGr { get => Convert.ToInt32(this.Txt_id_garage.Text); set => this.Txt_id_garage.Text = value.ToString(); }
        public string Addr { get => this.Txt_address.Text; set => this.Txt_address.Text = value; }
        private void AddAutobase_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller ab = new Controller(this);
                ab.AddAutobase_Click();
                DataBase.OutAutobase(dgvAutobase);
            }
        }

        private void ChAutobase_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text == string.Empty||Txt_id_autobase.Text==string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller ab = new Controller(this);
                ab.ChAutobase_Click();
                DataBase.OutAutobase(dgvAutobase);
            }
        }

        private void DelAutobase_Click(object sender, EventArgs e)
        {
            if (Txt_id_autobase.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller ab = new Controller(this);
                ab.DelAutobase_Click();
                DataBase.OutAutobase(dgvAutobase);
            }
        }
        public int idaubs { get => Convert.ToInt32(this.Txt_id_autobase.Text); set => this.Txt_id_autobase.Text = value.ToString(); }
        public string nm { get => this.Txt_name.Text; set => this.Txt_name.Text = value; }
        private void AddStatement_Click(object sender, EventArgs e)
        {
            if (Txt_volume.Text == string.Empty || Txt_date.Text == string.Empty || Txt_flue.Text == string.Empty || Txt_driver.Text == string.Empty || Txt_autobase.Text == string.Empty || Txt_garage.Text == string.Empty || Txt_Auto.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller st = new Controller(this);
                st.AddStatement_Click();
                DataBase.OutStatement(dgvStatement);
            }
        }

        private void ChStatement_Click(object sender, EventArgs e)
        {
            if (Txt_id_stat.Text == string.Empty || Txt_volume.Text == string.Empty || Txt_date.Text == string.Empty || Txt_flue.Text == string.Empty || Txt_driver.Text == string.Empty || Txt_autobase.Text == string.Empty || Txt_garage.Text == string.Empty || Txt_Auto.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller st = new Controller(this);
                st.ChStatement_Click();
                DataBase.OutStatement(dgvStatement);
            }
        }
        private void DelStatement_Click(object sender, EventArgs e)
        {
            if (Txt_id_stat.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller st = new Controller(this);
                st.DelStatement_Click();
                DataBase.OutStatement(dgvStatement);
            }
        }
        public int idSt { get => Convert.ToInt32(this.Txt_id_stat.Text); set => this.Txt_id_stat.Text = value.ToString(); }
        public string Date { get => this.Txt_date.Text; set => this.Txt_date.Text = value; }
        public string Flue { get => this.Txt_flue.Text; set => this.Txt_flue.Text = value; }
        public float Volume { get => Convert.ToSingle( this.Txt_volume.Text); set => this.Txt_volume.Text = value.ToString(); }
        public int driv { get => Convert.ToInt32(this.Txt_driver.Text); set => this.Txt_driver.Text = value.ToString(); }
        public int autoba { get => Convert.ToInt32(this.Txt_autobase.Text); set => this.Txt_autobase.Text = value.ToString(); }
        public int garage { get => Convert.ToInt32(this.Txt_garage.Text); set => this.Txt_garage.Text = value.ToString(); }
        public int auto { get => Convert.ToInt32(this.Txt_Auto.Text); set => this.Txt_Auto.Text = value.ToString(); }

        private void Txt_id_auto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }
    }
}
