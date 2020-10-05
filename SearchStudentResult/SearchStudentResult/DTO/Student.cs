using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStudentResult.DTO
{
    public class Student
    {
        
        public Student(string MaSV, string HoTen, DateTime? NgaySinh, string GioiTinh)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
        }

        public Student(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        private string MaSV;
        public string _MaSV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }

        private string HoTen;
        public string _HoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }

        private DateTime? NgaySinh;
        public DateTime? _NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        private string GioiTinh;
        public string _GioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }


    }
}
