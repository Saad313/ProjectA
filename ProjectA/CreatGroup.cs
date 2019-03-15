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
    public partial class CreatGroup : Form
    {
        public CreatGroup()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";

        private void cmbStudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<string> cmbtempstudentList = new List<string>();
        public List<string> tempstudentsid = new List<string>();
        public List<string> tempstndntlist = new List<string>();


        private void CreatGroup_Load(object sender, EventArgs e)
        {
            studentsList();


        }
        public void studentsList()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query;
            if (con.State == System.Data.ConnectionState.Open)
            {
                query = "Select * from Student";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbtempstudentList.Add(reader["RegistrationNo"].ToString());
                }
                
            }
            foreach (string s in cmbtempstudentList)
            {
                cmbStudentsList.Items.Add(s);
            }
        }

        

        private void cmdaddtogroup_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "select * from Student where RegistrationNo = '" +Convert.ToString(cmbStudentsList.SelectedItem) + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string reg = reader["RegistrationNo"].ToString();
                    string id = reader["Id"].ToString();
                    tempstndntlist.Add(reg);
                    tempstudentsid.Add(id);
                }
                foreach (string student in tempstndntlist)
                {
                    dataGridView1.Rows.Add(student);
                    
                }
            }




        }

        private void cmdCreateGroup_Click(object sender, EventArgs e)
        {
            //string q;
            SqlConnection s = new SqlConnection(conStr);
            s.Open();
            
            if (s.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO [dbo].[Group](Created_On) VALUES ('" + Convert.ToDateTime(dTPgroupCreatdate.Value) + "')";
                SqlCommand cmd = new SqlCommand(Insert, s);
                cmd.ExecuteNonQuery();
                
            }

            string I = "Select @@identity as id from [Group]";
            SqlCommand cm = new SqlCommand(I, s);

            SqlDataReader reader = cm.ExecuteReader();

            string id = "0";

            if (reader.Read())
            {
                id = (reader["id"].ToString());
                MessageBox.Show(id);
            }
            

            foreach (string small_s in tempstudentsid)
            {
                string q;
                if (cmbStatus.SelectedIndex == 0)
                {
                    q = "Insert into GroupStudent(GroupId, StudentId, Status, AssignmentDate) " +
                        "Values (" + id + "," + small_s.ToString() + ", 3 ,'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                }
                else
                {
                    q = "Insert into GroupStudent(GroupId, StudentId, Status, AssignmentDate) " +
                        "Values (" + id + "," + small_s.ToString() + ", 4 ,'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";

                    

                }
                SqlCommand cmd = new SqlCommand(q, s);
                cmd.ExecuteNonQuery();

            }
            
        }
    }
}
