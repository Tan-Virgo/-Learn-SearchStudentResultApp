using SearchStudentResult.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchStudentResult.DAO
{
    public class ResultDAO
    {
        private static ResultDAO instance;

        public static ResultDAO Instance
        {
            get { if (instance == null) instance = new ResultDAO(); return ResultDAO.instance; }
            private set { ResultDAO.instance = value; }
        }

        private ResultDAO() { }


        //======================================================================================================

        public List<Result> LoadResultList()
        {
            List<Result> resultList = new List<Result>();

            string query = @"SELECT * FROM KetQua";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Result result = new Result(item);
                resultList.Add(result);
            }

            return resultList;
        }


        //======================================================================================================

        public bool InsertResult(string MaSV, string MaMH, double Diem)
        {
            string query = string.Format("INSERT KetQua (MaSV, MaMH, Diem) VALUES ('{0}', '{1}', {2})", MaSV, MaMH, Diem);
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }



        public bool DeleteResult(string MaSV, string MaMH)
        {
            string query = @"DELETE FROM KetQUa WHERE MaSV = '" + MaSV + "' AND MaMH = '" + MaMH + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateResult(string MaSV, string MaMH, double Diem)
        {
            string query = @"UPDATE KetQua SET Diem = " + Diem
                                           + " WHERE MaSV = '" + MaSV + "' AND MaMH = '" + MaMH + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //========================================================================================================

        public List<Result> PassedSubject(string MaSV)
        {
            List<Result> list = new List<Result>();

            string query = @"SELECT * FROM KetQua WHERE MaSV = '" + MaSV + "' AND Diem >= 5";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Result result = new Result(item);
                list.Add(result);
            }

            return list;
        }

        public List<Result> UnPassedSubject(string MaSV)
        {
            List<Result> list = new List<Result>();

            string query = @"SELECT * FROM KetQua WHERE MaSV = '" + MaSV + "' AND Diem < 5";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Result result = new Result(item);
                list.Add(result);
            }

            return list;
        }



        //==============================================================================================

        public string PassedNum(Subject MH)
        {
            string MaMH = MH._MaMH;
            string query = @"EXEC P " + MaMH ;

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string UnPassedNum(Subject MH)
        {
            string MaMH = MH._MaMH;
            string query = @"EXEC UP " + MaMH;

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string PercentNum(Subject MH)
        {
            string MaMH = MH._MaMH;
            string query = @"EXEC Per " + MaMH;

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string AVG_Diem(Subject MH)
        {
            string MaMH = MH._MaMH;
            string query = @"EXEC Avg_ " + MaMH;

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }





        //==============================================================================================

        public string GIOI()
        {

            string query = @"EXEC N_GIOI";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string KHA()
        {

            string query = @"EXEC N_KHA";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string TB()
        {

            string query = @"EXEC N_TB";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string YEU()
        {

            string query = @"EXEC N_YEU";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }





        public string T_GIOI()
        {

            string query = @"EXEC T_GIOI";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string T_KHA()
        {

            string query = @"EXEC T_KHA";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string T_TB()
        {

            string query = @"EXEC T_TB";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public string T_YEU()
        {

            string query = @"EXEC T_YEU";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }
    }
}

