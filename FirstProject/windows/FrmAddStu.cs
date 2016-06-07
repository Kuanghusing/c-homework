using FirstProject.util;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class FrmAddStu : Form
    {

        

        public FrmAddStu()
        {
            InitializeComponent();
        }

        private void FrmAddStu_Load(object sender, EventArgs e)
        {

            InitGrade();
            InitStuInfo();
        }


        private void InitGrade()
        {
            SqlDataReader reader = null;
            reader = Util.getGrade();
            while (reader.Read())
            {
                cbxGrade.Items.Add(reader[1]);
            }
            reader.Close();
            DBHelper.Close();
        }

        private void InitStuInfo()
        {
            if (studnetName != "")
            {
                loadData();
            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentNo = txtNo.Text.ToString();
            string studentName = txtName.Text.ToString();
            string loginPwd = txtPwd.Text.ToString();
            string phone = txtNum.Text.ToString();
            string address = txtAddress.Text.ToString();
            DateTime birthday = dtp.Value;

            string birthday_value = string.Format("{0}-{1}-{2}", birthday.Year, birthday.Month, birthday.Day);

            string email = txtEmail.Text.ToString();
            int gender = -1;
            if(rbtnMale.Checked == true)
            {
                gender = 1;
            }else if(rbrnFemale.Checked ==true)
            {
                gender = 0;
            }


            if(txtPwdCfm.Text == txtPwd.Text)
            { 
                int result = -1;
                if(studnetName == "")
                {
                    result = Util.addStu(studentNo, studentName, loginPwd, gender, birthday_value, email, phone, address);
                    if (result > 0)
                        MessageBox.Show("添加成功");
                    else
                        MessageBox.Show("添加失败");
                }
                else
                {
                    result = Util.updateStu(studentNo, studentName, loginPwd, gender, birthday_value, email,phone);
                    if (result > 0)
                        MessageBox.Show("更新成功");
                    else
                        MessageBox.Show("更新失败");
                }


                

            }
            else
            {
                MessageBox.Show("密码不一致");
            }    
              
        }

         private void loadData()
        {
            SqlDataReader reader = null;
            reader = Util.searchStu("StudentName", Convert.ToString(studnetName));
            if (reader.Read())
            {
                txtNo.Text = Convert.ToString(reader["StudentNo"]);
                txtName.Text = Convert.ToString(reader["StudentName"]);
                txtPwd.Text = Convert.ToString(reader["LoginPwd"]);
                txtPwdCfm.Text = txtPwd.Text;
                int genderInt = Convert.ToInt32(reader["Gender"]);
                dtp.Value = Convert.ToDateTime(reader["Birthday"]);
                txtEmail.Text = Convert.ToString(reader["Email"]);
                if (genderInt == 1)
                {
                    rbtnMale.Select();
                }
                else
                {
                    rbrnFemale.Select();
                }
            }
            reader.Close();
            DBHelper.Close();
        }

         /*private void insert()
         {
             string studentNo = txtNo.Text.ToString();
             string studentName = txtName.Text.ToString();
             string loginPwd = txtPwd.Text.ToString();
             string birthday = dtp.Value.ToString();
             //birthday = string.Format("{0}-{1}-{2}",birthday.)
             string email = txtEmail.Text.ToString();
             int gender = -1;
             if(rbtnMale.Checked == true)
             {
                 gender = 1;
             }else if(rbrnFemale.Checked ==true)
             {
                 MessageBox.Show("性别？");
             }
             if(txtPwdCfm.Text == txtPwd.Text)
             {
                 int result = Util.addStu(studentNo, studentName, loginPwd, gender, birthday, email);
                 if(result>0)
                 {
                     MessageBox.Show("添加成功");
                 }

             }
             else
             {
                 MessageBox.Show("插入错误");
             }
            


         }

         private void update()
         {
             string studentNo = txtNo.Text.ToString();
             string studentName = txtName.Text.ToString();
             string loginPwd = txtPwd.Text.ToString();
             string birthday = dtp.Value.ToString();
             //birthday = string.Format("{0}-{1}-{2}",birthday.)
             string email = txtEmail.Text.ToString();
             int gender = -1;
             if (rbtnMale.Checked == true)
             {
                 gender = 1;
             }
             else if (rbrnFemale.Checked == true)
             {
                 MessageBox.Show("性别？");
             }
         }*/


        private string studnetName = "";
        public string StudentNo
        {
            set
            {
                studnetName = value;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
