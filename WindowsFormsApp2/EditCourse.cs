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
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


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

        private void EditCourse_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM course where course_id = '" + txtid.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txttitle.Text = "";
            txtdeptname.Text = "";
            txtcredits.Text = "";
            disp_data();
            MessageBox.Show("DELETED SUCCESSFULY");
        }

        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtid.Text = row.Cells[0].Value.ToString();
            txttitle.Text = row.Cells[1].Value.ToString();
            txtdeptname.Text = row.Cells[2].Value.ToString();
            txtcredits.Text = row.Cells[3].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE course set course_id = '" + txtid.Text + "', title = '" + txttitle.Text + "', dept_name = '" + txtdeptname.Text + "', credits = '" + txtcredits.Text + "'where ID = '" + txtid.Text + "' ;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txttitle.Text = "";
            txtdeptname.Text = "";
            txtcredits.Text = "";
           

            disp_data();

            MessageBox.Show("UPDATED SUCCESSFULY");
        }
    }
}
