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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        private void cmdAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            

            if (con.State == System.Data.ConnectionState.Open)
            {
                string data;
                if (cmbgender.SelectedIndex == 0)
                {
                    data = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtfname.Text) + "', '" + Convert.ToString(txtLname.Text) + "','" + Convert.ToString(txtcontactNo.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtpDOB.Value) + "', '" + 1 + "')"; 

                }
                else
                {
                    data = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtfname.Text) + "', '" + Convert.ToString(txtLname.Text) + "','" + Convert.ToString(txtcontactNo.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtpDOB.Value) + "', '" + 2 + "')";
                }
                //string data = "insert into Person(,Address,City,Telephone,ContactPerson,PhoneNo,Email,Wedsite) values('" + textBox1.Text + "','" + textBox5.Text + "' , '" + textBox2.Text + "' , '" + int.Parse(textBox6.Text) + "', '" + textBox4.Text + "', '" + int.Parse(textBox7.Text) + "','" + textBox3.Text + "', '" + textBox8.Text + "')";
                SqlCommand cmd = new SqlCommand(data, con);
                int id;
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("added in database");
                        //string show = "select * from OnlyName";
                        //DataTable table = new DataTable();
                        //SqlDataAdapter dat = new SqlDataAdapter(show, con);
                        //dat.Fill(table);

                        //dataGridView1.DataSource = table;
                        cmd.CommandText = "Select @@Identity";
                        id = Convert.ToInt32( cmd.ExecuteScalar());
                        string InsertStudent = "INSERT INTO Student(Id, RegistrationNo) VALUES('" + id + "','" + Convert.ToString(txtRegNo.Text) + "')";
                        SqlCommand sqlCommand = new SqlCommand(InsertStudent, con);
                        sqlCommand.ExecuteNonQuery();

                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                }

            }

        }
    }
}
