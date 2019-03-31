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
    public partial class ViewEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";
        public ViewEvaluation()
        {
            InitializeComponent();
        }

        private void lblgotomain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard ds = new DashBoard();
            this.Hide();
            ds.Show();
        }

        private void ViewEvaluation_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string sho = "SELECT GroupId, EvaluationId, ObtainedMarks, EvaluationDate, Name, TotalMarks , TotalWeightage FROM GroupEvaluation JOIN Evaluation ON Evaluation.Id = GroupEvaluation.EvaluationId";
                DataTable table = new DataTable();


                SqlDataAdapter da = new SqlDataAdapter(sho, con);

                da.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
        int selected;
        public static int eval_id;
        public static int eval_group_id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex == 0)
            {
                Evaluations eval = EvaluationUtile.updateEval;
                eval_id = (int)row.Cells[3].Value;
                eval_group_id = (int)row.Cells[2].Value;
                eval.ObtainedMarks1 = Convert.ToInt32(row.Cells[4].Value);
                eval.EvalDate1 = Convert.ToDateTime(row.Cells[5].Value);
                eval.EvalName1 = Convert.ToString(row.Cells[6].Value);
                eval.TotalMarks1 = Convert.ToInt32(row.Cells[7].Value);
                eval.TotalWeightage1 = Convert.ToInt32(row.Cells[8].Value);
                //Prooject p = ProjectUtile.updPro;
                ////projectid = (int)row.Cells[2].Value;
                //p.Title1 = row.Cells[4].Value.ToString();
                //p.Description1 = row.Cells[3].Value.ToString();
                //EditProject ep = new EditProject();
                //this.Hide();
                //ep.Show();
                this.Hide();
                EditEvaluation ee = new EditEvaluation();
                ee.Show();


            }
            if (e.ColumnIndex == 1)
            {
                //int Id = Convert.ToInt32(row.Cells[2].Value);
                string p_name = row.Cells[6].Value.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want  to Delete " + p_name, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    try
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            
                            string Delete_Group_Evaluation = "DELETE FROM Evaluation WHERE Id = '" + eval_id + "'";
                            SqlCommand cmd = new SqlCommand(Delete_Group_Evaluation, con);
                            cmd.ExecuteNonQuery();
                        }
                        if (con.State == ConnectionState.Open)
                        {
                            string Delete = "DELETE FROM GroupEvaluation WHERE EvaluationId = '" + eval_id + "'";
                            SqlCommand cmd = new SqlCommand(Delete, con);
                            cmd.ExecuteNonQuery();
                        }
                        //setGrid();
                        MessageBox.Show("Succesfully Deleted");
                        this.Hide();
                        ViewEvaluation vp = new ViewEvaluation();
                        vp.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                }
            }
        }
    }
}
