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
    public partial class OtherStudentsRegistered : Form
    {
        public OtherStudentsRegistered(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        public void disp_data2()
        {
            con.Open();
            String query = "select name from student where dept_name IN (select student.dept_name from course, takes, student where course.course_id = takes.course_id and takes.ID = student.ID and student.name = '" + label1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dts = new DataTable();
            sda.Fill(dts);
            dataGridView1.DataSource = dts;
            con.Close();
        }

        private void OtherStudentsRegistered_Load(object sender, EventArgs e)
        {
            disp_data2();
        }
    }
}
