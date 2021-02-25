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
using HotelModel;
using HotelBLL;

namespace HotelRegulator
{
    public partial class FrmMain : Form
    {
        private UserLoginManager userLoginManager = new UserLoginManager();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = userLoginManager.userLogin(txtAccount.Text,txtPassword.Text);
            string name = userLogin.UserName;
            if (userLogin != null)
            {
                FrmMenu menu = new FrmMenu();
                menu.Name = name;
                menu.RoomNumber = txtAccount.Text;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败，账号或密码错误!!");
            }
        }
    }
}
