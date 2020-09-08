namespace WindowsFormsApp2
{
    partial class AassignCourseInstructor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.instructorComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.courseComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.secComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.semesterComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.yearComboBox4 = new Guna.UI.WinForms.GunaComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.yearComboBox4);
            this.panel1.Controls.Add(this.semesterComboBox);
            this.panel1.Controls.Add(this.secComboBox2);
            this.panel1.Controls.Add(this.courseComboBox1);
            this.panel1.Controls.Add(this.instructorComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(44, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 330);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(52, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Year";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(317, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Assign Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(52, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(52, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sec_ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(52, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course_ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(52, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instructor_ID";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(210, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "ASSIGN COURSE TO INSTRUCTOR";
            // 
            // instructorComboBox
            // 
            this.instructorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.instructorComboBox.BaseColor = System.Drawing.Color.White;
            this.instructorComboBox.BorderColor = System.Drawing.Color.Silver;
            this.instructorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.instructorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.instructorComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.instructorComboBox.ForeColor = System.Drawing.Color.Black;
            this.instructorComboBox.FormattingEnabled = true;
            this.instructorComboBox.ItemHeight = 15;
            this.instructorComboBox.Location = new System.Drawing.Point(55, 46);
            this.instructorComboBox.Name = "instructorComboBox";
            this.instructorComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.instructorComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.instructorComboBox.Size = new System.Drawing.Size(209, 21);
            this.instructorComboBox.TabIndex = 12;
            // 
            // courseComboBox1
            // 
            this.courseComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.courseComboBox1.BaseColor = System.Drawing.Color.White;
            this.courseComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.courseComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.courseComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.courseComboBox1.ForeColor = System.Drawing.Color.Black;
            this.courseComboBox1.FormattingEnabled = true;
            this.courseComboBox1.ItemHeight = 15;
            this.courseComboBox1.Location = new System.Drawing.Point(55, 94);
            this.courseComboBox1.Name = "courseComboBox1";
            this.courseComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.courseComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.courseComboBox1.Size = new System.Drawing.Size(209, 21);
            this.courseComboBox1.TabIndex = 13;
            // 
            // secComboBox2
            // 
            this.secComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.secComboBox2.BaseColor = System.Drawing.Color.White;
            this.secComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.secComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.secComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.secComboBox2.ForeColor = System.Drawing.Color.Black;
            this.secComboBox2.FormattingEnabled = true;
            this.secComboBox2.ItemHeight = 15;
            this.secComboBox2.Location = new System.Drawing.Point(55, 147);
            this.secComboBox2.Name = "secComboBox2";
            this.secComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.secComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.secComboBox2.Size = new System.Drawing.Size(209, 21);
            this.secComboBox2.TabIndex = 14;
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.BackColor = System.Drawing.Color.Transparent;
            this.semesterComboBox.BaseColor = System.Drawing.Color.White;
            this.semesterComboBox.BorderColor = System.Drawing.Color.Silver;
            this.semesterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.semesterComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.semesterComboBox.ForeColor = System.Drawing.Color.Black;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.ItemHeight = 15;
            this.semesterComboBox.Location = new System.Drawing.Point(55, 208);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.semesterComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.semesterComboBox.Size = new System.Drawing.Size(209, 21);
            this.semesterComboBox.TabIndex = 15;
            // 
            // yearComboBox4
            // 
            this.yearComboBox4.BackColor = System.Drawing.Color.Transparent;
            this.yearComboBox4.BaseColor = System.Drawing.Color.White;
            this.yearComboBox4.BorderColor = System.Drawing.Color.Silver;
            this.yearComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox4.FocusedColor = System.Drawing.Color.Empty;
            this.yearComboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearComboBox4.ForeColor = System.Drawing.Color.Black;
            this.yearComboBox4.FormattingEnabled = true;
            this.yearComboBox4.ItemHeight = 15;
            this.yearComboBox4.Location = new System.Drawing.Point(55, 264);
            this.yearComboBox4.Name = "yearComboBox4";
            this.yearComboBox4.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.yearComboBox4.OnHoverItemForeColor = System.Drawing.Color.White;
            this.yearComboBox4.Size = new System.Drawing.Size(209, 21);
            this.yearComboBox4.TabIndex = 16;
            // 
            // AassignCourseInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(757, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "AassignCourseInstructor";
            this.Text = "AassignCourseInstructor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox yearComboBox4;
        private Guna.UI.WinForms.GunaComboBox semesterComboBox;
        private Guna.UI.WinForms.GunaComboBox secComboBox2;
        private Guna.UI.WinForms.GunaComboBox courseComboBox1;
        private Guna.UI.WinForms.GunaComboBox instructorComboBox;
    }
}