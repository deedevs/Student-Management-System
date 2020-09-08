using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(string Username)
        {
            InitializeComponent();
            label4.Text = Username;
            panel2.Hide();
            panel3.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ON9NES4\\DEEZYSQL;Initial Catalog=UniDBS;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void txtid_Leave(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query = "select * from student where name = '" + label4.Text + "' and Password = '" + txtoldpassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.SelectCommand.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    panel2.Show();
                    panel3.Show();

                }
                else
                {
                    MessageBox.Show("You hav enetered a wrong Password");
                }
                txtoldpassword.Text = "";
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtnewpassword.Text;


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
            con.Open();
            string query = "update student set Password =  '" + password + "' where name = '" + label4.Text + "'; ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Password has been changed succesfully...!");
            this.Close();

            con.Close();
            
        }
    }
}
