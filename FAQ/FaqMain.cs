using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAQ
{
    public partial class Faq : Form
    {
        public Faq()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaq objFrm = new frmFaq();
            objFrm.ShowDialog();
        }

        private void searchFAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaqSearch objFrm = new frmFaqSearch();
            objFrm.ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
