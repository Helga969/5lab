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
    public partial class ViewAuthorization : Form
    {
        public ViewAuthorization()
        {
            InitializeComponent();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            if (Txt_login.Text == "admin" && Txt_password.Text == string.Empty)
            {
                View.ViewUsers frm = new ViewUsers();
                frm.ShowDialog();
            }
            else
            {
                if (Txt_login.Text==string.Empty && Txt_password.Text==string.Empty)
                {
                    MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Controller auth = new Controller(this);
                    auth.btnAuthorization_Click();
                    View.View_Bowser frm = new View_Bowser();
                    frm.ShowDialog();
                
                }
            }
            
        }
        public string login { get => this.Txt_login.Text; set => this.Txt_login.Text = value; }
        public string pass { get => this.Txt_password.Text; set => this.Txt_password.Text = value; }
    }
}
