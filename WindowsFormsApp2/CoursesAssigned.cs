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
    public partial class CoursesAssigned : Form
    {
        public CoursesAssigned(string Username)
        {
            InitializeComponent();
            label4.Text = Username;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        public void disp_data4()
        {
            con.Open();
            String query = "select teaches.course_id, instructor.name from instructor,teaches where instructor.ID = teaches.ID and instructor.name = '" + label4.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void CoursesAssigned_Load(object sender, EventArgs e)
        {
            disp_data4();
        }
    }
}
