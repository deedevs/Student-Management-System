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
    public partial class NewCourse : Form
    {
        public NewCourse()
        {
            InitializeComponent();
            
            Fillcombo();


        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        void Fillcombo()
        {
            con.Open();
            string query = "select * from department ;";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                deptnameComboBox.Items.Add(dr["dept_name"].ToString());
            }
            con.Close();


           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO course (course_id, title, dept_name, credits ) VALUES ('" + txtcourseid.Text + "','" + txttitle.Text + "','" + deptnameComboBox.Text + "','" + txtcredits.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                txtcourseid.Text = "";
                txttitle.Text = "";
                txtcredits.Text = "";
                deptnameComboBox.Items.Clear();



                MessageBox.Show("Course Added Succesfully..");
            }
            catch (Exception)
            {

                MessageBox.Show("Already Exits");
                txtcourseid.Text = "";
                txttitle.Text = "";
                txtcredits.Text = "";
                deptnameComboBox.Items.Clear();
            }
            
            
        }
    }
}
