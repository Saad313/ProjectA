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
    public partial class ViewProject : Form
    {
        public ViewProject()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";


        private void ViewProject_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string sho = "Select * from Project";
                DataTable table = new DataTable();


                SqlDataAdapter da = new SqlDataAdapter(sho, con);
                da.Fill(table);

                dataGridView1.DataSource = table;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard l = new DashBoard();
            this.Hide();
            l.Show();
        }
        int selected;
        public static int projectid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex == 0)
            {
                Prooject p = ProjectUtile.updPro;
                projectid = (int)row.Cells[2].Value;
                p.Title1 = row.Cells[4].Value.ToString();
                p.Description1 = row.Cells[3].Value.ToString();
                EditProject ep = new EditProject();
                this.Hide();
                ep.Show();

                
            }
            if (e.ColumnIndex == 1)
            {
                int Id = Convert.ToInt32(row.Cells[2].Value);
                string p_name = row.Cells[4].Value.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want  to Delete " + p_name, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                
                    try
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {

                            string Delete_Project = "DELETE FROM Project WHERE Id = '" +Id + "'";
                            SqlCommand sql = new SqlCommand(Delete_Project, con);
                            sql.ExecuteNonQuery();
                        }
                        //setGrid();
                        MessageBox.Show("Succesfully Deleted");
                        this.Hide();
                        ViewProject vp = new ViewProject();
                        vp.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                }
            }
        }
    }
}
