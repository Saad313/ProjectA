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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        int selected;
        public static int studentid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex == 0)
            {
                Students s = StudentsUtile.updateSt;
                studentid = (int)row.Cells[2].Value;
                s.FirstName1 = row.Cells[3].Value.ToString();
                s.LastName1 = row.Cells[4].Value.ToString();
                s.Contact1 = row.Cells[5].Value.ToString();
                s.Email1 = row.Cells[6].Value.ToString();
                s.DateOfBirth1 = (DateTime)row.Cells[7].Value;
                //s.Gender = row.Cells[8].Value.ToString();
                int temp = Convert.ToInt32(row.Cells[8].Value);
                if (temp == 1)
                {
                    s.Gender = "Male";
                }
                else
                {
                    s.Gender = "Female";
                }
                s.RegisterationNo1 = row.Cells[9].Value.ToString();
                EditStudents es = new EditStudents();
                es.Show();
                this.Hide();

                
            }
            if(e.ColumnIndex == 1)
            { 
                int Id = Convert.ToInt32(row.Cells[2].Value);
                DialogResult res = MessageBox.Show("Are you sure you want  to Delete " + Id, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                
                    try
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            
                            string Delete_Group = "DELETE FROM GroupStudent WHERE StudentId = '" + Id + "'";
                            SqlCommand sql = new SqlCommand(Delete_Group, con);
                            sql.ExecuteNonQuery();
                            string Delete_Student = "DELETE FROM Student WHERE Id = '" + Id + "'";
                            SqlCommand connection = new SqlCommand(Delete_Student, con);
                            connection.ExecuteNonQuery();
                            string Delete = "DELETE FROM Person WHERE Id = '" + Id + "'";
                            SqlCommand cmd = new SqlCommand(Delete, con);
                            cmd.ExecuteNonQuery();

                        }
                        //setGrid();
                        MessageBox.Show("Succesfully Deleted");
                        this.Hide();
                        ViewStudents vs = new ViewStudents();
                        vs.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                }
            }

        }


        //int select;
        private void ViewStudents_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string sho = "SELECT Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, RegistrationNo FROM Person JOIN Student ON Person.Id = Student.Id ";
                DataTable table = new DataTable();


                SqlDataAdapter da = new SqlDataAdapter(sho, con);

                da.Fill(table);

                dataGridView1.DataSource = table;
                //select = dataGridView1.CurrentCell.RowIndex;
                //DataGridViewRow rows = dataGridView1.Rows[select];
                //string tempo = Convert.ToString(rows.Cells[8].Value);
                //string m = "Male";
                //string f = "Female";
                //if (tempo == "1")
                //{
                //    rows.Cells[8].Value = m;
                //}
                //else
                //{
                //    rows.Cells[8].Value = f;
                //    //Convert.ToString(rows.Cells[8].Value = "Female");
                //}

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }
    }
}
