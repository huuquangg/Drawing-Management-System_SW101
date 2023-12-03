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

namespace test_project
{
    public partial class SignBtn : Form
    {
        //lệnh sử dụng database
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public SignBtn()
        {
            InitializeComponent();
        }

        //lệnh kết nối database
        private void SignUp_load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Articles\Code\RegistrationAndLogin\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != string.Empty || txtPassConfirm.Text != string.Empty)//check if is it blank
            { 
                //not blank
                if(txtPass.Text == txtPassConfirm.Text)//if enter the same password in form
                {
                   // cmd = new SqlCommand("select * from LoginTable where username='" + txtUserName.Text + "'", cn);
                   // dr = cmd.ExecuteReader();
                    //if (dr.Read())//check if username already exist
                    //{
                    //    dr.Close();
                    //    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                   // else
                   // {
                        //dr.Close();
                        //cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        //cmd.Parameters.AddWithValue("username", txtUserName.Text);
                        //cmd.Parameters.AddWithValue("password", txtPass.Text);
                        //cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //sau khi dang ky thanh cong chuyen sang trang log in
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    //  }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
