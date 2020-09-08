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
    public partial class FacultyCoordinator : Form
    {
        public FacultyCoordinator()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelCourseSubmenu.Visible = false;
            panelstudentsubmenu.Visible = false;
            panelinstructorsubmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelCourseSubmenu.Visible == true)
                panelCourseSubmenu.Visible = false;
            if (panelstudentsubmenu.Visible == true)
                panelstudentsubmenu.Visible = false;
            if (panelinstructorsubmenu.Visible == true)
                panelinstructorsubmenu.Visible = false;
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
            showsubmenu(panelCourseSubmenu );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildform(new NewCourse());
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildform(new ViewCourse());
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildform(new EditCourse());
            hidesubmenu();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            showsubmenu(panelstudentsubmenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildform(new NewStudentcs());
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildform(new ViewStudent());
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildform(new EditStudent());
            hidesubmenu();
        }

        private void instructorbtn_Click(object sender, EventArgs e)
        {
            showsubmenu(panelinstructorsubmenu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildform(new NewInstructor());
            hidesubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildform(new ViewInstructor());
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildform(new NewSection());
            hidesubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildform(new AassignCourseInstructor());
            hidesubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildform(new AssignInstructrosStudent());
            hidesubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildform(new EditInstructor());
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
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 ff = new Form1();
            ff.Show();
        }
    }
}
