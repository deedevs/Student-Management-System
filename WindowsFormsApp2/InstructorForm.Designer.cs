namespace WindowsFormsApp2
{
    partial class InstructorForm
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
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.panelcoursesubmenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.coursebtn = new System.Windows.Forms.Button();
            this.paneldetailsSubmenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.instructorbtn = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelplayback = new System.Windows.Forms.Panel();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsidemenu.SuspendLayout();
            this.panelcoursesubmenu.SuspendLayout();
            this.paneldetailsSubmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panelplayback.SuspendLayout();
            this.panelchildform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.AutoScroll = true;
            this.panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelsidemenu.Controls.Add(this.panelcoursesubmenu);
            this.panelsidemenu.Controls.Add(this.coursebtn);
            this.panelsidemenu.Controls.Add(this.paneldetailsSubmenu);
            this.panelsidemenu.Controls.Add(this.instructorbtn);
            this.panelsidemenu.Controls.Add(this.panellogo);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(211, 438);
            this.panelsidemenu.TabIndex = 6;
            // 
            // panelcoursesubmenu
            // 
            this.panelcoursesubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelcoursesubmenu.Controls.Add(this.button1);
            this.panelcoursesubmenu.Controls.Add(this.button5);
            this.panelcoursesubmenu.Controls.Add(this.button6);
            this.panelcoursesubmenu.Controls.Add(this.button7);
            this.panelcoursesubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcoursesubmenu.Location = new System.Drawing.Point(0, 268);
            this.panelcoursesubmenu.Name = "panelcoursesubmenu";
            this.panelcoursesubmenu.Size = new System.Drawing.Size(211, 124);
            this.panelcoursesubmenu.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(0, 23);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(211, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "Register Student to courses";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(211, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Assigned Courses";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // coursebtn
            // 
            this.coursebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursebtn.FlatAppearance.BorderSize = 0;
            this.coursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursebtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.coursebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.coursebtn.Location = new System.Drawing.Point(0, 223);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.coursebtn.Size = new System.Drawing.Size(211, 45);
            this.coursebtn.TabIndex = 3;
            this.coursebtn.Text = "COURSE";
            this.coursebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // paneldetailsSubmenu
            // 
            this.paneldetailsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.paneldetailsSubmenu.Controls.Add(this.button3);
            this.paneldetailsSubmenu.Controls.Add(this.button2);
            this.paneldetailsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldetailsSubmenu.Location = new System.Drawing.Point(0, 168);
            this.paneldetailsSubmenu.Name = "paneldetailsSubmenu";
            this.paneldetailsSubmenu.Size = new System.Drawing.Size(211, 55);
            this.paneldetailsSubmenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(0, 23);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(211, 23);
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
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View and Update";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // instructorbtn
            // 
            this.instructorbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.instructorbtn.FlatAppearance.BorderSize = 0;
            this.instructorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.instructorbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.instructorbtn.Location = new System.Drawing.Point(0, 123);
            this.instructorbtn.Name = "instructorbtn";
            this.instructorbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.instructorbtn.Size = new System.Drawing.Size(211, 45);
            this.instructorbtn.TabIndex = 2;
            this.instructorbtn.Text = "INSTRUCTOR DETAILS";
            this.instructorbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructorbtn.UseVisualStyleBackColor = true;
            this.instructorbtn.Click += new System.EventHandler(this.instructorbtn_Click);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(439, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTRUCTOR FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelplayback
            // 
            this.panelplayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelplayback.Controls.Add(this.button4);
            this.panelplayback.Controls.Add(this.label1);
            this.panelplayback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelplayback.Location = new System.Drawing.Point(0, 438);
            this.panelplayback.Name = "panelplayback";
            this.panelplayback.Size = new System.Drawing.Size(984, 123);
            this.panelplayback.TabIndex = 7;
            // 
            // panelchildform
            // 
            this.panelchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelchildform.Controls.Add(this.pictureBox1);
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(211, 0);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(773, 438);
            this.panelchildform.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(0, 61);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(211, 30);
            this.button5.TabIndex = 3;
            this.button5.Text = "Student Registered";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 91);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(211, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Section";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(46, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.teacher__1_;
            this.pictureBox1.Location = new System.Drawing.Point(233, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelchildform);
            this.Controls.Add(this.panelsidemenu);
            this.Controls.Add(this.panelplayback);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.panelsidemenu.ResumeLayout(false);
            this.panelcoursesubmenu.ResumeLayout(false);
            this.paneldetailsSubmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.panelplayback.ResumeLayout(false);
            this.panelplayback.PerformLayout();
            this.panelchildform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelsidemenu;
        private System.Windows.Forms.Panel panelcoursesubmenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.Panel paneldetailsSubmenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button instructorbtn;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelplayback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}