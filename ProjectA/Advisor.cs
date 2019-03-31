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
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        private void Advisor_Load(object sender, EventArgs e)
        {

        }

        private void cmdAddAdvisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string Desig = "";
                string data;
                if(cmbDesignation.SelectedIndex == 0)
                {
                    Desig = "6";
                    //data = "insert into (Designation , Salary) Values ()"
                }
                if(cmbDesignation.SelectedIndex == 1)
                { Desig = "7"; }
                if (cmbDesignation.SelectedIndex == 2)
                { Desig = "8"; }
                if (cmbDesignation.SelectedIndex == 3)
                { Desig = "9"; }
                if (cmbDesignation.SelectedIndex == 4)
                { Desig = "10"; }
                data = "insert into Advisor(Id, Designation , Salary) values ( '"+ Convert.ToString(txtadvisorid.Text)+"' ,  '" + Convert.ToInt32( Desig) + "', '" + Convert.ToInt32(txtsalary.Text) + "')";
                SqlCommand cmd = new SqlCommand(data, con);
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Advisor Added in database");
                        //string show = "select * from OnlyName";
                        //DataTable table = new DataTable();
                        //SqlDataAdapter dat = new SqlDataAdapter(show, con);
                        //dat.Fill(table);

                        //dataGridView1.DataSource = table;
                        //cmd.CommandText = "Select @@Identity";
                        //id = Convert.ToInt32(cmd.ExecuteScalar());
                        //string InsertStudent = "INSERT INTO Student(Id, RegistrationNo) VALUES('" + id + "','" + Convert.ToString(txtRegNo.Text) + "')";
                        //SqlCommand sqlCommand = new SqlCommand(InsertStudent, con);
                        //sqlCommand.ExecuteNonQuery()
                        this.Close() ;
                        Advisor a = new Advisor();
                        a.Show();

                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                }
            }
           

        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }
    }
}
