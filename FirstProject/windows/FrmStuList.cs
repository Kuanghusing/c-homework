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
    public partial class StuListFrm : Form
    {
        public StuListFrm()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void StuListFrm_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            string tableName = "Student";
            
            ds = Util.getStuList(tableName);
            dgvDetail.DataSource = ds.Tables[tableName];


            DBHelper.Close();

            
        }

        private void tvKind_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataView dv;
            dv = new DataView(ds.Tables[0]); 
            string rowFilter = string.Empty;
            int level = this.tvKind.SelectedNode.Level;
            string selectedText = this.tvKind.SelectedNode.Text.ToString();
            //string selectedTagText = this.tvKind.SelectedNode.Tag.ToString();
            if(level == 1)
            {
                rowFilter = "GradeName = '" + selectedText + "'";

            }
            else if (level == 2)
            {
                string text = this.tvKind.SelectedNode.Parent.Text.ToString();
                if (this.tvKind.SelectedNode.Tag.ToString() == "male")
                    rowFilter = "GradeName = '" + text + "' and Gender = " + 1;
                else
                    rowFilter = "GradeName = '" + text + "' and Gender = " + 0;
            }
                dv.RowFilter = rowFilter;
                dgvDetail.DataSource = dv;

        }

        
    }
}
