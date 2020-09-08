using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentForm : Form
    {
        public StudentForm(string Username)
        {
            InitializeComponent();
            customizeDesign();
            namelabel.Text = Username;
        }
        private void customizeDesign()
        {
            panelupdateSubmenu.Visible = false;
           
        }
        private void hidesubmenu()
        {
            if (panelupdateSubmenu.Visible == true)
                panelupdateSubmenu.Visible = false;
            
          
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            showsubmenu(panelupdateSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildform(new StudentViewUpdate(namelabel.Text));
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildform(new ChangePassword(namelabel.Text));
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildform(new RegisteredCourses(namelabel.Text));
            hidesubmenu();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        private Form activeForm = null;

        private void openChildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildform(new OtherStudentsRegistered(namelabel.Text));
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 ff = new Form1();
            ff.Show();

        }
    }
}
