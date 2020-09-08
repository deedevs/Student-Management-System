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
    public partial class NewStudentcs : Form
    {
        
        public NewStudentcs()
        {
            InitializeComponent();

            Fillcombo();
            ReadOnlyID();
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
            con.Open();

            txtrole.Text = "Student";
            String query = "INSERT INTO student (ID, name , dept_name,tot_cred, Password, Role  ) VALUES ('" + txtid.Text + "','" + txtname.Text + "','" + deptnameComboBox.Text + "','" + txtcredits.Text + "','" + password + "','" + txtrole.Text + "') ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txtname.Text = "";
            deptnameComboBox.Items.Clear();
            txtcredits.Text = "";
            txtpassword.Text = "";
            
            MessageBox.Show("INSERTED SUCCESSFULY");
            
            
            
            
        }


        void ReadOnlyID()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(ID),17888)+1 from student", con);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            txtid.Text = ds.Rows[0][0].ToString();
            txtpassword.Text = ds.Rows[0][0].ToString();
        }

    }
}
