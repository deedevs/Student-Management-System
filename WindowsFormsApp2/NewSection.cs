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
    public partial class NewSection : Form
    {
        public NewSection()
        {
            InitializeComponent();

            Fillcombo();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        void Fillcombo()
        {
            con.Open();
            string query = "select * from course ;";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                courseComboBox.Items.Add(dr["course_id"].ToString());
            }
            con.Close();



        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO section (course_id , sec_id, semester, year ) VALUES ('" + courseComboBox.Text + "','" + txtsection.Text + "','" + txtsemester.Text + "','" + txtyear.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                txtsection.Text = "";
                courseComboBox.Text = "";
                txtsemester.Text = "";
                txtyear.Text = "";


                MessageBox.Show("INSERTED SUCCESSFULY");
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
           
        }
    }
}
