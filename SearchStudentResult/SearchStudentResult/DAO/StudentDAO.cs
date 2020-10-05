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
    public class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return StudentDAO.instance; }
            private set { StudentDAO.instance = value; }
        }

        private StudentDAO() { }


        //-===================================================================================================

        public List<Student> LoadStudentList()
        {
            List<Student> studentList = new List<Student>();

            string query = @"SELECT * FROM SinhVien";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Student student = new Student(item);
                studentList.Add(student);
            }

            return studentList;
        }

        public string LoadStudentNameByMaSV(string MaSV)
        {
            string query = @"SELECT HoTen FROM SinhVien WHERE MaSV = '" + MaSV + "'";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            return data.Rows[0][0].ToString();
        }

        public Student LoadStudentByMaSV(string MaSV)
        {
            string query = @"SELECT * FROM SinhVien WHERE MaSV = '" + MaSV + "'";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            Student student = new Student(data.Rows[0]);

            return student;
        }

        //======================================================================================================

        public bool InsertStudent(string MaSV, string HoTen, string NgaySinh, string GioiTinh)
        {
            string query = string.Format("INSERT SinhVien (MaSV, HoTen, NgaySinh, GioiTinh) VALUES ('{0}', N'{1}', '{2}', N'{3}')", MaSV, HoTen, NgaySinh, GioiTinh);
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteStudent(string MaSV)
        {
            string query = @"DELETE FROM SinhVien WHERE MaSV = '" + MaSV + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateStudent(string MaSV, string HoTen, string NgaySinh, string GioiTinh)
        {
            string query = @"UPDATE SinhVien SET HoTen = N'" + HoTen 
                                            + "', NgaySinh = '" + NgaySinh 
                                            + "', GioiTinh = '" + GioiTinh + "' WHERE MaSV = '" + MaSV + "'";
            int result = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Student> FindStudentByMaSV(string MaSV)
        {
            List<Student> list = new List<Student>();

            string query = @"SELECT * FROM SinhVien WHERE MaSV = '" + MaSV + "'";

            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Student student = new Student(item);
                list.Add(student);
            }

            return list;
        }
    }
}
