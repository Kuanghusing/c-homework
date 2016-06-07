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
    public partial class FrmSearchStuByGrade : Form
    {
        public FrmSearchStuByGrade()
        {
            InitializeComponent();
        }

        private void FrmSearchStuByGrade_Load(object sender, EventArgs e)
        {
            BindGrade();
        }

        private void BindGrade()
        {
            string tableName = "Grade";
            DataSet ds = Util.getGradeWithDataSet(tableName);
            
            DataRow row = ds.Tables[tableName].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables[tableName].Rows.InsertAt(row, 0);
            this.cmbGrade.DataSource = ds.Tables[tableName];
            this.cmbGrade.DisplayMember = "GradeName";
            this.cmbGrade.ValueMember = "GradeId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tableName = "Studnet";
            int gradeId = -1;
            gradeId = Convert.ToInt32(cmbGrade.SelectedValue);
            
            DataSet ds = Util.SearchStuByGrade(tableName,gradeId);
            
            dgvStuList.DataSource = ds.Tables[tableName];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBHelper.updateData("Student");
            MessageBox.Show("更新成功");

        }

        private void tsmiAddScore_Click(object sender, EventArgs e)
        {
            int stuScore = Convert.ToInt32(dgvStuList.SelectedCells[0].Value);
            FrmAddResult f = new FrmAddResult();
            f.stuNo = stuScore;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

    }
}
