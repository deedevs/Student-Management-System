namespace WindowsFormsApp2
{
    partial class FC
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDNEWCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWTEACHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWCOURSEToolStripMenuItem,
            this.aDDNEWTEACHERToolStripMenuItem,
            this.aDDNEWSTUDENTToolStripMenuItem,
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDNEWCOURSEToolStripMenuItem
            // 
            this.aDDNEWCOURSEToolStripMenuItem.Name = "aDDNEWCOURSEToolStripMenuItem";
            this.aDDNEWCOURSEToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.aDDNEWCOURSEToolStripMenuItem.Text = "ADD NEW COURSE";
            this.aDDNEWCOURSEToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWCOURSEToolStripMenuItem_Click);
            // 
            // aDDNEWTEACHERToolStripMenuItem
            // 
            this.aDDNEWTEACHERToolStripMenuItem.Name = "aDDNEWTEACHERToolStripMenuItem";
            this.aDDNEWTEACHERToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.aDDNEWTEACHERToolStripMenuItem.Text = "ADD NEW TEACHER";
            this.aDDNEWTEACHERToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWTEACHERToolStripMenuItem_Click);
            // 
            // aDDNEWSTUDENTToolStripMenuItem
            // 
            this.aDDNEWSTUDENTToolStripMenuItem.Name = "aDDNEWSTUDENTToolStripMenuItem";
            this.aDDNEWSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.aDDNEWSTUDENTToolStripMenuItem.Text = "ADD NEW STUDENT";
            this.aDDNEWSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWSTUDENTToolStripMenuItem_Click);
            // 
            // aSSIGNCOURSETOINSTRUCTORToolStripMenuItem
            // 
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem.Name = "aSSIGNCOURSETOINSTRUCTORToolStripMenuItem";
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem.Text = "ASSIGN COURSE TO INSTRUCTOR";
            this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem.Click += new System.EventHandler(this.aSSIGNCOURSETOINSTRUCTORToolStripMenuItem_Click);
            // 
            // FC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(795, 412);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FC";
            this.Text = "FC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWTEACHERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSSIGNCOURSETOINSTRUCTORToolStripMenuItem;
    }
}