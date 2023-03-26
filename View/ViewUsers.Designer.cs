
namespace _5lab.View
{
    partial class ViewUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_idUsers = new System.Windows.Forms.TextBox();
            this.Txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUsers = new System.Windows.Forms.Button();
            this.ChUsers = new System.Windows.Forms.Button();
            this.DelUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(590, 426);
            this.dgvUsers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID user";
            // 
            // Txt_idUsers
            // 
            this.Txt_idUsers.Location = new System.Drawing.Point(611, 29);
            this.Txt_idUsers.Name = "Txt_idUsers";
            this.Txt_idUsers.Size = new System.Drawing.Size(177, 20);
            this.Txt_idUsers.TabIndex = 2;
            // 
            // Txt_login
            // 
            this.Txt_login.Location = new System.Drawing.Point(611, 69);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(177, 20);
            this.Txt_login.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(611, 109);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(177, 20);
            this.Txt_password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // AddUsers
            // 
            this.AddUsers.Location = new System.Drawing.Point(611, 136);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(75, 23);
            this.AddUsers.TabIndex = 7;
            this.AddUsers.Text = "Add";
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // ChUsers
            // 
            this.ChUsers.Location = new System.Drawing.Point(611, 165);
            this.ChUsers.Name = "ChUsers";
            this.ChUsers.Size = new System.Drawing.Size(75, 23);
            this.ChUsers.TabIndex = 8;
            this.ChUsers.Text = "Change";
            this.ChUsers.UseVisualStyleBackColor = true;
            this.ChUsers.Click += new System.EventHandler(this.ChUsers_Click);
            // 
            // DelUsers
            // 
            this.DelUsers.Location = new System.Drawing.Point(611, 194);
            this.DelUsers.Name = "DelUsers";
            this.DelUsers.Size = new System.Drawing.Size(75, 23);
            this.DelUsers.TabIndex = 9;
            this.DelUsers.Text = "Delete";
            this.DelUsers.UseVisualStyleBackColor = true;
            this.DelUsers.Click += new System.EventHandler(this.DelUsers_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelUsers);
            this.Controls.Add(this.ChUsers);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_idUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ViewUsers";
            this.Text = "ViewUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_idUsers;
        private System.Windows.Forms.TextBox Txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Button ChUsers;
        private System.Windows.Forms.Button DelUsers;
    }
}