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
    public partial class EditStudents : Form
    {
        public EditStudents()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";


        private void EditStudents_Load(object sender, EventArgs e)
        {
            Students s = StudentsUtile.updateSt;
            txtFname.Text = s.FirstName1;
            txtLname.Text = s.LastName1;
            txtContact.Text = s.Contact1;
            txtmail.Text = s.Email1;
            txtregNo.Text = s.RegisterationNo1;
            //txtGender.Text = s.Gender;
            cmbgender.Text = s.Gender;
            dtpDOB.Value = s.DateOfBirth1;

        }
        

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    string Update;
                    if (cmbgender.SelectedIndex == 0)
                    {
                        Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFname.Text) + "', LastName = '" + Convert.ToString(txtLname.Text) + "', Contact = '" + Convert.ToString(txtContact.Text) + "', Email = '" + Convert.ToString(txtmail.Text) + "', DateOfBirth = '" + Convert.ToDateTime(dtpDOB.Value) + "', Gender = '" + 1 + "' WHERE ID = '" + ViewStudents.studentid + "'";
                    }
                    else
                    {
                        Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFname.Text) + "', LastName = '" + Convert.ToString(txtLname.Text) + "', Contact = '" + Convert.ToString(txtContact.Text) + "', Email = '" + Convert.ToString(txtmail.Text) + "', DateOfBirth = '" + Convert.ToDateTime(dtpDOB.Value) + "', Gender = '" + 2 + "' WHERE ID = '" + ViewStudents.studentid + "'";
                    }
                    string Update_Student = "UPDATE Student SET RegistrationNo = '" + Convert.ToString(txtregNo.Text) + "' WHERE Id = '" + ViewStudents.studentid + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand sqlCommand = new SqlCommand(Update_Student, con);
                    sqlCommand.ExecuteNonQuery();
                }
                
                //setGrid();

                MessageBox.Show("Succesfully Updated");
                ViewStudents vs = new ViewStudents();
                vs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
