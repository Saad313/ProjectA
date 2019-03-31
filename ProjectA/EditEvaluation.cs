using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class EditEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";

        public EditEvaluation()
        {
            InitializeComponent();
        }

        private void EditEvaluation_Load(object sender, EventArgs e)
        {
            Evaluations a = EvaluationUtile.updateEval;
            txtgroupid.Text = Convert.ToString(ViewEvaluation.eval_group_id);
            txtgroupid.ReadOnly = true;
            txtname.Text = a.EvalName1;
            txtobtainMarks.Text = Convert.ToString(a.ObtainedMarks1);
            txttotalMarks.Text = Convert.ToString(a.TotalMarks1);
            txttotalWiegtage.Text = Convert.ToString(a.TotalWeightage1);
            dTPEvalDate.Value = Convert.ToDateTime(a.EvalDate1);
        }

        private void cmdEditEval_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    //string i = "Update Evaluation SET Evaluation.Name = '" + Convert.ToString(txtname.Text) + "', Evaluation.TotalMarks = '" + Convert.ToString(txttotalMarks.Text) + "', Evaluation.TotalWeightage = '" + Convert.ToString(txttotalWiegtage.Text) + "' , GroupEvaluation.ObtainedMarks = '" + Convert.ToInt32(txtobtainMarks.Text) + "' from Evaluation INNER JOIN GroupEvaluation on Evaluation.Id = GroupEvaluation.EvaluationId WHERE Evaluation.Id = '" + ViewEvaluation.eval_id + "'";
                    //string Update = "UPDATE Evaluation INNER JOIN GroupEvaluation ON Evaluation.Id = GroupEvaluation.EvaluationId SET Evaluation.Name = '" + Convert.ToString(txtname.Text) + "', Evaluation.TotalMarks = '" + Convert.ToString(txttotalMarks.Text) + "', Evaluation.TotalWeightage = '" + Convert.ToString(txttotalWiegtage.Text) + "' , GroupEvaluation.ObtainedMarks = '" + Convert.ToInt32(txtobtainMarks.Text) + "' WHERE Evaluation.Id = '" + ViewEvaluation.eval_id + "'";
                    string Update = "UPDATE Evaluation SET Name = '" + Convert.ToString(txtname.Text) + "', TotalMarks = '" + Convert.ToString(txttotalMarks.Text) + "', TotalWeightage = '" + Convert.ToString(txttotalWiegtage.Text) + "' WHERE Id = '" +ViewEvaluation.eval_id+ "'";

                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                }
                txtgroupid.ReadOnly = false;

                //setGrid();

                MessageBox.Show("Succesfully Updated");
                ViewEvaluation vs = new ViewEvaluation();
                vs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ViewEvaluation ve = new ViewEvaluation();
            ve.Show();
        }
    }
}
