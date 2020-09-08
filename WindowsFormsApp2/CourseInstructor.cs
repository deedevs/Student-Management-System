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
    public partial class CourseInstructor : Form
    {
        public CourseInstructor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        public void disp_data()
        {
            con.Open();
            String query = "SELECT t.ID,t.course_id, t.semester, t.year FROM instructor as i inner join teaches as t on i.ID = t.ID ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void CourseInstructor_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //String query = "INSERT INTO instructor ( name , dept_name) VALUES ('" + txtname.Text + "','" + txtdeptname.Text + "') ";
            String query1 = "INSERT INTO teaches (ID, course_id, sec_id, semester ,year) VALUES ('" + txtid.Text + "','" + txtcourseid.Text + "','" + txtsecid.Text + "','" + txtsemester.Text + "','" + txtyear.Text + "') ";

            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter sdf = new SqlDataAdapter(query1, con);
            sdf.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
           // txtname.Text = "";
            //txtdeptname.Text = "";
            txtcourseid.Text = "";
            disp_data();

            MessageBox.Show("INSERTED SUCCESSFULY");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
