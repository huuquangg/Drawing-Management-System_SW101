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
    public partial class Login : Form
    {
        //lệnh sử dụng database
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        //lệnh kết nối database
        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Articles\Code\RegistrationAndLogin\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != string.Empty || txtUserName.Text != string.Empty)
            {

               // cmd = new SqlCommand("select * from LoginTable where username='" + txtUserName.Text + "' and password='" + txtPass.Text + "'", cn);
               // dr = cmd.ExecuteReader();
               // if (dr.Read())//check is user exist
               // {
                   // dr.Close();
                    this.Hide();
                    HomeScreen homeScreen = new HomeScreen();
                    homeScreen.ShowDialog();
              //  }
                //{
                    //dr.Close();
                   // MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
