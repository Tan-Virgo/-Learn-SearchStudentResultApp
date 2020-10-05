using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStudentResult.DTO
{
    public class Result
    {
        public Result(string MaSV, string MaMH, float Diem)
        {
            this.MaSV = MaSV;
            this.MaMH = MaMH;
            this.Diem = Diem;
        }

        public Result(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.MaMH = row["MaMH"].ToString();
            this.Diem = (double)row["Diem"];
        }

        private string MaSV;
        public string _MaSV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }

        private string MaMH;
        public string _MaMH
        {
            get { return MaMH; }
            set { MaMH = value; }
        }

        private double Diem;
        public double _Diem
        {
            get { return Diem; }
            set { Diem = value; }
        }
        
    }
}
