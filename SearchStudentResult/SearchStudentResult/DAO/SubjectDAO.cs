using SearchStudentResult.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStudentResult.DAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;

        public static SubjectDAO Instance
        {
            get { if (instance == null) instance = new SubjectDAO(); return SubjectDAO.instance; }
            private set { SubjectDAO.instance = value; }
        }


        private SubjectDAO() { }


        //===============================================================================================

        public List<Subject> LoadSubjectList()
        {
            List<Subject> subjectList = new List<Subject>();

            string query = @"SELECT * FROM MonHoc";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Subject subject = new Subject(item);
                subjectList.Add(subject);
            }

            return subjectList;
        }
        public string LoadSubjectNameByMaMH(string MaMH)
        {
            string query = @"SELECT TenMH FROM MonHoc WHERE MaMH = '" + MaMH + "'";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }



        //===================================================================================================

        public bool InsertSubject(string MaMH, string TenMH)
        {
            string query = string.Format("INSERT MonHoc (MaMH, TenMH) VALUES ('{0}', N'{1}')", MaMH, TenMH);
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSubject(string MaMH)
        {
            string query = @"DELETE FROM MonHoc WHERE MaMH = '" + MaMH + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateSubject(string MaMH, string TenMH)
        {
            string query = @"UPDATE MonHoc SET TenMH = N'" + TenMH + "' WHERE MaMH = '" + MaMH + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
