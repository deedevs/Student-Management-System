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
    public partial class Instructor : Form
    {
        public Instructor(string username2)
        {
            InitializeComponent();
            label2.Text = username2;
        }
        int indexRow;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_data3()
        {
            con.Open();
            String query = "select ID, name, dept_name, Address, Email, [Mobile No.], Country from instructor where name = '" + label2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            disp_data3();
            disp_data4();
        }

        public void disp_data4()
        {
            con.Open();
            String query = "select teaches.course_id from instructor,teaches where instructor.ID = teaches.ID and instructor.name = '" + label2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select student.name, student.ID from student, takes where student.ID = takes.ID and takes.course_id ='" + txtid.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textid.Text = row.Cells[0].Value.ToString();
            txtaddress.Text = row.Cells[3].Value.ToString();
            txtmobile.Text = row.Cells[4].Value.ToString();
            txtemail.Text = row.Cells[5].Value.ToString();
            txtcountry.Text = row.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE instructor set ID = '" + textid.Text + "', Address = '" + txtaddress.Text + "', [Mobile No.] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', Country = '" + txtcountry.Text + "'where ID = '" + textid.Text + "' ;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            textid.Text = "";
            txtaddress.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
            txtcountry.Text = "";

            disp_data3();

            MessageBox.Show("UPDATED SUCCESSFULY");
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
  
}


