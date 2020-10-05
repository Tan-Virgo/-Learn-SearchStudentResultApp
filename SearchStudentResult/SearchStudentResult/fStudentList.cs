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
    public partial class fStudentList : Form
    {
        public fStudentList()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            List<Student> list = StudentDAO.Instance.LoadStudentList();
            dtgSinhVien.DataSource = list;

            DataGridViewRow row1 = this.dtgSinhVien.Rows[0];

            txtMaSV.Text = row1.Cells[0].Value.ToString();
            txtHoTen.Text = row1.Cells[1].Value.ToString();
            dtpNgaySinh.Text = row1.Cells[2].Value.ToString();
            cbGioiTinh.Text = row1.Cells[3].Value.ToString();
        }

        private void dtgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                cbGioiTinh.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string HoTen = txtHoTen.Text;
            string Ngay = dtpNgaySinh.Value.Day.ToString();
            string Thang = dtpNgaySinh.Value.Month.ToString();
            string Nam = dtpNgaySinh.Value.Year.ToString();
            string NgaySinh = Thang + "/" + Ngay + "/" + Nam;

            string GioiTinh = cbGioiTinh.Text;

            if (StudentDAO.Instance.InsertStudent(MaSV, HoTen, NgaySinh, GioiTinh))
            {
                MessageBox.Show("Bạn vừa thêm thành công một Sinh viên mới!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm Sinh viên mới!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = StudentDAO.Instance.LoadStudentNameByMaSV(MaSV);
            try
            {
                if (StudentDAO.Instance.DeleteStudent(MaSV))
                {
                    MessageBox.Show("Bạn vừa xóa thành công Sinh viên: " + TenSV, 
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa do không tồn tại Sinh viên: " + TenSV, 
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Không thể xóa do có tồn tại kết quả thi của Sinh viên: " 
                    + TenSV + ". Nếu muốn xóa Sinh viên này, hãy xóa các kết quả thi của Sinh viên trước!", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = txtHoTen.Text;
            string NgaySinh = dtpNgaySinh.Value.ToString();
            string GioiTinh = cbGioiTinh.Text;
            try
            {
                if (StudentDAO.Instance.UpdateStudent(MaSV, TenSV, NgaySinh, GioiTinh))
                {
                    MessageBox.Show("Bạn vừa cập nhật thành công Sinh viên có mã: " + MaSV,
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    if (MessageBox.Show("Không thể cập nhật do không tồn tại Sinh viên có mã: " + MaSV +". Bạn có muốn thêm mới sinh viên này không?",
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
