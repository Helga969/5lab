
using System;

namespace _5lab.View
{
    partial class View_Bowser
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
            this.App_tab = new System.Windows.Forms.TabControl();
            this.ViewAuto = new System.Windows.Forms.TabPage();
            this.DelAuto = new System.Windows.Forms.Button();
            this.ChAuto = new System.Windows.Forms.Button();
            this.AddAuto = new System.Windows.Forms.Button();
            this.Txt_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_id_auto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.ViewDriver = new System.Windows.Forms.TabPage();
            this.DelDriver = new System.Windows.Forms.Button();
            this.ChDriver = new System.Windows.Forms.Button();
            this.AddDriver = new System.Windows.Forms.Button();
            this.Txt_FIO_Driver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_id_driver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.ViewGarage = new System.Windows.Forms.TabPage();
            this.DelGarage = new System.Windows.Forms.Button();
            this.ChGarage = new System.Windows.Forms.Button();
            this.AddGarage = new System.Windows.Forms.Button();
            this.Txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_id_garage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGarage = new System.Windows.Forms.DataGridView();
            this.ViewAutobase = new System.Windows.Forms.TabPage();
            this.DelAutobase = new System.Windows.Forms.Button();
            this.ChAutobase = new System.Windows.Forms.Button();
            this.AddAutobase = new System.Windows.Forms.Button();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_id_autobase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAutobase = new System.Windows.Forms.DataGridView();
            this.ViewStatement = new System.Windows.Forms.TabPage();
            this.DelStatement = new System.Windows.Forms.Button();
            this.ChStatement = new System.Windows.Forms.Button();
            this.AddStatement = new System.Windows.Forms.Button();
            this.Txt_autobase = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Txt_flue = new System.Windows.Forms.ComboBox();
            this.Txt_volume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_garage = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Auto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_driver = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_id_stat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStatement = new System.Windows.Forms.DataGridView();
            this.Txt_date = new System.Windows.Forms.MaskedTextBox();
            this.App_tab.SuspendLayout();
            this.ViewAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.ViewDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.ViewGarage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarage)).BeginInit();
            this.ViewAutobase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobase)).BeginInit();
            this.ViewStatement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // App_tab
            // 
            this.App_tab.Controls.Add(this.ViewAuto);
            this.App_tab.Controls.Add(this.ViewDriver);
            this.App_tab.Controls.Add(this.ViewGarage);
            this.App_tab.Controls.Add(this.ViewAutobase);
            this.App_tab.Controls.Add(this.ViewStatement);
            this.App_tab.Location = new System.Drawing.Point(13, 13);
            this.App_tab.Name = "App_tab";
            this.App_tab.SelectedIndex = 0;
            this.App_tab.Size = new System.Drawing.Size(775, 425);
            this.App_tab.TabIndex = 0;
            // 
            // ViewAuto
            // 
            this.ViewAuto.Controls.Add(this.DelAuto);
            this.ViewAuto.Controls.Add(this.ChAuto);
            this.ViewAuto.Controls.Add(this.AddAuto);
            this.ViewAuto.Controls.Add(this.Txt_num);
            this.ViewAuto.Controls.Add(this.label2);
            this.ViewAuto.Controls.Add(this.Txt_id_auto);
            this.ViewAuto.Controls.Add(this.label1);
            this.ViewAuto.Controls.Add(this.dgvAuto);
            this.ViewAuto.Location = new System.Drawing.Point(4, 22);
            this.ViewAuto.Name = "ViewAuto";
            this.ViewAuto.Padding = new System.Windows.Forms.Padding(3);
            this.ViewAuto.Size = new System.Drawing.Size(767, 399);
            this.ViewAuto.TabIndex = 0;
            this.ViewAuto.Text = "ViewAuto";
            this.ViewAuto.UseVisualStyleBackColor = true;
            // 
            // DelAuto
            // 
            this.DelAuto.Location = new System.Drawing.Point(582, 157);
            this.DelAuto.Name = "DelAuto";
            this.DelAuto.Size = new System.Drawing.Size(75, 23);
            this.DelAuto.TabIndex = 7;
            this.DelAuto.Text = "Delete";
            this.DelAuto.UseVisualStyleBackColor = true;
            this.DelAuto.Click += new System.EventHandler(this.DelAuto_Click);
            // 
            // ChAuto
            // 
            this.ChAuto.Location = new System.Drawing.Point(582, 128);
            this.ChAuto.Name = "ChAuto";
            this.ChAuto.Size = new System.Drawing.Size(75, 23);
            this.ChAuto.TabIndex = 6;
            this.ChAuto.Text = "Change";
            this.ChAuto.UseVisualStyleBackColor = true;
            this.ChAuto.Click += new System.EventHandler(this.ChAuto_Click);
            // 
            // AddAuto
            // 
            this.AddAuto.Location = new System.Drawing.Point(582, 99);
            this.AddAuto.Name = "AddAuto";
            this.AddAuto.Size = new System.Drawing.Size(75, 23);
            this.AddAuto.TabIndex = 5;
            this.AddAuto.Text = "Add";
            this.AddAuto.UseVisualStyleBackColor = true;
            this.AddAuto.Click += new System.EventHandler(this.AddAuto_Click);
            // 
            // Txt_num
            // 
            this.Txt_num.Location = new System.Drawing.Point(582, 72);
            this.Txt_num.Name = "Txt_num";
            this.Txt_num.Size = new System.Drawing.Size(168, 20);
            this.Txt_num.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number";
            // 
            // Txt_id_auto
            // 
            this.Txt_id_auto.Location = new System.Drawing.Point(582, 32);
            this.Txt_id_auto.Name = "Txt_id_auto";
            this.Txt_id_auto.Size = new System.Drawing.Size(168, 20);
            this.Txt_id_auto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Auto";
            // 
            // dgvAuto
            // 
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(7, 7);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.Size = new System.Drawing.Size(569, 386);
            this.dgvAuto.TabIndex = 0;
            // 
            // ViewDriver
            // 
            this.ViewDriver.Controls.Add(this.DelDriver);
            this.ViewDriver.Controls.Add(this.ChDriver);
            this.ViewDriver.Controls.Add(this.AddDriver);
            this.ViewDriver.Controls.Add(this.Txt_FIO_Driver);
            this.ViewDriver.Controls.Add(this.label4);
            this.ViewDriver.Controls.Add(this.Txt_id_driver);
            this.ViewDriver.Controls.Add(this.label3);
            this.ViewDriver.Controls.Add(this.dgvDriver);
            this.ViewDriver.Location = new System.Drawing.Point(4, 22);
            this.ViewDriver.Name = "ViewDriver";
            this.ViewDriver.Padding = new System.Windows.Forms.Padding(3);
            this.ViewDriver.Size = new System.Drawing.Size(767, 399);
            this.ViewDriver.TabIndex = 1;
            this.ViewDriver.Text = "ViewDriver";
            this.ViewDriver.UseVisualStyleBackColor = true;
            // 
            // DelDriver
            // 
            this.DelDriver.Location = new System.Drawing.Point(593, 148);
            this.DelDriver.Name = "DelDriver";
            this.DelDriver.Size = new System.Drawing.Size(75, 23);
            this.DelDriver.TabIndex = 7;
            this.DelDriver.Text = "Delete";
            this.DelDriver.UseVisualStyleBackColor = true;
            this.DelDriver.Click += new System.EventHandler(this.DelDriver_Click);
            // 
            // ChDriver
            // 
            this.ChDriver.Location = new System.Drawing.Point(593, 119);
            this.ChDriver.Name = "ChDriver";
            this.ChDriver.Size = new System.Drawing.Size(75, 23);
            this.ChDriver.TabIndex = 6;
            this.ChDriver.Text = "Change";
            this.ChDriver.UseVisualStyleBackColor = true;
            this.ChDriver.Click += new System.EventHandler(this.ChDriver_Click);
            // 
            // AddDriver
            // 
            this.AddDriver.Location = new System.Drawing.Point(593, 90);
            this.AddDriver.Name = "AddDriver";
            this.AddDriver.Size = new System.Drawing.Size(75, 23);
            this.AddDriver.TabIndex = 5;
            this.AddDriver.Text = "Add";
            this.AddDriver.UseVisualStyleBackColor = true;
            this.AddDriver.Click += new System.EventHandler(this.AddDriver_Click);
            // 
            // Txt_FIO_Driver
            // 
            this.Txt_FIO_Driver.Location = new System.Drawing.Point(593, 63);
            this.Txt_FIO_Driver.Name = "Txt_FIO_Driver";
            this.Txt_FIO_Driver.Size = new System.Drawing.Size(168, 20);
            this.Txt_FIO_Driver.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FIO Driver";
            // 
            // Txt_id_driver
            // 
            this.Txt_id_driver.Location = new System.Drawing.Point(593, 23);
            this.Txt_id_driver.Name = "Txt_id_driver";
            this.Txt_id_driver.Size = new System.Drawing.Size(168, 20);
            this.Txt_id_driver.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Driver";
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(6, 6);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(578, 387);
            this.dgvDriver.TabIndex = 0;
            // 
            // ViewGarage
            // 
            this.ViewGarage.Controls.Add(this.DelGarage);
            this.ViewGarage.Controls.Add(this.ChGarage);
            this.ViewGarage.Controls.Add(this.AddGarage);
            this.ViewGarage.Controls.Add(this.Txt_address);
            this.ViewGarage.Controls.Add(this.label6);
            this.ViewGarage.Controls.Add(this.Txt_id_garage);
            this.ViewGarage.Controls.Add(this.label5);
            this.ViewGarage.Controls.Add(this.dgvGarage);
            this.ViewGarage.Location = new System.Drawing.Point(4, 22);
            this.ViewGarage.Name = "ViewGarage";
            this.ViewGarage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewGarage.Size = new System.Drawing.Size(767, 399);
            this.ViewGarage.TabIndex = 2;
            this.ViewGarage.Text = "ViewGarage";
            this.ViewGarage.UseVisualStyleBackColor = true;
            // 
            // DelGarage
            // 
            this.DelGarage.Location = new System.Drawing.Point(558, 149);
            this.DelGarage.Name = "DelGarage";
            this.DelGarage.Size = new System.Drawing.Size(75, 23);
            this.DelGarage.TabIndex = 7;
            this.DelGarage.Text = "Delete";
            this.DelGarage.UseVisualStyleBackColor = true;
            this.DelGarage.Click += new System.EventHandler(this.DelGarage_Click);
            // 
            // ChGarage
            // 
            this.ChGarage.Location = new System.Drawing.Point(558, 120);
            this.ChGarage.Name = "ChGarage";
            this.ChGarage.Size = new System.Drawing.Size(75, 23);
            this.ChGarage.TabIndex = 6;
            this.ChGarage.Text = "Change";
            this.ChGarage.UseVisualStyleBackColor = true;
            this.ChGarage.Click += new System.EventHandler(this.ChGarage_Click);
            // 
            // AddGarage
            // 
            this.AddGarage.Location = new System.Drawing.Point(558, 91);
            this.AddGarage.Name = "AddGarage";
            this.AddGarage.Size = new System.Drawing.Size(75, 23);
            this.AddGarage.TabIndex = 5;
            this.AddGarage.Text = "Add";
            this.AddGarage.UseVisualStyleBackColor = true;
            this.AddGarage.Click += new System.EventHandler(this.AddGarage_Click);
            // 
            // Txt_address
            // 
            this.Txt_address.Location = new System.Drawing.Point(558, 64);
            this.Txt_address.Name = "Txt_address";
            this.Txt_address.Size = new System.Drawing.Size(203, 20);
            this.Txt_address.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            // 
            // Txt_id_garage
            // 
            this.Txt_id_garage.Location = new System.Drawing.Point(558, 24);
            this.Txt_id_garage.Name = "Txt_id_garage";
            this.Txt_id_garage.Size = new System.Drawing.Size(203, 20);
            this.Txt_id_garage.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Garage";
            // 
            // dgvGarage
            // 
            this.dgvGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGarage.Location = new System.Drawing.Point(7, 7);
            this.dgvGarage.Name = "dgvGarage";
            this.dgvGarage.Size = new System.Drawing.Size(530, 386);
            this.dgvGarage.TabIndex = 0;
            // 
            // ViewAutobase
            // 
            this.ViewAutobase.Controls.Add(this.DelAutobase);
            this.ViewAutobase.Controls.Add(this.ChAutobase);
            this.ViewAutobase.Controls.Add(this.AddAutobase);
            this.ViewAutobase.Controls.Add(this.Txt_name);
            this.ViewAutobase.Controls.Add(this.label8);
            this.ViewAutobase.Controls.Add(this.Txt_id_autobase);
            this.ViewAutobase.Controls.Add(this.label7);
            this.ViewAutobase.Controls.Add(this.dgvAutobase);
            this.ViewAutobase.Location = new System.Drawing.Point(4, 22);
            this.ViewAutobase.Name = "ViewAutobase";
            this.ViewAutobase.Size = new System.Drawing.Size(767, 399);
            this.ViewAutobase.TabIndex = 3;
            this.ViewAutobase.Text = "ViewAutobase";
            this.ViewAutobase.UseVisualStyleBackColor = true;
            // 
            // DelAutobase
            // 
            this.DelAutobase.Location = new System.Drawing.Point(557, 155);
            this.DelAutobase.Name = "DelAutobase";
            this.DelAutobase.Size = new System.Drawing.Size(75, 23);
            this.DelAutobase.TabIndex = 7;
            this.DelAutobase.Text = "Delete";
            this.DelAutobase.UseVisualStyleBackColor = true;
            this.DelAutobase.Click += new System.EventHandler(this.DelAutobase_Click);
            // 
            // ChAutobase
            // 
            this.ChAutobase.Location = new System.Drawing.Point(557, 126);
            this.ChAutobase.Name = "ChAutobase";
            this.ChAutobase.Size = new System.Drawing.Size(75, 23);
            this.ChAutobase.TabIndex = 6;
            this.ChAutobase.Text = "Change";
            this.ChAutobase.UseVisualStyleBackColor = true;
            this.ChAutobase.Click += new System.EventHandler(this.ChAutobase_Click);
            // 
            // AddAutobase
            // 
            this.AddAutobase.Location = new System.Drawing.Point(558, 97);
            this.AddAutobase.Name = "AddAutobase";
            this.AddAutobase.Size = new System.Drawing.Size(75, 23);
            this.AddAutobase.TabIndex = 5;
            this.AddAutobase.Text = "Add";
            this.AddAutobase.UseVisualStyleBackColor = true;
            this.AddAutobase.Click += new System.EventHandler(this.AddAutobase_Click);
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(558, 70);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(206, 20);
            this.Txt_name.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name";
            // 
            // Txt_id_autobase
            // 
            this.Txt_id_autobase.Location = new System.Drawing.Point(558, 30);
            this.Txt_id_autobase.Name = "Txt_id_autobase";
            this.Txt_id_autobase.Size = new System.Drawing.Size(206, 20);
            this.Txt_id_autobase.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID Autobase";
            // 
            // dgvAutobase
            // 
            this.dgvAutobase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutobase.Location = new System.Drawing.Point(4, 4);
            this.dgvAutobase.Name = "dgvAutobase";
            this.dgvAutobase.Size = new System.Drawing.Size(547, 395);
            this.dgvAutobase.TabIndex = 0;
            // 
            // ViewStatement
            // 
            this.ViewStatement.Controls.Add(this.Txt_date);
            this.ViewStatement.Controls.Add(this.DelStatement);
            this.ViewStatement.Controls.Add(this.ChStatement);
            this.ViewStatement.Controls.Add(this.AddStatement);
            this.ViewStatement.Controls.Add(this.Txt_autobase);
            this.ViewStatement.Controls.Add(this.label16);
            this.ViewStatement.Controls.Add(this.Txt_flue);
            this.ViewStatement.Controls.Add(this.Txt_volume);
            this.ViewStatement.Controls.Add(this.label15);
            this.ViewStatement.Controls.Add(this.label14);
            this.ViewStatement.Controls.Add(this.Txt_garage);
            this.ViewStatement.Controls.Add(this.label13);
            this.ViewStatement.Controls.Add(this.Txt_Auto);
            this.ViewStatement.Controls.Add(this.label12);
            this.ViewStatement.Controls.Add(this.Txt_driver);
            this.ViewStatement.Controls.Add(this.label11);
            this.ViewStatement.Controls.Add(this.label10);
            this.ViewStatement.Controls.Add(this.Txt_id_stat);
            this.ViewStatement.Controls.Add(this.label9);
            this.ViewStatement.Controls.Add(this.dgvStatement);
            this.ViewStatement.Location = new System.Drawing.Point(4, 22);
            this.ViewStatement.Name = "ViewStatement";
            this.ViewStatement.Size = new System.Drawing.Size(767, 399);
            this.ViewStatement.TabIndex = 4;
            this.ViewStatement.Text = "ViewStatement";
            this.ViewStatement.UseVisualStyleBackColor = true;
            // 
            // DelStatement
            // 
            this.DelStatement.Location = new System.Drawing.Point(555, 371);
            this.DelStatement.Name = "DelStatement";
            this.DelStatement.Size = new System.Drawing.Size(75, 23);
            this.DelStatement.TabIndex = 21;
            this.DelStatement.Text = "Delete";
            this.DelStatement.UseVisualStyleBackColor = true;
            this.DelStatement.Click += new System.EventHandler(this.DelStatement_Click);
            // 
            // ChStatement
            // 
            this.ChStatement.Location = new System.Drawing.Point(637, 342);
            this.ChStatement.Name = "ChStatement";
            this.ChStatement.Size = new System.Drawing.Size(75, 23);
            this.ChStatement.TabIndex = 20;
            this.ChStatement.Text = "Change";
            this.ChStatement.UseVisualStyleBackColor = true;
            this.ChStatement.Click += new System.EventHandler(this.ChStatement_Click);
            // 
            // AddStatement
            // 
            this.AddStatement.Location = new System.Drawing.Point(555, 342);
            this.AddStatement.Name = "AddStatement";
            this.AddStatement.Size = new System.Drawing.Size(75, 23);
            this.AddStatement.TabIndex = 19;
            this.AddStatement.Text = "Add";
            this.AddStatement.UseVisualStyleBackColor = true;
            this.AddStatement.Click += new System.EventHandler(this.AddStatement_Click);
            // 
            // Txt_autobase
            // 
            this.Txt_autobase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_autobase.FormattingEnabled = true;
            this.Txt_autobase.Location = new System.Drawing.Point(557, 315);
            this.Txt_autobase.Name = "Txt_autobase";
            this.Txt_autobase.Size = new System.Drawing.Size(196, 21);
            this.Txt_autobase.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(554, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Autobase";
            // 
            // Txt_flue
            // 
            this.Txt_flue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_flue.FormattingEnabled = true;
            this.Txt_flue.Items.AddRange(new object[] {
            "Бензин",
            "Дизель"});
            this.Txt_flue.Location = new System.Drawing.Point(557, 231);
            this.Txt_flue.Name = "Txt_flue";
            this.Txt_flue.Size = new System.Drawing.Size(196, 21);
            this.Txt_flue.TabIndex = 16;
            // 
            // Txt_volume
            // 
            this.Txt_volume.Location = new System.Drawing.Point(557, 271);
            this.Txt_volume.Name = "Txt_volume";
            this.Txt_volume.Size = new System.Drawing.Size(196, 20);
            this.Txt_volume.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(554, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Volume";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(554, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Flue";
            // 
            // Txt_garage
            // 
            this.Txt_garage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_garage.FormattingEnabled = true;
            this.Txt_garage.Location = new System.Drawing.Point(557, 191);
            this.Txt_garage.Name = "Txt_garage";
            this.Txt_garage.Size = new System.Drawing.Size(196, 21);
            this.Txt_garage.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(554, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Garage";
            // 
            // Txt_Auto
            // 
            this.Txt_Auto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Auto.FormattingEnabled = true;
            this.Txt_Auto.Location = new System.Drawing.Point(557, 151);
            this.Txt_Auto.Name = "Txt_Auto";
            this.Txt_Auto.Size = new System.Drawing.Size(196, 21);
            this.Txt_Auto.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(554, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Auto";
            // 
            // Txt_driver
            // 
            this.Txt_driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_driver.FormattingEnabled = true;
            this.Txt_driver.Location = new System.Drawing.Point(557, 111);
            this.Txt_driver.Name = "Txt_driver";
            this.Txt_driver.Size = new System.Drawing.Size(196, 21);
            this.Txt_driver.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Driver";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Date";
            // 
            // Txt_id_stat
            // 
            this.Txt_id_stat.Location = new System.Drawing.Point(557, 32);
            this.Txt_id_stat.Name = "Txt_id_stat";
            this.Txt_id_stat.Size = new System.Drawing.Size(196, 20);
            this.Txt_id_stat.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID Statement";
            // 
            // dgvStatement
            // 
            this.dgvStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatement.Location = new System.Drawing.Point(4, 4);
            this.dgvStatement.Name = "dgvStatement";
            this.dgvStatement.Size = new System.Drawing.Size(544, 392);
            this.dgvStatement.TabIndex = 0;
            // 
            // Txt_date
            // 
            this.Txt_date.Location = new System.Drawing.Point(557, 72);
            this.Txt_date.Mask = "0000/00/00";
            this.Txt_date.Name = "Txt_date";
            this.Txt_date.Size = new System.Drawing.Size(196, 20);
            this.Txt_date.TabIndex = 22;
            // 
            // View_Bowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.App_tab);
            this.Name = "View_Bowser";
            this.Text = "View_Bowser";
            this.App_tab.ResumeLayout(false);
            this.ViewAuto.ResumeLayout(false);
            this.ViewAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.ViewDriver.ResumeLayout(false);
            this.ViewDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ViewGarage.ResumeLayout(false);
            this.ViewGarage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarage)).EndInit();
            this.ViewAutobase.ResumeLayout(false);
            this.ViewAutobase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobase)).EndInit();
            this.ViewStatement.ResumeLayout(false);
            this.ViewStatement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.TabControl App_tab;
        private System.Windows.Forms.TabPage ViewAuto;
        private System.Windows.Forms.TabPage ViewDriver;
        private System.Windows.Forms.TextBox Txt_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_id_auto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.Button DelAuto;
        private System.Windows.Forms.Button ChAuto;
        private System.Windows.Forms.Button AddAuto;
        private System.Windows.Forms.TabPage ViewGarage;
        private System.Windows.Forms.Button DelDriver;
        private System.Windows.Forms.Button ChDriver;
        private System.Windows.Forms.Button AddDriver;
        private System.Windows.Forms.TextBox Txt_FIO_Driver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_id_driver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Button DelGarage;
        private System.Windows.Forms.Button ChGarage;
        private System.Windows.Forms.Button AddGarage;
        private System.Windows.Forms.TextBox Txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_id_garage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGarage;
        private System.Windows.Forms.TabPage ViewAutobase;
        private System.Windows.Forms.TabPage ViewStatement;
        private System.Windows.Forms.DataGridView dgvAutobase;
        private System.Windows.Forms.DataGridView dgvStatement;
        private System.Windows.Forms.Button DelAutobase;
        private System.Windows.Forms.Button ChAutobase;
        private System.Windows.Forms.Button AddAutobase;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_id_autobase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DelStatement;
        private System.Windows.Forms.Button ChStatement;
        private System.Windows.Forms.Button AddStatement;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_volume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_id_stat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Txt_date;
        public System.Windows.Forms.ComboBox Txt_autobase;
        public System.Windows.Forms.ComboBox Txt_flue;
        public System.Windows.Forms.ComboBox Txt_garage;
        public System.Windows.Forms.ComboBox Txt_Auto;
        public System.Windows.Forms.ComboBox Txt_driver;
    }
}