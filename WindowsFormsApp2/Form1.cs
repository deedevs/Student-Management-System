
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
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;


            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            SqlCommand cmd = new SqlCommand("select Role from fc_table where Username = '" + txtusername.Text + "' and Password = '" + txtpassword.Text + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCommand cmd1 = new SqlCommand("select Role from instructor where name = '" + txtusername.Text + "' and Password = '" +password + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd1);
            DataTable dts = new DataTable();
            sd.Fill(dts);
            SqlCommand cmd2 = new SqlCommand("select Role from student where name = '" + txtusername.Text + "' and Password = '" +password+ "' ", con);
            SqlDataAdapter sdf = new SqlDataAdapter(cmd2);
            DataTable dtf = new DataTable();
            sdf.Fill(dtf);


            if (dt.Rows.Count > 0)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "FC")
                {
                    FacultyCoordinator ss = new FacultyCoordinator();
                    ss.Show();
                }
            }

            else if (dts.Rows.Count > 0)
            {
                this.Hide();
                if (dts.Rows[0][0].ToString() == "Instructor")
                {
                    InstructorForm sf = new InstructorForm(txtusername.Text);
                    sf.Show();
                }
            }

            else if (dtf.Rows.Count > 0)
            {
                this.Hide();
                if (dtf.Rows[0][0].ToString() == "Student")
                {
                    StudentForm st = new StudentForm(txtusername.Text);
                    st.Show();
                }
            }

            else
                MessageBox.Show("Incorrect Username or Password");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
