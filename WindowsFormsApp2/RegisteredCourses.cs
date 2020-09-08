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
    public partial class RegisteredCourses : Form
    {
        public RegisteredCourses(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        public void disp_data()
        {
            con.Open();
            String query = "select course.course_id, course.title, student.dept_name, takes.semester, takes.year from course, takes, student where course.course_id = takes.course_id and takes.ID = student.ID and student.name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void RegisteredCourses_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
