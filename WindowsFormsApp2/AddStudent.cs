using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO student (ID, name , dept_name,tot_cred  ) VALUES ('" + txtid.Text + "','" + txtname.Text + "','" + txtdeptname.Text + "','" + txttotcred.Text + "') ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txtname.Text = "";
            txtdeptname.Text = "";
            txttotcred.Text = "";
            disp_data();

            MessageBox.Show("INSERTED SUCCESSFULY");
        }
        public void disp_data()
        {
            con.Open();
            String query = "SELECT * FROM student  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM student where ID = '" + txtid.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            disp_data();
            MessageBox.Show("DELETED SUCCESSFULY");
        }
    }
}
