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
    public partial class EditAdvisor : Form
    {
        public EditAdvisor()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=true";


        private void EditAdvisor_Load(object sender, EventArgs e)
        {
            Advisors a = AdvisorUtile.updAdvisor;
            txtAdvisorId.Text = Convert.ToString(ViewAdvisors.advisor_Id);
            txtsalaray.Text = a.Salary1.ToString();
            cmbDesignation.Text = a.Designationstring1;
            txtAdvisorId.ReadOnly = true;


            
        }

        private void cmdEditAdvisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        string Update = "UPDATE Advisor SET Designation = '" + Convert.ToInt32(cmbDesignation.SelectedIndex + 6) + "', Salary = '" + Convert.ToInt32(txtsalaray.Text) + "' WHERE Id = '" + ViewAdvisors.advisor_Id + "'";
                        SqlCommand cmd = new SqlCommand(Update, con);
                        cmd.ExecuteNonQuery();
                    }

                    
                    txtAdvisorId.ReadOnly = false;
                }

                //setGrid();

                MessageBox.Show("Succesfully Updated");
                ViewAdvisors vd = new ViewAdvisors();
                vd.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
