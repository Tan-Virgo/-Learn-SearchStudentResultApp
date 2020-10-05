using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStudentResult.DTO
{
    public class Subject
    {
        public Subject(string MaMH, string TenMH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
        }

        public Subject(DataRow row)
        {
            this.MaMH = row["MaMH"].ToString();
            this.TenMH = row["TenMH"].ToString();
        }

        private string MaMH;
        public string _MaMH
        {
            get { return MaMH; }
            set { MaMH = value; }
        }

        private string TenMH;
        public string _TenMH
        {
            get { return TenMH; }
            set { TenMH = value; }
        }
    }
}
