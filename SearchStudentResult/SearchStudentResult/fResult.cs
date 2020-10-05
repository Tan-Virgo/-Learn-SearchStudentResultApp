using SearchStudentResult.DAO;
using SearchStudentResult.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchStudentResult
{
    public partial class fResult : Form
    {
        public fResult()
        {
            InitializeComponent();
            LoadData();
        }
        

        void LoadData()
        {
            List<Result> list = ResultDAO.Instance.LoadResultList();
            dtgKetQua.DataSource = list;

            List<Student> listStudent = StudentDAO.Instance.LoadStudentList();
            cbMaSV.DataSource = listStudent;
            cbMaSV.DisplayMember = "_MaSV";
            lbHoTen.Text = listStudent[0]._HoTen;

            List<Subject> listSubject = SubjectDAO.Instance.LoadSubjectList();
            cbMaMH.DataSource = listSubject;
            cbMaMH.DisplayMember = "_MaMH";
            lbTenMH.Text = listSubject[0]._TenMH;
        }


        private void dtgKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dtgKetQua.Rows[e.RowIndex];

                cbMaSV.Text = row.Cells[0].Value.ToString();
                cbMaMH.Text = row.Cells[1].Value.ToString();
                nudDiem.Value = Convert.ToDecimal(row.Cells[2].Value);
                
            }
        }


        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = (cbMaSV.SelectedItem as Student)._MaSV;
            lbHoTen.Text = StudentDAO.Instance.LoadStudentNameByMaSV(txt);
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = (cbMaMH.SelectedItem as Subject)._MaMH;
            lbTenMH.Text = SubjectDAO.Instance.LoadSubjectNameByMaMH(txt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSV = cbMaSV.Text;
            string MaMH = cbMaMH.Text;
            double Diem = (double)nudDiem.Value;

            if (ResultDAO.Instance.InsertResult(MaSV, MaMH, Diem))
            {
                MessageBox.Show("Bạn vừa thêm thành công một Kết quả thi cho sinh viên!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm Kết quả mới!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSV = cbMaSV.Text;
            string MaMH = cbMaMH.Text;
            string TenSV = SubjectDAO.Instance.LoadSubjectNameByMaMH(MaSV);
            string TenMH = SubjectDAO.Instance.LoadSubjectNameByMaMH(MaMH);
            try
            {
                if (ResultDAO.Instance.DeleteResult(MaSV, MaMH))
                {
                    MessageBox.Show("Bạn vừa xóa thành công Kết quả thi môn " + TenMH + " của Sinh viên: " + TenSV, 
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa do không tồn tại kết quả thi môn " + TenMH + " của Sinh viên: " + TenSV
                         + " và thi môn: " + lbTenMH.Text, 
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("LỖI HỆ THỐNG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSV = cbMaSV.Text;
            string MaMH = cbMaMH.Text;
            double Diem = (double)nudDiem.Value;
            try
            {
                if (ResultDAO.Instance.UpdateResult(MaSV, MaMH, Diem))
                {
                    MessageBox.Show("Bạn vừa cập nhật thành công Điểm thi môn " +  lbTenMH.Text +
                        " của sinh viên: " + lbHoTen.Text,
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    if(MessageBox.Show("Không thể cập nhật do không tồn tại Kết quả thi môn " + lbTenMH.Text +
                        " của sinh viên: " + lbHoTen.Text + ". Bạn có muôn thêm mới Kết quả này không?",
                        "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnThem_Click(sender, e);
                    }
                }
            }
            catch
            {
                MessageBox.Show("LỖI HỆ THỐNG!",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
