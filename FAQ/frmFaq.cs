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
    public partial class frmFaq : Form
    {
        public frmFaq()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ccbModule.Text) == true)
            {
                moduleReq.SetError(ccbModule, "Please Select Module");
            }

            if (string.IsNullOrEmpty(ccbUserRole.Text) == true)
            {
                userRoleReq.SetError(ccbUserRole, "Please Select User Role");
            }

            if (string.IsNullOrEmpty(txtprblmStmt.Text) == true)
            {
                prblmStmtReq.SetError(txtprblmStmt, "Please Enter Problem Statement");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ccbModule.Text) == true)
            {
                moduleReq.SetError(ccbModule, "Please Select Module");
            }

            if (string.IsNullOrEmpty(ccbUserRole.Text) == true)
            {
                userRoleReq.SetError(ccbUserRole, "Please Select User Role");
            }

            if (string.IsNullOrEmpty(txtprblmStmt.Text) == true)
            {
                prblmStmtReq.SetError(txtprblmStmt, "Please Enter Problem Statement");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            moduleReq.Clear();
            userRoleReq.Clear();
            prblmStmtReq.Clear();

        }
    }
}
