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
    public partial class datagridview : Form
    {
        public datagridview()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO course (course_id, title, dept_name, credits ) VALUES ('"+txtcourseid.Text+ "','" + txttitle.Text + "','" + txtdeptname.Text + "','" + txtcredits.Text + "') ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtcourseid.Text = "";
            txttitle.Text = "";
            txtdeptname.Text = "";
            txtcredits.Text = "";
            disp_data();

            MessageBox.Show("INSERTED SUCCESSFULY");
        }

        
        public void disp_data()
        {
            con.Open();
            String query = "SELECT * FROM course  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            con.Open();
            String query = "DELETE FROM course where course_id = '" + txtcourseid.Text + "'"; 
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtcourseid.Text = "";
            disp_data();
            MessageBox.Show("DELETED SUCCESSFULY");
        }

        private void datagridview_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
