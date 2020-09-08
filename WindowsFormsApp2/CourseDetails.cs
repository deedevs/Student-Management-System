using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CourseDetails : Form
    {
        public CourseDetails(string Username )
        {
            InitializeComponent();
            label1.Text = Username;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        public void disp_data()
        {
            con.Open();
            String query = "select distinct student.name, student.ID, teaches.course_id, course.title from student, takes, section,course, teaches, instructor where student.ID = takes.ID and takes.course_id = section.course_id and section.course_id = teaches.course_id and section.course_id = course.course_id and  teaches.ID =instructor.ID and instructor.name = '" + label1.Text + "';";      
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseDetails_Load_1(object sender, EventArgs e)
        {
            disp_data();
        }

        // "SELECT student.id,student.name,takes.course_id,course.title,takes.sec_id,takes.semester,takes.year FROM section,course,student,takes WHERE section.course_id = course.course_id AND section.course_id = takes.course_id AND takes.ID = student.ID" ;

    }
}
