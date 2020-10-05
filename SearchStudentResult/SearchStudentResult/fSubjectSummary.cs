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
    public partial class fSubjectSummary : Form
    {
        public fSubjectSummary()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            List<Subject> list = SubjectDAO.Instance.LoadSubjectList();
            cbTim.DataSource = list;
            cbTim.DisplayMember = "_TenMH";
        }

        private void cbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string passed = ResultDAO.Instance.PassedNum(cbTim.SelectedItem as Subject);
            string unpassed = ResultDAO.Instance.UnPassedNum(cbTim.SelectedItem as Subject);
            string percentpassed = ResultDAO.Instance.PercentNum(cbTim.SelectedItem as Subject);
            string AVG = ResultDAO.Instance.AVG_Diem(cbTim.SelectedItem as Subject);

            txtDau.Text = passed;
            txtTruot.Text = unpassed;
            txtDiem.Text = AVG;
            txtTiLe.Text = percentpassed;
        }
    }
}
