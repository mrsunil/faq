using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FAQ
{
    public partial class frmFaq : Form
    {
        public frmFaq()
        {
            InitializeComponent();
            LoadDropDownWithValues();
            saveMsg.Visible = false;
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


            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=MedicaidFAQ;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("InsertSolutionInformation_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MODULE_ID",ccbModule.SelectedValue);
            cmd.Parameters.AddWithValue("USERROLE_ID",ccbUserRole.SelectedValue);
            cmd.Parameters.AddWithValue("ENVIRONMENT_ID",ccbEnv.SelectedValue);
            cmd.Parameters.AddWithValue("PROBLEMTYPE_ID",ccbProblmType.SelectedValue);
            cmd.Parameters.AddWithValue("PROBLEM_STATEMENT",txtprblmStmt.Text);
            cmd.Parameters.AddWithValue("SOLUTION_DESC",txtSol.Text);
            con.Open();
            int k = cmd.ExecuteNonQuery();
            if(k!=0)
            {
                saveMsg.Visible = true;
                saveMsg.Text = "Record Inserted Succesfully into the Database";
                txtprblmStmt.Clear();
                txtSol.Clear();
            }
            con.Close();
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
            txtprblmStmt.Clear();
            txtSol.Clear();
            saveMsg.Visible = false;
        }

        private void LoadDropDownWithValues()

        {

            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=MedicaidFAQ;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                using (SqlDataAdapter da = new SqlDataAdapter("GetModuleInformation_SP", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ccbModule.DisplayMember = "MODULE_NAME";
                    ccbModule.ValueMember = "MODULE_ID";

                    ccbModule.DataSource = dt;

                }


                using (SqlDataAdapter da1 = new SqlDataAdapter("GetUserInformation_SP", connection))

                {
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    ccbUserRole.DisplayMember = "USERROLE_NAME";
                    ccbUserRole.ValueMember = "USERROLE_ID";
                    ccbUserRole.DataSource = dt1;

                }


                using (SqlDataAdapter da2 = new SqlDataAdapter("GetEnvironmentInformation_SP", connection))

                {

                    DataTable dt2 = new DataTable();

                    da2.Fill(dt2);

                    ccbEnv.DisplayMember = "ENVIRONMENT_NAME";
                    ccbEnv.ValueMember = "ENVIRONMENT_ID";
                    ccbEnv.DataSource = dt2;

                }


                using (SqlDataAdapter da3 = new SqlDataAdapter("GetProblemTypeInformation_SP", connection))

                {

                    DataTable dt3 = new DataTable();

                    da3.Fill(dt3);

                    ccbProblmType.DisplayMember = "PROBLEMTYPE_NAME";
                    ccbProblmType.ValueMember = "PROBLEMTYPE_ID";
                    ccbProblmType.DataSource = dt3;

                }
                connection.Close();
            }

        }
    }
}
