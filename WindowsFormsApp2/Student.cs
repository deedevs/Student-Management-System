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
    public partial class Student : Form
    {
        public Student(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
            panel1.Hide();
            panel2.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void disp_data()
        {
            con.Open();
            String query = "select course.course_id, course.title from course, takes, student where course.course_id = takes.course_id and takes.ID = student.ID and student.name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void disp_data2()
        {
            con.Open();
            String query = "select name from student where dept_name IN (select student.dept_name from course, takes, student where course.course_id = takes.course_id and takes.ID = student.ID and student.name = '" + label1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dts = new DataTable();
            sda.Fill(dts);
            dataGridView2.DataSource = dts;
            con.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            disp_data();
            disp_data2();
            disp_data3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_data3()
        {
            con.Open();
            String query = "select * from student where name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE student set ID = '" + txtid.Text + "', Address = '" + txtaddress.Text + "', [Mobile No.] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', Country = '" + txtcountry.Text + "'where ID = '" + txtid.Text + "' ;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txtaddress.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
            txtcountry.Text = "";

            disp_data3();

            MessageBox.Show("UPDATED SUCCESSFULY");
        }

        private void txtoldpassword_Leave(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from usertable where Username = '" + label1.Text + "' and Password = '" + txtoldpassword.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.SelectCommand.ExecuteNonQuery();
            if (dt.Rows.Count>0)
            {
                panel1.Show();
            }
            else
            {
                MessageBox.Show("You hav enetered a wrong Password");
            }
            txtoldpassword.Text = "";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update usertable set Password =  '" + txtnewpassword.Text + "' where Username = '" + label1.Text + "'; ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Paasword has been changed succesfully...!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
