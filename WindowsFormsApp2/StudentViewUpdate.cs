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
    public partial class StudentViewUpdate : Form
    {
        public StudentViewUpdate(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        public void disp_data()
        {
            con.Open();
            String query = "select * from student where course.course_id = takes.course_id and takes.ID = student.ID and student.name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void disp_data3()
        {
            con.Open();
            String query = "select * from student where name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void StudentViewUpdate_Load(object sender, EventArgs e)
        {
            disp_data3();
        }

        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtid.Text = row.Cells[0].Value.ToString();
            txtaddress.Text = row.Cells[4].Value.ToString();
            txtmobile.Text = row.Cells[5].Value.ToString();
            txtemail.Text = row.Cells[6].Value.ToString();
            txtcountry.Text = row.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE student set Address = '" + txtaddress.Text + "', [Mobile No.] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', Country = '" + txtcountry.Text + "'where ID = '" + txtid.Text + "' ;";
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
    }
}
