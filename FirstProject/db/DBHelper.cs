using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FirstProject
{
    class DBHelper
    {
        private static SqlConnection sqlcn;
        private static string connectionString = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        public static void Open()
        {
            
                try
                {

                    if (sqlcn == null)
                        {
                            
                                sqlcn = new SqlConnection(connectionString);
                                
                                //MessageBox.Show("Sql Server Connect Successfully!");

                            
                        }

                if (sqlcn.State == ConnectionState.Closed)
                                    sqlcn.Open();
                                if (sqlcn.State == ConnectionState.Broken)
                                {
                                    sqlcn.Close();
                                    sqlcn.Open();

                                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connect Error~");
                }
                
            
        }

        public static void Close()
        {

            if (sqlcn != null)
            {
                if (sqlcn.State == ConnectionState.Open || sqlcn.State == ConnectionState.Broken)
                {
                    sqlcn.Close();
                } 
            }
        }

        public static object ExecuteScalar(String commStr)
        {
            Open();
            
            Object returnObj = null;
            try
            {
                
                SqlCommand sqlcomm = null;

                if (sqlcn != null)
                {
                    sqlcomm = new SqlCommand(commStr, sqlcn);
                    returnObj = sqlcomm.ExecuteScalar();
                }
            }
            catch(Exception)
            {
                
            }
            finally
            {
                Close();
            }
            
            
            return returnObj;
        }

        public static SqlDataReader ExecuteReader(string commstr)
        {
            Open();
            
            SqlDataReader reader = null;
            SqlCommand sqlcomm = null;
            try
            {
                sqlcomm = new SqlCommand(commstr,sqlcn);
                reader = sqlcomm.ExecuteReader();
            }catch(Exception)
            {
                MessageBox.Show("it seems someing problem");
            }
            
            return reader;

        }

        public static int ExecuteNonQuery(string sqlStr)
        {
            Open();
            int rows = 0;
            SqlCommand sqlcm;
            try{
                sqlcm = new SqlCommand(sqlStr,sqlcn);
                rows = sqlcm.ExecuteNonQuery();

            }catch (Exception)
            { }
            finally
            {
                Close();
            }
            
            return rows;
        }

        private static DataSet ds;
        private static SqlDataAdapter adapter;
        public static DataSet dataSet(string sqlStr,string tableName)
        {
            Open();
            ds = new DataSet();
            adapter = new SqlDataAdapter();
            SqlCommand sqlcm = new SqlCommand(sqlStr, sqlcn);
            adapter.SelectCommand = sqlcm;
            adapter.Fill(ds, tableName);
            Close();
            return ds;

        }

        public static void updateData(string tableName)
        {
            DBHelper.Open();
            if(ds != null && adapter != null)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds,tableName);
            }
        }
        
    }
}
