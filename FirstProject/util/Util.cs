using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace FirstProject.util
{
    class Util
    {
        public static Boolean Login(String name, String pwd, String type)
        {

            Boolean result = false;
            int result_int = 0;
            string sqlStr = "";
            switch (type)
            {
                case "管理员":
                    sqlStr = "select count(*) from Admin where LoginId = '" + name 
                        + "' and LoginPwd = '" + pwd + "'";
                    break;
                case "学生":
                    sqlStr = "select count(*) from Student where StudentNo = '" 
                        + name + "' and LoginPwd = '" + pwd + "'";
                    break;
                case "教师":
                    sqlStr = "select count(*) from teacher where LoginId = '" 
                        + name + "' and LoginPwd = '" + pwd + "'";
                    break;
            }
            result_int = (int)DBHelper.ExecuteScalar(sqlStr);
            if(result_int>0)
            {
                result = true;
            }
            return result;
        }

        public static int StuSum()
        {
            int sum = 0;
            string sqlStr= "select count(*) from Student";
            sum = (int)DBHelper.ExecuteScalar(sqlStr);
            return sum;
        }

        public static DataSet getGrade(string tableName)
        {
            DataSet ds;
            string sqlStr = "select * from Grade";
            //reader = DBHelper.ExecuteReader(sqlStr);
            ds = DBHelper.dataSet(sqlStr, tableName);
            return ds;
        }
        private static DataSet ds;
        public static DataSet getStuList(string tableName)
        {
            
            string sqlStr= "select S.StudentNo,S.studentName,S.Gender,G.GradeName,S.Phone from student as s,grade as G where S.GradeId = G.GradeId";
            ds = DBHelper.dataSet(sqlStr,tableName);
            return ds;
        }

        private void dataView()
        {
            DataView dv = new DataView(ds.Tables[0]);

        }


        public static SqlDataReader searchStu(string type,string value)
        {
            SqlDataReader reader = null;
            string sqlStr = "";
            switch(type)
            { 
                case "StudentName":
                    sqlStr = "select * from Student where StudentName like '" + value + "%'";
                    break;
                case "StudnetNo":
                    sqlStr = "select * from Student where StudentNo = '" + value + "'";
                    break;
            }
            reader = DBHelper.ExecuteReader(sqlStr);
            return reader;
        }

        public static int AddSubject(string subjectName,string classHour,string gradeId)
        {
            string sqlStr = "insert into Subject values('" + subjectName + "','" 
                + classHour + "','" + gradeId + "')";
            return DBHelper.ExecuteNonQuery(sqlStr);
        }

        public static int deleteStu(string name)
        {
            string sqlStr = "delete from Student where StudentName = '" + name + "'";
            return  DBHelper.ExecuteNonQuery(sqlStr);

           
        }

        public static int addStu(string studentNo,string studentName,string pwd
            ,int gender,string birthday,string email,string phone,string address)
        {
            string sqlStr = "insert into Student(StudentName,LoginPwd,Gender,Birthday,Email,Phone,Address) values('" 
                +  studentName + "','" + pwd + "'," + gender + ",'" + birthday + "','" + email + "','" + phone  + "','" + address + "')";
            return DBHelper.ExecuteNonQuery(sqlStr);
        }

        public static int updateStu(string studentNo,string studentName,string pwd
            ,int gender,string birthday,string email,string phone)
        {
            StringBuilder sqlStr = new StringBuilder() ;
            sqlStr.Append("update Student set StudentName = '" + studentName + "'");
            sqlStr.Append(",LoginPwd = '" + pwd + "'");
            sqlStr.Append(",Gender = " + gender);
            sqlStr.Append(",Birthday = '" + birthday + "'");
            sqlStr.Append(",Email = '" + email + "'");
            sqlStr.Append(",Phone = '" + phone + "'");
            sqlStr.Append(" where StudentNo = " + studentNo);
            return DBHelper.ExecuteNonQuery(sqlStr.ToString());
        }

        public static DataSet SearchStuByGrade(string tableName,int gradeId)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("select * from Student ");
            if(gradeId != -1)
            {
                sqlStr.Append("where GradeId = " + gradeId);
            }
            
            return DBHelper.dataSet(sqlStr.ToString(), tableName);
        }

        public static DataSet getGradeWithDataSet(string tableName)
        {
            
            DataSet ds = new DataSet();
            string sqlStr = "select * from Grade";
            return DBHelper.dataSet(sqlStr, tableName);
        }


        public static DataSet getResultByStuNo(int stuNo,string tableName)
        {
            //DataSet ds = new DataSet();
            string sqlStr = "select S.StudentName,B.SubjectName,R.StudentResult,R.ExamDate"
                + " from Student as S, Result as R,Subject as B where "
                + "S.StudentNo = R.StudentNo and R.SubjectId = B.SubjectId and S.studentNo = " + stuNo;
            return DBHelper.dataSet(sqlStr, tableName);
        }


        public static DataSet getSubject(string tableName)
        {
            string sqlStr = "select * from Subject";
            return DBHelper.dataSet(sqlStr, tableName);
        }

        public static int addResult(int stuNo, int subject, int result, string examDate)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendFormat("insert into Result");
            sqlStr.AppendFormat(" values({0},{1},{2},'{3}')", stuNo, subject, result, examDate);
            return DBHelper.ExecuteNonQuery(sqlStr.ToString());
            
        }
    }
}
