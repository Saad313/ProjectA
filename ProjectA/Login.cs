﻿using System;
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
            Advisor ad = new Advisor();
            this.Hide();
            ad.Show();
        }
    }
}
