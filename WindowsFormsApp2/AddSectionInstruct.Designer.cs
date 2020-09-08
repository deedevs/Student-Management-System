namespace WindowsFormsApp2
{
    partial class AddSectionInstruct
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
            this.courseComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.courseComboBox);
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtsemester);
            this.panel1.Controls.Add(this.txtsection);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(52, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 330);
            this.panel1.TabIndex = 4;
            // 
            // courseComboBox
            // 
            this.courseComboBox.BackColor = System.Drawing.Color.Transparent;
            this.courseComboBox.BaseColor = System.Drawing.Color.White;
            this.courseComboBox.BorderColor = System.Drawing.Color.Silver;
            this.courseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.courseComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.courseComboBox.ForeColor = System.Drawing.Color.Black;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.ItemHeight = 15;
            this.courseComboBox.Location = new System.Drawing.Point(50, 69);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.courseComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.courseComboBox.Size = new System.Drawing.Size(209, 21);
            this.courseComboBox.TabIndex = 11;
            // 
            // txtyear
            // 
            this.txtyear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtyear.Location = new System.Drawing.Point(50, 239);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(209, 20);
            this.txtyear.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(56, 218);
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
            this.button2.Location = new System.Drawing.Point(305, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add New Section";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsemester
            // 
            this.txtsemester.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsemester.Location = new System.Drawing.Point(50, 183);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(209, 20);
            this.txtsemester.TabIndex = 7;
            // 
            // txtsection
            // 
            this.txtsection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsection.Location = new System.Drawing.Point(50, 125);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(209, 20);
            this.txtsection.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(56, 162);
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
            this.label4.Location = new System.Drawing.Point(56, 104);
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
            this.label3.Location = new System.Drawing.Point(56, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course_ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(312, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADD SECTION";
            // 
            // AddSectionInstruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(755, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "AddSectionInstruct";
            this.Text = "AddSectionInstruct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox courseComboBox;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}