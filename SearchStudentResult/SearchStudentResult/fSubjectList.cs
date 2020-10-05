using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchStudentResult.DAO;
using SearchStudentResult.DTO;

namespace SearchStudentResult
{
    public partial class fSubjectList : Form
    {
        public fSubjectList()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            List<Subject> list = SubjectDAO.Instance.LoadSubjectList();
            dtgMonHoc.DataSource = list;

            DataGridViewRow row1 = this.dtgMonHoc.Rows[0];
            txtMaMH.Text = row1.Cells[0].Value.ToString();
            txtTenMH.Text = row1.Cells[1].Value.ToString();
        }

        private void dtgMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgMonHoc.Rows[e.RowIndex];

                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string TenMH = txtTenMH.Text;

            if (SubjectDAO.Instance.InsertSubject(MaMH, TenMH))
            {
                MessageBox.Show("Bạn vừa thêm thành công một Môn học mới!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {
                MessageBox.Show("Lỗi khi thêm Môn học mới!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string TenMH = SubjectDAO.Instance.LoadSubjectNameByMaMH(MaMH);

            try
            {
                if (SubjectDAO.Instance.DeleteSubject(MaMH))
                {
                    MessageBox.Show("Bạn vừa xóa thành công Môn: " + TenMH, 
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa do không tồn tại Môn: " + TenMH, 
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa do có Sinh viên học Môn: " + TenMH + " này!", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string TenMH = txtTenMH.Text;
            try
            {
                if (SubjectDAO.Instance.UpdateSubject(MaMH, TenMH))
                {
                    MessageBox.Show("Bạn vừa cập nhật thành công Môn học có mã: " + MaMH,
                        "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    if (MessageBox.Show("Không thể cập nhật do không tồn tại Môn học có mã: " + MaMH + ". Bạn có muốn thêm mới Môn học này không?",
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
