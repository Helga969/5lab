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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
            DataBase.OutUsers(dgvUsers);
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            if (Txt_login.Text == string.Empty || Txt_password.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller us = new Controller(this);
                us.AddUsers_Click();
                DataBase.OutUsers(dgvUsers);
            }
        }

        private void ChUsers_Click(object sender, EventArgs e)
        {
            if (Txt_login.Text == string.Empty || Txt_password.Text == string.Empty||Txt_idUsers.Text==string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller us = new Controller(this);
                us.ChUsers_Click();
                DataBase.OutUsers(dgvUsers);
            }
        }

        private void DelUsers_Click(object sender, EventArgs e)
        {
            if (Txt_idUsers.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller us = new Controller(this);
                us.DelUsers_Click();
                DataBase.OutUsers(dgvUsers);
            }
        }
        public string Login { get => this.Txt_login.Text; set => this.Txt_login.Text = value; }
        public string Passw { get => this.Txt_password.Text; set => this.Txt_password.Text = value; }
        public int idUSR { get => Convert.ToInt32(this.Txt_idUsers.Text); set => this.Txt_idUsers.Text = value.ToString(); }
    }
}
