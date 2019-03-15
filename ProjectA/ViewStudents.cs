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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";

        int selected;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex == 0)
            {
                //Students stock = StudentsUtile.updateSt;
                //stock.FirstName1 = row.Cells[1].Value.ToString();
                //stock.LastName1 = (int)row.Cells[2].Value;
                //stock. = (int)row.Cells[3].Value;
                //stock.ItemType1 = row.Cells[4].Value.ToString();
                //MessageBox.Show(row.Cells[5].Value.GetType().ToString());
                //stock.Milligram1 = float.Parse(row.Cells[5].Value.ToString());
                //stock.ManufacturedBy1 = row.Cells[6].Value.ToString();
                //stock.MLNumber1 = row.Cells[7].Value.ToString();
                //stock.DateAdded1 = (DateTime)row.Cells[8].Value;
                //frmUpdateStoke updateStoke = new frmUpdateStoke();
                //this.Hide();
                //updateStoke.Show();
            }

        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                
                string sho = "Select RegistrationNo from Student";
                DataTable table = new DataTable();
                
                
                SqlDataAdapter da = new SqlDataAdapter(sho, con);
                da.Fill(table);
                
                dataGridView1.DataSource = table;
                
            }

        }
    }
}
