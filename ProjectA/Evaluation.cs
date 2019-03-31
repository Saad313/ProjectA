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
    public partial class Evaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";

        public Evaluation()
        {
            InitializeComponent();
        }

        private void cmdevaluation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            
            if (con.State == System.Data.ConnectionState.Open)
            {
                string insert;

                insert = "insert into Evaluation(Name , TotalMarks , TotalWeightage) values ('"+Convert.ToString(txtname.Text)+"' , '"+Convert.ToInt32(txttotalmarks.Text)+"' , '"+Convert.ToInt32(txttotalweightage.Text)+"')";
                int id;
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@Identity";
                id = Convert.ToInt32(cmd.ExecuteScalar());
                string query = "insert into GroupEvaluation(GroupId , EvaluationId , ObtainedMarks , EvaluationDate) values ('"+Convert.ToInt32(cmbgroupid.SelectedItem)+"' , '"+id+"' , '"+Convert.ToInt32(txtobtainedmarks.Text)+"'  , '"+Convert.ToDateTime(dtpEvaluationDate.Value)+"')";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data Evaluated in Group");


            }
            
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "select * from [Group]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    temp.Add(reader["Id"].ToString());
                }
                ///////////////////////////////////////////////////
                
                foreach (string s in temp)
                {
                    cmbgroupid.Items.Add(s);
                }
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
