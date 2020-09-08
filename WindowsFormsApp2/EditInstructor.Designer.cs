namespace WindowsFormsApp2
{
    partial class EditInstructor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdeptname = new Guna.UI.WinForms.GunaTextBox();
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.txtid = new Guna.UI.WinForms.GunaTextBox();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.studentname,
            this.Dept_Name,
            this.Address1,
            this.Mobile1,
            this.Email1,
            this.Country1,
            this.Role1,
            this.Password1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(773, 161);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 60);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE AND DELETE";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(511, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 61;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(511, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 60;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(300, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Dept_Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(133, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(68, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Instructor_ID";
            // 
            // txtdeptname
            // 
            this.txtdeptname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtdeptname.BaseColor = System.Drawing.Color.White;
            this.txtdeptname.BorderColor = System.Drawing.Color.Silver;
            this.txtdeptname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdeptname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdeptname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdeptname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdeptname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdeptname.Location = new System.Drawing.Point(398, 319);
            this.txtdeptname.Name = "txtdeptname";
            this.txtdeptname.PasswordChar = '\0';
            this.txtdeptname.Size = new System.Drawing.Size(107, 26);
            this.txtdeptname.TabIndex = 54;
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.Silver;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtname.Location = new System.Drawing.Point(182, 360);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.Size = new System.Drawing.Size(98, 26);
            this.txtname.TabIndex = 53;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtid.BaseColor = System.Drawing.Color.White;
            this.txtid.BorderColor = System.Drawing.Color.Silver;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid.Location = new System.Drawing.Point(182, 319);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(98, 26);
            this.txtid.TabIndex = 52;
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "ID";
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.Student_ID.DefaultCellStyle = dataGridViewCellStyle16;
            this.Student_ID.HeaderText = "Instructor_ID";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 120;
            // 
            // studentname
            // 
            this.studentname.DataPropertyName = "name";
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            this.studentname.DefaultCellStyle = dataGridViewCellStyle17;
            this.studentname.HeaderText = "Name";
            this.studentname.Name = "studentname";
            this.studentname.ReadOnly = true;
            this.studentname.Width = 150;
            // 
            // Dept_Name
            // 
            this.Dept_Name.DataPropertyName = "dept_name";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            this.Dept_Name.DefaultCellStyle = dataGridViewCellStyle18;
            this.Dept_Name.HeaderText = "Dept_Name";
            this.Dept_Name.Name = "Dept_Name";
            this.Dept_Name.ReadOnly = true;
            this.Dept_Name.Width = 150;
            // 
            // Address1
            // 
            this.Address1.DataPropertyName = "Address";
            this.Address1.HeaderText = "Address";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            this.Address1.Width = 200;
            // 
            // Mobile1
            // 
            this.Mobile1.DataPropertyName = "Mobile No.";
            this.Mobile1.HeaderText = "Mobile Number";
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.ReadOnly = true;
            this.Mobile1.Width = 150;
            // 
            // Email1
            // 
            this.Email1.DataPropertyName = "Email";
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            this.Email1.Width = 150;
            // 
            // Country1
            // 
            this.Country1.DataPropertyName = "Country";
            this.Country1.HeaderText = "Country";
            this.Country1.Name = "Country1";
            this.Country1.ReadOnly = true;
            this.Country1.Width = 150;
            // 
            // Role1
            // 
            this.Role1.DataPropertyName = "Role";
            this.Role1.HeaderText = "Role";
            this.Role1.Name = "Role1";
            this.Role1.ReadOnly = true;
            this.Role1.Visible = false;
            // 
            // Password1
            // 
            this.Password1.DataPropertyName = "Password";
            this.Password1.HeaderText = "Password";
            this.Password1.Name = "Password1";
            this.Password1.ReadOnly = true;
            this.Password1.Visible = false;
            // 
            // EditInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(776, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdeptname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "EditInstructor";
            this.Text = "EditInstructor";
            this.Load += new System.EventHandler(this.EditInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtdeptname;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI.WinForms.GunaTextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password1;
    }
}