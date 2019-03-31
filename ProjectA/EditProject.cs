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
    public partial class EditProject : Form
    {
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";

        public EditProject()
        {
            InitializeComponent();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            Prooject p = ProjectUtile.updPro;
            txtTitle.Text = p.Title1;
            txtDescription.Text = p.Description1;
            
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    string Update = "UPDATE Project SET Title = '" + Convert.ToString(txtTitle.Text) + "', Description = '" + Convert.ToString(txtDescription.Text) + "' WHERE Id = '" + ViewProject.projectid + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                }

               

                MessageBox.Show("Data Succesfully Updated");
                ViewProject vp = new ViewProject();
                this.Hide();
                vp.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
