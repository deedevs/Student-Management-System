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
    public partial class InstructorViewUpdate : Form
    {
        public InstructorViewUpdate(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        public void disp_data3()
        {
            con.Open();
            String query = "select * from instructor where name = '" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void InstructorViewUpdate_Load(object sender, EventArgs e)
        {
            disp_data3();
        }

        
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE instructor set Address = '" + txtaddress.Text + "', [Mobile No.] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', Country = '" + txtcountry.Text + "'where ID = '" + txtid.Text + "' ;";
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

        int indexRow;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                txtid.Text = row.Cells[0].Value.ToString();
                txtaddress.Text = row.Cells[3].Value.ToString();
                txtmobile.Text = row.Cells[4].Value.ToString();
                txtemail.Text = row.Cells[5].Value.ToString();
                txtcountry.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
