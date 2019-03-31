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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        private void cmdAddProject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string Insert = "INSERT INTO Project(Description, Title) VALUES('" + Convert.ToString(txtdescription.Text) + "', '" + Convert.ToString(txttitle.Text) + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successfully Added");
            this.Close();
            AddProject AP = new AddProject();
            AP.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }
    }
}
