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
    public partial class SearchStuByNameFrm : Form
    {
        public SearchStuByNameFrm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listStu.Clear();
            listStu.Columns.Add("姓名");
            listStu.Columns.Add("学号");
            listStu.Columns.Add("电话");
            listStu.Columns.Add("地址");
            search();
            
        }

        private void search()
        {
            listStu.Items.Clear();
            
            SqlDataReader reader = null;
            reader = Util.searchStu("StudentName", txtSearchName.Text);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(reader["StudentName"]));
                item.SubItems.Add(Convert.ToString(reader["StudentNo"]));
                item.SubItems.Add(Convert.ToString(reader["Phone"]));
                item.SubItems.Add(Convert.ToString(reader["Address"]));
                // item.SubItems.Add(Convert.ToString(reader["Birthday"]));
                listStu.Items.Add(item);
            }
            reader.Close();
            DBHelper.Close();
        }

        private void SearchStuByNameFrm_Load(object sender, EventArgs e)
        {

        }

        private void tsmiEditStu_Click(object sender, EventArgs e)
        {

            FrmAddStu frmAddStu = new FrmAddStu();
            frmAddStu.StudentNo = Convert.ToString(listStu.SelectedItems[0].Text.ToString());
            frmAddStu.MdiParent = this.MdiParent;
            frmAddStu.Show();
        }

        private void tsmiDeleteStu_Click(object sender, EventArgs e)
        {
            //object test = listStu.SelectedItems;
            if (listStu.Items.Count > 0)
            {
                string name = listStu.SelectedItems[0].Text.ToString();
                int result = Util.deleteStu(name);
                if (result > 0)
                {
                    MessageBox.Show("删除成功");
                    search();
                }
                else
                {
                    MessageBox.Show("删除失败");

                }
            }
            else
                MessageBox.Show("先选择一个学生再删除……");
        }
    }
}
