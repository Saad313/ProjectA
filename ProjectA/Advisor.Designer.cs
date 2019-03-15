namespace ProjectA
{
    partial class Advisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.cmdAddAdvisor = new System.Windows.Forms.Button();
            this.txtadvisorid = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblAdvisorId = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(0, 49);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(86, 18);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(0, 98);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(49, 18);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(101, 96);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 3;
            // 
            // cmdAddAdvisor
            // 
            this.cmdAddAdvisor.Location = new System.Drawing.Point(239, 180);
            this.cmdAddAdvisor.Name = "cmdAddAdvisor";
            this.cmdAddAdvisor.Size = new System.Drawing.Size(102, 33);
            this.cmdAddAdvisor.TabIndex = 4;
            this.cmdAddAdvisor.Text = "Add Advisor";
            this.cmdAddAdvisor.UseVisualStyleBackColor = true;
            this.cmdAddAdvisor.Click += new System.EventHandler(this.cmdAddAdvisor_Click);
            // 
            // txtadvisorid
            // 
            this.txtadvisorid.Location = new System.Drawing.Point(101, 0);
            this.txtadvisorid.Name = "txtadvisorid";
            this.txtadvisorid.Size = new System.Drawing.Size(100, 20);
            this.txtadvisorid.TabIndex = 2;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(101, 46);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(121, 21);
            this.cmbDesignation.TabIndex = 5;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // lblAdvisorId
            // 
            this.lblAdvisorId.AutoSize = true;
            this.lblAdvisorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorId.Location = new System.Drawing.Point(0, 0);
            this.lblAdvisorId.Name = "lblAdvisorId";
            this.lblAdvisorId.Size = new System.Drawing.Size(72, 18);
            this.lblAdvisorId.TabIndex = 6;
            this.lblAdvisorId.Text = "Advisor Id";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(473, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GotoMain";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 428);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblAdvisorId);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.cmdAddAdvisor);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtadvisorid);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDesignation);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button cmdAddAdvisor;
        private System.Windows.Forms.TextBox txtadvisorid;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblAdvisorId;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}