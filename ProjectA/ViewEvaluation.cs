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
using System.IO;
using System.Xml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;

namespace ProjectA
{
    public partial class ViewEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";
        public ViewEvaluation()
        {
            InitializeComponent();
        }
        List<Evaluations> temp = new List<Evaluations>();
        private void lblgotomain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard ds = new DashBoard();
            this.Hide();
            ds.Show();
        }
        //public static List<Evaluations> temp = new List<Evaluations>();
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

                temp.Add(eval);
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
            if (e.ColumnIndex == 2)
            {
                int Id_e = (int)row.Cells[3].Value;
                string p_name = row.Cells[6].Value.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want  to Delete " + p_name + "id: " + Id_e, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                            string Delete = "DELETE FROM GroupEvaluation WHERE EvaluationId = '" + eval_id + "' ";
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

            if(e.ColumnIndex == 1)
            {
                StringWriter sw = new StringWriter();
                XmlTextWriter hw = new XmlTextWriter(sw);

                StringBuilder sb = new StringBuilder();

                //Generate Invoice (Bill) Header.

                sb.Append("<p style=\"text-align:center; font-size: 32px; \"><b>University of Engineering and Technology, Lahore</b></p>");
                sb.Append("<p style=\"text-align:center; font-size: 20px; \"><b>CSE Department</b></p>");
                sb.Append("<p style=\"text-align:center; \"><b><u>Projects Report</b></u></p>");


                StringReader sr = new StringReader(sb.ToString());


                PdfPTable tbl = new PdfPTable(9);
                tbl.AddCell("Sr No");
                tbl.AddCell("EvalId");
                tbl.AddCell("Eval Name");
                tbl.AddCell("GroupId");
                tbl.AddCell("TotalMarks");
                tbl.AddCell("ObtainedMarks");
                tbl.AddCell("TotalWeightage");
                
                int i = 1;
                //Prooject a = new Prooject();

                //Evaluations ea = new Evaluations();
                
                foreach (Evaluations p in Evaluations.groupEvals)
                {
                    tbl.AddCell(i.ToString());
                    tbl.AddCell(p.EvalId1.ToString());
                    tbl.AddCell(p.EvalName1);
                    tbl.AddCell(p.GroupId1.ToString());
                    tbl.AddCell(p.TotalMarks1.ToString());
                    tbl.AddCell(p.ObtainedMarks1.ToString());
                    tbl.AddCell(p.TotalWeightage1.ToString());
                    
                    ++i;

                }


                SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    HTMLWorker htmlparser = new HTMLWorker(document);

                    try
                    {
                        PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        document.Open();
                        htmlparser.Parse(sr);
                        document.Add(new iTextSharp.text.Paragraph("\n Date : " + DateTime.Now.ToShortDateString() + "\n \n"));
                        document.Add(tbl);
                        document.Add(new iTextSharp.text.Paragraph("\n \n This report was generated by computer. Errors are acceptible. "));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        document.Close();
                    }
                    MessageBox.Show("Report saved successfully");
                }

            }
        }
    }
}
