using SearchStudentResult.DAO;
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
    public partial class fStatic : Form
    {
        public fStatic()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {
            txtGioi.Text = ResultDAO.Instance.GIOI();
            txtKha.Text = ResultDAO.Instance.KHA();
            txtTB.Text = ResultDAO.Instance.TB();
            txtYeu.Text = ResultDAO.Instance.YEU();
            _txtGioi.Text = ResultDAO.Instance.T_GIOI();
            _txtKha.Text = ResultDAO.Instance.T_KHA();
            _txtTB.Text = ResultDAO.Instance.T_TB();
            _txtYeu.Text = ResultDAO.Instance.T_YEU();
        }
    }
}
