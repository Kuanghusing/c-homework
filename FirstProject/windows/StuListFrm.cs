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

        private void StuListFrm_Load(object sender, EventArgs e)
        {
            //DBHelper.Open();
            SqlDataReader reader = null;
            reader = Util.getStuList();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(reader["StudentName"]));
                item.SubItems.Add(Convert.ToString(reader["StudentNo"]));
                item.SubItems.Add(Convert.ToString(reader["Gender"]));
                stuListView.Items.Add(item);
                
            }

            reader.Close();
            DBHelper.Close();
        }

        
    }
}
