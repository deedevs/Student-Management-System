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
    public partial class AassignCourseInstructor : Form
    {
        public AassignCourseInstructor()
        {
            InitializeComponent();

            Fillcombo();
            Fillcombo1();
            Fillcombo2();
            Fillcombo3();
            Fillcombo4();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        void Fillcombo()
        {
            con.Open();
            string query = "select ID from instructor ;";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                instructorComboBox.Items.Add(dr["ID"].ToString());
            }
            con.Close();
        }
        void Fillcombo1()
        {
            con.Open();


            string query1 = "select * from section ;";

            SqlCommand cmd = new SqlCommand(query1, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                courseComboBox1.Items.Add(dr["course_id"].ToString());
            }
            con.Close();
        }
        void Fillcombo2()
        {
            con.Open();
            
            string query2 = "select distinct(sec_id) from section ;";

            SqlCommand cmd = new SqlCommand(query2, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                secComboBox2.Items.Add(dr["sec_id"].ToString());
            }
            con.Close();
        }
        void Fillcombo3()
        {
            con.Open();
            


            
            string query3 = "select distinct(semester) from section ;";
             

            SqlCommand cmd = new SqlCommand(query3, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                semesterComboBox.Items.Add(dr["semester"].ToString());
            }
            con.Close();
        }
        void Fillcombo4()
        {
            con.Open();
           
            string query4 = "select distinct(year) from section ;";

            SqlCommand cmd = new SqlCommand(query4, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                yearComboBox4.Items.Add(dr["year"].ToString());
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String query = "INSERT INTO teaches (ID, course_id , sec_id, semester, year) VALUES ('" + instructorComboBox.Text + "','" + courseComboBox1.Text + "','" + secComboBox2.Text + "','" + semesterComboBox.Text + "','" + yearComboBox4.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
               
                instructorComboBox.Items.Clear();
                courseComboBox1.Items.Clear();
                secComboBox2.Items.Clear();
                semesterComboBox.Items.Clear();
                yearComboBox4.Items.Clear();


                MessageBox.Show("ASSIGNED SUCCESSFULY");
            }
            catch (Exception)
            {

                MessageBox.Show("Already Exits");
            }
            

        }
    }
}
