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
    public partial class AssignInstructrosStudent : Form
    {
        public AssignInstructrosStudent()
        {
            InitializeComponent();

            Fillcombo();
            Fillcombo1();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        void Fillcombo()
        {
            con.Open();
            string query = "select ID from student ;";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                studentComboBox.Items.Add(dr["ID"].ToString());
            }
            con.Close();
        }

        void Fillcombo1()
        {
            con.Open();
            string query = "select ID from instructor ;";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
               instructorComboBox1.Items.Add(dr["ID"].ToString());
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String query = "INSERT INTO advisor (s_ID, i_ID) VALUES ('" + studentComboBox.Text + "','" + instructorComboBox1.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                /*txtstudentid.Text = "";
                txtinstructorid.Text = ""; */



                MessageBox.Show("ASSIGNED SUCCESSFULLY");
            }
            catch (Exception)
            {

                MessageBox.Show("Student already assigned");
            }
            
        }
    }
}
