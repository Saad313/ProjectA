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
    public partial class ViewAdvisors : Form
    {
        public ViewAdvisors()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";


        private void ViewAdvisors_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string sho = "Select * from Advisor";
                DataTable table = new DataTable();


                SqlDataAdapter da = new SqlDataAdapter(sho, con);
                da.Fill(table);

                dataGridView1.DataSource = table;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }
        int selected;
        public static int advisor_Id; 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex == 0)
            {
                Advisors a = AdvisorUtile.updAdvisor;
                
                advisor_Id = (int)row.Cells[2].Value;
                a.Salary1 = Convert.ToInt32(row.Cells[4].Value);
                a.Designation1 = (int)row.Cells[3].Value;
                if (a.Designation1 == 6)
                {
                    a.Designationstring1 = "Professor";
                }
                else if (a.Designation1 == 7)
                {
                    a.Designationstring1 = "Associate Professor";
                }
                else if (a.Designation1 == 8)
                {
                    a.Designationstring1 = "Assistant Professor";
                }
                else if (a.Designation1 == 9)
                {
                    a.Designationstring1 = "Lecturer";
                }
                else if (a.Designation1 == 10)
                {
                    a.Designationstring1 = "Industry Professional";
                }



                EditAdvisor ea = new EditAdvisor();
                this.Hide();
                ea.Show();


            }
            if (e.ColumnIndex == 1)
            {
                int Id = Convert.ToInt32(row.Cells[2].Value);
                //string advisor = row.Cells[3].Value.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want  to Delete " + Id, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    try
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        //string Delete_Project_Advisor = "DELETE FROM ProjectAdvisor WHERE Id = '" + Id + "'";
                        string Delete = "DELETE FROM Advisor WHERE Id = '" + Id + "'";
                        //if (con.State == ConnectionState.Open)
                        //{
                        //    SqlCommand cmd = new SqlCommand(Delete_Project_Advisor, con);
                        //    cmd.ExecuteNonQuery();
                        //}

                        if (con.State == ConnectionState.Open)
                        {
                            SqlCommand cmd = new SqlCommand(Delete, con);
                            cmd.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Succesfully Deleted");
                        this.Hide();
                        ViewAdvisors va = new ViewAdvisors();
                        va.Show();
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
