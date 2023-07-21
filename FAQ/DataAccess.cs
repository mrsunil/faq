using System;

using System.Data;

using System.Windows.Forms;

using System.Data.OleDb;



namespace FAQ

{

    public partial class DataAccess

    {

        string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\sn37\\OneDrive - Gainwell Technologies\\Documents\\ProblemSolving.accdb";

        OleDbConnection con;

        OleDbDataReader dr;



        public DataAccess()

        {

            ///InitializeComponent();

        }



        ////private void Read_Click(object sender, EventArgs e)

        ////{   

        ////    string query = "Select * from Problem";  ////"SP_ReadProblem"

        ////    using (con = new OleDbConnection(connectionString))

        ////    {

        ////        OleDbCommand cmd = con.CreateCommand();

        ////        con.Open();

        ////        DataSet ds = new DataSet();

        ////        using (cmd = new OleDbCommand(query, con))

        ////        {

        ////            cmd.CommandType = CommandType.Text;  ////cmd.CommandType = CommandType.StoredProcedure;

        ////            using (dr = cmd.ExecuteReader())

        ////            {

        ////                if (dr.Read())

        ////                {

        ////                    txtDepartment.Text = dr["Department"].ToString();

        ////                    txtModule.Text = dr["Module"].ToString();

        ////                    txtEnvironment.Text = dr["Environment"].ToString();

        ////                    txtProblemType.Text = dr["ProblemType"].ToString();

        ////                    txtProblem.Text = dr["Problem"].ToString();

        ////                }

        ////            }

        ////        }

        ////        dr.Close();

        ////        con.Close();

        ////    }



        ////    DataStatus.Text = "";

        ////}



        private void Read_Click(object sender, EventArgs e)

        {

            string query = "Select * from Problem";  ////"SP_ReadProblem"

            con = new OleDbConnection(connectionString);

            OleDbDataAdapter da = new OleDbDataAdapter(query, con);

            con.Open();

            DataSet ds = new DataSet();

            da.Fill(ds, "Problem");

            ////txtDepartment.Text = ds.Tables["Problem"].Rows[0]["Department"].ToString();

            ////txtModule.Text = ds.Tables["Problem"].Rows[0]["Module"].ToString();

            ////txtEnvironment.Text = ds.Tables["Problem"].Rows[0]["Environment"].ToString();

            ////txtProblemType.Text = ds.Tables["Problem"].Rows[0]["ProblemType"].ToString();

            ////txtProblem.Text = ds.Tables["Problem"].Rows[0]["Problem"].ToString();



            ////con.Close();

            ////DataStatus.Text = "";

        }



        private void Save_Click(object sender, EventArgs e)

        {

            ////DataStatus.Text = "";

            con = new OleDbConnection(connectionString);

            OleDbCommand selectcmd = new OleDbCommand("Select max(ID) from Problem", con);

            selectcmd.CommandType = CommandType.Text;

            con.Open();

            int maxRecord = Convert.ToInt32(selectcmd.ExecuteScalar()) + 1;



            ///string insertQuery = "Insert into Problem values(" + maxRecord + ",'" + txtProblem.Text + "','" + txtEnvironment.Text + "','" + txtModule.Text + "','" + txtDepartment.Text + "','" + txtProblemType.Text + "')";  ////"SP_SaveProblem"

            using (con = new OleDbConnection(connectionString))

            {

                OleDbCommand cmd = con.CreateCommand();

                ///using (cmd = new OleDbCommand(insertQuery, con))

                {

                    con.Open();

                    cmd.CommandType = CommandType.Text;  ////cmd.CommandType = CommandType.StoredProcedure;

                    ////cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.ToString());

                    ////cmd.Parameters.AddWithValue("@Module ", txtModule.Text.ToString());     

                    ////cmd.Parameters.AddWithValue("@Environment ", txtEnvironment.Text.ToString());

                    cmd.ExecuteNonQuery();

                    ////DataStatus.Text = "Record Saved Successfully";

                }

                con.Close();

            }

        }



        

    }

}
