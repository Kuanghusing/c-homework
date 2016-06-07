using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstProject.util;

namespace FirstProject
{
    public partial class FrmAddSubject : Form
    {
        public FrmAddSubject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sujectName = txtSubName.Text.ToString();
            string classHour = txtClassHour.Text.ToString();
            string gradeId = txtGradeId.Text.ToString();
            int result  = Util.AddSubject(sujectName, classHour, gradeId);
            if(result > 0)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
