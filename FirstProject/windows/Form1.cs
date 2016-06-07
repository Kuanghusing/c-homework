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
using FirstProject.util;

namespace FirstProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBHelper.Open();

            string name = txbUserName.Text.Trim();
            string pwd = txbPwd.Text.Trim();
            string type = cmbType.Text;

            if (name == "")
                MessageBox.Show("用户名为空");
            else if (pwd == "")
                MessageBox.Show("密码为空");
            else if (type == "")
                MessageBox.Show("用户类型为空");

            else if (Util.Login(name,pwd,type))
            {
                FrmAdmin f = new FrmAdmin();
                f.Show();
            }else
            {
                MessageBox.Show("用户名或密码不正确");
            }
            

            



        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消？", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                DBHelper.Close();
                this.Close();
        }

        
    }
}
