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
    public partial class frmFaqSearch : Form
    {
        public frmFaqSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ccbModule.Text) == true)
            {
                moduleReq.SetError(ccbModule, "Please Select Module");
            }

            if (string.IsNullOrEmpty(ccbRole.Text) == true)
            {
                roleReq.SetError(ccbRole, "Please Select User Role");
            }

            if (string.IsNullOrEmpty(txtPrblmStmt.Text) == true)
            {
                problmStmtReq.SetError(txtPrblmStmt, "Please Enter Problem Statement");
            }
        }
    }
}
