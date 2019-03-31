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
    public partial class ProjectAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        public ProjectAdvisor()
        {
            InitializeComponent();
        }
        public List<string> temp = new List<string>();
        private void cmdalocatePAdvisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string Insert;
            if (con.State == System.Data.ConnectionState.Open)
            {
                Insert = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ('" + Convert.ToInt32(cmbAdvisorId.Text) + "', (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbtitle.Text) + "'), (SELECT Lookup.Id FROM Lookup WHERE Lookup.Value = '" + Convert.ToString(cmbadvisorRole.Text) + "'), '" + Convert.ToDateTime(dTPAssigmentDay.Value) + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Inserted");
                // query  = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId , AdvisorRole , AssignmentDate) VALUES('" + id + "','" + Convert.ToString(txtRegNo.Text) + "')";
            }
            projectTitle();
            //MessageBox.Show("SuccessFully Added");
            this.Hide();
            ProjectAdvisor a = new ProjectAdvisor();
            a.Show();



        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            projectTitle();
            

        }

        public void projectTitle()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query;
            if (con.State == System.Data.ConnectionState.Open)
            {
                query = "SELECT Title FROM Project WHERE Id NOT IN (SELECT ProjectId FROM ProjectAdvisor  GROUP BY ProjectId HAVING COUNT(AdvisorId) = 3)";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(reader["Title"].ToString());
                }
                addtitle();
            }

        }
        public void addtitle()
        {
            foreach(string c in temp)
            {
                cmbtitle.Items.Add(c);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }

        private void cmbtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            cmbAdvisorId.Items.Clear();

            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Id FROM Advisor WHERE Id NOT IN (SELECT AdvisorId FROM ProjectAdvisor WHERE ProjectId = (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbtitle.Text) + "'))";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbAdvisorId.Items.Add(reader["Id"]);
                }

                cmbadvisorRole.Items.Clear();

                cmbadvisorRole.Items.Add("Main Advisor");
                cmbadvisorRole.Items.Add("Co-Advisror");
                cmbadvisorRole.Items.Add("Industry Advisor");

                string q = "SELECT Lookup.Value FROM Lookup WHERE Id IN(SELECT AdvisorRole FROM ProjectAdvisor WHERE ProjectId = (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbtitle.Text) + "'))";
                SqlCommand cmd1 = new SqlCommand(q, con);

                reader.Close();

                SqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    string Yo = Convert.ToString(reader1["Value"]);
                    cmbadvisorRole.Items.Remove(Yo);
                }

            }
        }
    }
}
