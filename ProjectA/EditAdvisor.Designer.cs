namespace ProjectA
{
    partial class EditAdvisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.txtAdvisorId = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtsalaray = new System.Windows.Forms.TextBox();
            this.cmdEditAdvisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advisor Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(73, 159);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(36, 13);
            this.lblsalary.TabIndex = 2;
            this.lblsalary.Text = "Salary";
            // 
            // txtAdvisorId
            // 
            this.txtAdvisorId.Location = new System.Drawing.Point(229, 27);
            this.txtAdvisorId.Name = "txtAdvisorId";
            this.txtAdvisorId.Size = new System.Drawing.Size(121, 20);
            this.txtAdvisorId.TabIndex = 3;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(229, 86);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(121, 21);
            this.cmbDesignation.TabIndex = 4;
            // 
            // txtsalaray
            // 
            this.txtsalaray.Location = new System.Drawing.Point(229, 151);
            this.txtsalaray.Name = "txtsalaray";
            this.txtsalaray.Size = new System.Drawing.Size(121, 20);
            this.txtsalaray.TabIndex = 5;
            // 
            // cmdEditAdvisor
            // 
            this.cmdEditAdvisor.Location = new System.Drawing.Point(401, 222);
            this.cmdEditAdvisor.Name = "cmdEditAdvisor";
            this.cmdEditAdvisor.Size = new System.Drawing.Size(75, 23);
            this.cmdEditAdvisor.TabIndex = 6;
            this.cmdEditAdvisor.Text = "Sumbit";
            this.cmdEditAdvisor.UseVisualStyleBackColor = true;
            this.cmdEditAdvisor.Click += new System.EventHandler(this.cmdEditAdvisor_Click);
            // 
            // EditAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdEditAdvisor);
            this.Controls.Add(this.txtsalaray);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtAdvisorId);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAdvisor";
            this.Text = "EditAdvisor";
            this.Load += new System.EventHandler(this.EditAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.TextBox txtAdvisorId;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtsalaray;
        private System.Windows.Forms.Button cmdEditAdvisor;
    }
}