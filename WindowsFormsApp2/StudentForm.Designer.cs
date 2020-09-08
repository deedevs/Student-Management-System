namespace WindowsFormsApp2
{
    partial class StudentForm
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
            this.panelplayback = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.coursebtn = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelupdateSubmenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelplayback.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panelupdateSubmenu.SuspendLayout();
            this.panelsidemenu.SuspendLayout();
            this.panelchildform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelplayback
            // 
            this.panelplayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelplayback.Controls.Add(this.label1);
            this.panelplayback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelplayback.Location = new System.Drawing.Point(211, 438);
            this.panelplayback.Name = "panelplayback";
            this.panelplayback.Size = new System.Drawing.Size(773, 123);
            this.panelplayback.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(297, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // coursebtn
            // 
            this.coursebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursebtn.FlatAppearance.BorderSize = 0;
            this.coursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursebtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.coursebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.coursebtn.Location = new System.Drawing.Point(0, 123);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.coursebtn.Size = new System.Drawing.Size(211, 45);
            this.coursebtn.TabIndex = 2;
            this.coursebtn.Text = "STUDENT DETAILS";
            this.coursebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.namelabel);
            this.panellogo.Controls.Add(this.label2);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(211, 123);
            this.panellogo.TabIndex = 1;
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.namelabel.Location = new System.Drawing.Point(33, 58);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(54, 23);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome:";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(0, 78);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(211, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Registered Courses";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(211, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Change Password";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(211, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "View and Update";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelupdateSubmenu
            // 
            this.panelupdateSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelupdateSubmenu.Controls.Add(this.button1);
            this.panelupdateSubmenu.Controls.Add(this.button4);
            this.panelupdateSubmenu.Controls.Add(this.button3);
            this.panelupdateSubmenu.Controls.Add(this.button2);
            this.panelupdateSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelupdateSubmenu.Location = new System.Drawing.Point(0, 168);
            this.panelupdateSubmenu.Name = "panelupdateSubmenu";
            this.panelupdateSubmenu.Size = new System.Drawing.Size(211, 163);
            this.panelupdateSubmenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 113);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(211, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Other Students Registered";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.AutoScroll = true;
            this.panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelsidemenu.Controls.Add(this.button8);
            this.panelsidemenu.Controls.Add(this.panelupdateSubmenu);
            this.panelsidemenu.Controls.Add(this.coursebtn);
            this.panelsidemenu.Controls.Add(this.panellogo);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(211, 561);
            this.panelsidemenu.TabIndex = 3;
            // 
            // panelchildform
            // 
            this.panelchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelchildform.Controls.Add(this.pictureBox1);
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(211, 0);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(773, 438);
            this.panelchildform.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Location = new System.Drawing.Point(37, 477);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 42);
            this.button8.TabIndex = 5;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.stttuu;
            this.pictureBox1.Location = new System.Drawing.Point(251, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelchildform);
            this.Controls.Add(this.panelplayback);
            this.Controls.Add(this.panelsidemenu);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.panelplayback.ResumeLayout(false);
            this.panelplayback.PerformLayout();
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.panelupdateSubmenu.ResumeLayout(false);
            this.panelsidemenu.ResumeLayout(false);
            this.panelchildform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelplayback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelupdateSubmenu;
        private System.Windows.Forms.Panel panelsidemenu;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
    }
}