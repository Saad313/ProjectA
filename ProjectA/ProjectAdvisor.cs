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
            string query;
            if (con.State == System.Data.ConnectionState.Open)
            {
               // query  = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId , AdvisorRole , AssignmentDate) VALUES('" + id + "','" + Convert.ToString(txtRegNo.Text) + "')";
            }

        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query;
            if (con.State == System.Data.ConnectionState.Open)
            {
                query = "Select * from Project";
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
    }
}
