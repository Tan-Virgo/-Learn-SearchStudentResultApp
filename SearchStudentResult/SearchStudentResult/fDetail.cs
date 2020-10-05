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
    public partial class fDetail : Form
    {
        public fDetail()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStudentList f = new fStudentList();
            f.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSubjectList f = new fSubjectList();
            f.ShowDialog();
        }

        private void kếtQuảTheoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSubjectSummary f = new fSubjectSummary();
            f.ShowDialog();
        }

        private void xếpLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStatic f = new fStatic();
            f.ShowDialog();
        }

        private void linkKhoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void fDetail_Load(object sender, EventArgs e)
        {
            linkKhoa.Links.Add(0, linkKhoa.Text.Length,"www.fit.hcmus.edu.vn");
            linkTruong.Links.Add(0, linkTruong.Text.Length, "www.hcmus.edu.vn");
        }

        private void linkTruong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void fDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fResult f = new fResult();
            f.ShowDialog();
        }








        private void btnTim_Click(object sender, EventArgs e)
        {
            string MaSV = txtTimSV.Text;
            List<Student> list = StudentDAO.Instance.FindStudentByMaSV(MaSV);

            if (list.Count == 0)
            {
                MessageBox.Show("Không có Sinh viên có mã số là " + MaSV + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimSV.Text = "";
            }
            else
            {
                txtMaSV.Text = list[0]._MaSV;
                txtHoTen.Text = list[0]._HoTen;
                dtpNgaySinh.Text = list[0]._NgaySinh.ToString();
                cbGioiTinh.Text = list[0]._GioiTinh;
                Passed();
                UnPassed();
            }
        }

        void Passed()
        {
            string MaSV = txtMaSV.Text;
            List<Result> list = ResultDAO.Instance.PassedSubject(MaSV);
            dtgPassed.DataSource = list;
        }

        void UnPassed()
        {
            string MaSV = txtMaSV.Text;
            List<Result> list = ResultDAO.Instance.UnPassedSubject(MaSV);
            dtgUnpassed.DataSource = list;
        }


    }
}
