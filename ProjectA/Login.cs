using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Login : Form
    {

        

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdLOGIN_Click(object sender, EventArgs e)
        {
            AddStudents ass = new AddStudents();
            this.Hide();
            ass.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectAdvisor ad = new ProjectAdvisor();
            this.Hide();
            ad.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProject ap = new AddProject();
            this.Hide();
            ap.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Advisor ad = new Advisor();
            this.Hide();
            ad.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatGroup cg = new CreatGroup();
            cg.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Evaluation ev = new Evaluation();
            ev.Show();
            this.Hide();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_Click(object sender, EventArgs e)
        {
            ViewStudents vs = new ViewStudents();
            vs.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAdvisors va = new ViewAdvisors();
            this.Hide();
            va.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewProject vp = new ViewProject();
            vp.Show();
            this.Hide();
        }
    }
}
