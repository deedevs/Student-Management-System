namespace WindowsFormsApp2
{
    partial class AssignInstructrosStudent
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
            this.instructorComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.studentComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.instructorComboBox1);
            this.panel1.Controls.Add(this.studentComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(77, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 229);
            this.panel1.TabIndex = 4;
            // 
            // instructorComboBox1
            // 
            this.instructorComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.instructorComboBox1.BaseColor = System.Drawing.Color.White;
            this.instructorComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.instructorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.instructorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.instructorComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.instructorComboBox1.ForeColor = System.Drawing.Color.Black;
            this.instructorComboBox1.FormattingEnabled = true;
            this.instructorComboBox1.ItemHeight = 15;
            this.instructorComboBox1.Location = new System.Drawing.Point(30, 134);
            this.instructorComboBox1.Name = "instructorComboBox1";
            this.instructorComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.instructorComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.instructorComboBox1.Size = new System.Drawing.Size(209, 21);
            this.instructorComboBox1.TabIndex = 14;
            // 
            // studentComboBox
            // 
            this.studentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.studentComboBox.BaseColor = System.Drawing.Color.White;
            this.studentComboBox.BorderColor = System.Drawing.Color.Silver;
            this.studentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.studentComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentComboBox.ForeColor = System.Drawing.Color.Black;
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.ItemHeight = 15;
            this.studentComboBox.Location = new System.Drawing.Point(30, 86);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.studentComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.studentComboBox.Size = new System.Drawing.Size(209, 21);
            this.studentComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student_ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instructor_ID";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(258, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Assign Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(220, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "ASSIGN STUDENT TO INSTRUCTOR";
            // 
            // AssignInstructrosStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(757, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "AssignInstructrosStudent";
            this.Text = "AssignInstructrosStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox instructorComboBox1;
        private Guna.UI.WinForms.GunaComboBox studentComboBox;
    }
}