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
    public partial class ViewGroups : Form
    {

        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        public ViewGroups()
        {
            InitializeComponent();
        }

        private void ViewGroups_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string sho = "SELECT \"Group\".Id, \"Group\".Created_On,  COUNT(StudentId) As NumberOfStudents FROM [dbo].[Group] LEFT JOIN GroupStudent ON \"Group\".Id = GroupStudent.GroupId GROUP BY \"Group\".Id,\"Group\".Created_On";
                //string sho = "select * from [dbo].[Group]";
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
            DashBoard a = new DashBoard();
            this.Hide();
            a.Show();
        }
    }
}
