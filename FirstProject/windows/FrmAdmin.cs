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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
        }
        /*private void FrmAdmin_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
                this.BackColor = Color.Yellow;
            else if (this.BackColor == Color.Yellow)
                this.BackColor = Color.Green;
            else if (this.BackColor == Color.Green)
                this.BackColor = Color.Red;

        }*/

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            FrmAddStu frmAddStu = new FrmAddStu();
            frmAddStu.Show();
            this.Hide();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsNewStu_Click(object sender, EventArgs e)
        {
            FrmAddStu frmAddStu = new FrmAddStu();
            frmAddStu.MdiParent = this;
            frmAddStu.Show();
        }

        private void tsmiStuSum_Click(object sender, EventArgs e)
        {
            int sum = Util.StuSum();
            MessageBox.Show("一共有" + sum + "个学生");
        }

        private void tsStuList_Click(object sender, EventArgs e)
        {
            StuListFrm stuListFrm = new StuListFrm();
            stuListFrm.MdiParent = this;
            stuListFrm.Show();
        }

        private void tsSearchStuByName_Click(object sender, EventArgs e)
        {
            SearchStuByNameFrm sfm = new SearchStuByNameFrm();
            sfm.MdiParent = this;
            sfm.Show();
        }

        private void 新增科目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSubject f = new FrmAddSubject();
            f.MdiParent = this;
            f.Show();
        }

        private void tsmiSearchStuByGrade_Click(object sender, EventArgs e)
        {
            FrmSearchStuByGrade f = new FrmSearchStuByGrade();
            f.MdiParent = this;
            f.Show();
        }


    }
}
