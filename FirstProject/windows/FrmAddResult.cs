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
using System.Data.SqlClient;

namespace FirstProject
{
    public partial class FrmAddResult : Form
    {
        public FrmAddResult()
        {
            InitializeComponent();
        }

        public int stuNo = -1;
        private string tableName = "Result";
        private void FrmAddResult_Load(object sender, EventArgs e)
        {
            bindResult();
            bindSubject();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int subject = Convert.ToInt32(cmbSubject.SelectedValue);
            int result = Convert.ToInt32(txtResult.Text.ToString());
            DateTime date = dtpExamDate.Value;
            string datetime = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);

            if(Util.addResult(stuNo, subject, result, datetime) > 0)
            {
                MessageBox.Show("add successfully");
            }
            else
            {
                MessageBox.Show("error");
            }
            bindResult();
            //DBHelper.updateData(tableName);
        }

        private void bindResult()
        {
            DataSet ds = new DataSet();

            if (stuNo != -1)
            {
                ds = Util.getResultByStuNo(stuNo, tableName);
            }

            dgvResult.DataSource = ds.Tables[0];
        }

        
        

        private void bindSubject()
        {
            string tableName = "Subject";
            DataSet ds = new DataSet();
            ds = Util.getSubject(tableName);

            DataRow row = ds.Tables[tableName].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables[tableName].Rows.InsertAt(row, 0);
            cmbSubject.DataSource = ds.Tables[tableName];

            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
        }
    }
}
