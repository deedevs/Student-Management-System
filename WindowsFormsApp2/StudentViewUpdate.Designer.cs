namespace WindowsFormsApp2
{
    partial class StudentViewUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Password1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtaddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtmobile = new Guna.UI.WinForms.GunaTextBox();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.txtcountry = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.studentname,
            this.Dept_Name,
            this.Credits,
            this.Address1,
            this.Mobile1,
            this.Email1,
            this.Country1,
            this.Role1,
            this.Password1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(797, 64);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Password1
            // 
            this.Password1.DataPropertyName = "Password";
            this.Password1.HeaderText = "Password";
            this.Password1.Name = "Password1";
            this.Password1.ReadOnly = true;
            this.Password1.Visible = false;
            // 
            // Role1
            // 
            this.Role1.DataPropertyName = "Role";
            this.Role1.HeaderText = "Role";
            this.Role1.Name = "Role1";
            this.Role1.ReadOnly = true;
            this.Role1.Visible = false;
            // 
            // Country1
            // 
            this.Country1.DataPropertyName = "Country";
            this.Country1.HeaderText = "Country";
            this.Country1.Name = "Country1";
            this.Country1.ReadOnly = true;
            this.Country1.Width = 150;
            // 
            // Email1
            // 
            this.Email1.DataPropertyName = "Email";
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            this.Email1.Width = 150;
            // 
            // Mobile1
            // 
            this.Mobile1.DataPropertyName = "Mobile No.";
            this.Mobile1.HeaderText = "Mobile Number";
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.ReadOnly = true;
            this.Mobile1.Width = 150;
            // 
            // Address1
            // 
            this.Address1.DataPropertyName = "Address";
            this.Address1.HeaderText = "Address";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            this.Address1.Width = 200;
            // 
            // Credits
            // 
            this.Credits.DataPropertyName = "tot_cred";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            this.Credits.DefaultCellStyle = dataGridViewCellStyle21;
            this.Credits.HeaderText = "Total Credits";
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            // 
            // Dept_Name
            // 
            this.Dept_Name.DataPropertyName = "dept_name";
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            this.Dept_Name.DefaultCellStyle = dataGridViewCellStyle22;
            this.Dept_Name.HeaderText = "Dept_Name";
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.ReadOnly = true;
            this.Dept_Name.Width = 150;
            // 
            // studentname
            // 
            this.studentname.DataPropertyName = "name";
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            this.studentname.DefaultCellStyle = dataGridViewCellStyle23;
            this.studentname.HeaderText = "Name";
            this.studentname.Name = "studentname";
            this.studentname.ReadOnly = true;
            this.studentname.Width = 150;
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "ID";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            this.Student_ID.DefaultCellStyle = dataGridViewCellStyle24;
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(144, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(144, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(144, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mobile No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(144, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(582, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.BaseColor = System.Drawing.Color.White;
            this.txtaddress.BorderColor = System.Drawing.Color.Silver;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtaddress.Location = new System.Drawing.Point(274, 217);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.Size = new System.Drawing.Size(235, 30);
            this.txtaddress.TabIndex = 29;
            // 
            // txtmobile
            // 
            this.txtmobile.BaseColor = System.Drawing.Color.White;
            this.txtmobile.BorderColor = System.Drawing.Color.Silver;
            this.txtmobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmobile.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmobile.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmobile.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmobile.Location = new System.Drawing.Point(274, 281);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PasswordChar = '\0';
            this.txtmobile.Size = new System.Drawing.Size(235, 30);
            this.txtmobile.TabIndex = 30;
            // 
            // txtemail
            // 
            this.txtemail.BaseColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.Location = new System.Drawing.Point(274, 338);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Size = new System.Drawing.Size(235, 30);
            this.txtemail.TabIndex = 31;
            // 
            // txtcountry
            // 
            this.txtcountry.BaseColor = System.Drawing.Color.White;
            this.txtcountry.BorderColor = System.Drawing.Color.Silver;
            this.txtcountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcountry.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcountry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcountry.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcountry.Location = new System.Drawing.Point(274, 396);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.PasswordChar = '\0';
            this.txtcountry.Size = new System.Drawing.Size(235, 30);
            this.txtcountry.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(144, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Student_ID";
            // 
            // txtid
            // 
            this.txtid.BaseColor = System.Drawing.Color.White;
            this.txtid.BorderColor = System.Drawing.Color.Silver;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid.Location = new System.Drawing.Point(274, 161);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(235, 30);
            this.txtid.TabIndex = 28;
            // 
            // StudentViewUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentViewUpdate";
            this.Text = "StudentViewUpdate";
            this.Load += new System.EventHandler(this.StudentViewUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaTextBox txtaddress;
        private Guna.UI.WinForms.GunaTextBox txtmobile;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private Guna.UI.WinForms.GunaTextBox txtcountry;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtid;
    }
}