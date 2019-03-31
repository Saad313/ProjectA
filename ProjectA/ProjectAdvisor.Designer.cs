namespace ProjectA
{
    partial class ProjectAdvisor
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
            this.lbladvisorrole = new System.Windows.Forms.Label();
            this.lblAssignmentDate = new System.Windows.Forms.Label();
            this.cmbadvisorRole = new System.Windows.Forms.ComboBox();
            this.dTPAssigmentDay = new System.Windows.Forms.DateTimePicker();
            this.cmdalocatePAdvisor = new System.Windows.Forms.Button();
            this.lblprojecttitle = new System.Windows.Forms.Label();
            this.cmbtitle = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbAdvisorId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladvisorrole
            // 
            this.lbladvisorrole.AutoSize = true;
            this.lbladvisorrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvisorrole.Location = new System.Drawing.Point(0, 48);
            this.lbladvisorrole.Name = "lbladvisorrole";
            this.lbladvisorrole.Size = new System.Drawing.Size(92, 18);
            this.lbladvisorrole.TabIndex = 0;
            this.lbladvisorrole.Text = "Advisor Role";
            // 
            // lblAssignmentDate
            // 
            this.lblAssignmentDate.AutoSize = true;
            this.lblAssignmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentDate.Location = new System.Drawing.Point(0, 156);
            this.lblAssignmentDate.Name = "lblAssignmentDate";
            this.lblAssignmentDate.Size = new System.Drawing.Size(115, 18);
            this.lblAssignmentDate.TabIndex = 1;
            this.lblAssignmentDate.Text = "Assignment Day";
            // 
            // cmbadvisorRole
            // 
            this.cmbadvisorRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadvisorRole.FormattingEnabled = true;
            this.cmbadvisorRole.Location = new System.Drawing.Point(191, 45);
            this.cmbadvisorRole.Name = "cmbadvisorRole";
            this.cmbadvisorRole.Size = new System.Drawing.Size(200, 21);
            this.cmbadvisorRole.TabIndex = 2;
            // 
            // dTPAssigmentDay
            // 
            this.dTPAssigmentDay.Location = new System.Drawing.Point(191, 154);
            this.dTPAssigmentDay.Name = "dTPAssigmentDay";
            this.dTPAssigmentDay.Size = new System.Drawing.Size(200, 20);
            this.dTPAssigmentDay.TabIndex = 3;
            // 
            // cmdalocatePAdvisor
            // 
            this.cmdalocatePAdvisor.Location = new System.Drawing.Point(387, 237);
            this.cmdalocatePAdvisor.Name = "cmdalocatePAdvisor";
            this.cmdalocatePAdvisor.Size = new System.Drawing.Size(116, 27);
            this.cmdalocatePAdvisor.TabIndex = 4;
            this.cmdalocatePAdvisor.Text = "Allocate Advisor";
            this.cmdalocatePAdvisor.UseVisualStyleBackColor = true;
            this.cmdalocatePAdvisor.Click += new System.EventHandler(this.cmdalocatePAdvisor_Click);
            // 
            // lblprojecttitle
            // 
            this.lblprojecttitle.AutoSize = true;
            this.lblprojecttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojecttitle.Location = new System.Drawing.Point(0, 96);
            this.lblprojecttitle.Name = "lblprojecttitle";
            this.lblprojecttitle.Size = new System.Drawing.Size(86, 18);
            this.lblprojecttitle.TabIndex = 5;
            this.lblprojecttitle.Text = "Project Title";
            // 
            // cmbtitle
            // 
            this.cmbtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtitle.FormattingEnabled = true;
            this.cmbtitle.Location = new System.Drawing.Point(191, 93);
            this.cmbtitle.Name = "cmbtitle";
            this.cmbtitle.Size = new System.Drawing.Size(200, 21);
            this.cmbtitle.TabIndex = 6;
            this.cmbtitle.SelectedIndexChanged += new System.EventHandler(this.cmbtitle_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(30, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GotoMain";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbAdvisorId
            // 
            this.cmbAdvisorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvisorId.FormattingEnabled = true;
            this.cmbAdvisorId.Location = new System.Drawing.Point(191, 5);
            this.cmbAdvisorId.Name = "cmbAdvisorId";
            this.cmbAdvisorId.Size = new System.Drawing.Size(200, 21);
            this.cmbAdvisorId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Advisor Id";
            // 
            // ProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdvisorId);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbtitle);
            this.Controls.Add(this.lblprojecttitle);
            this.Controls.Add(this.cmdalocatePAdvisor);
            this.Controls.Add(this.dTPAssigmentDay);
            this.Controls.Add(this.cmbadvisorRole);
            this.Controls.Add(this.lblAssignmentDate);
            this.Controls.Add(this.lbladvisorrole);
            this.Name = "ProjectAdvisor";
            this.Text = "ProjectAdvisor";
            this.Load += new System.EventHandler(this.ProjectAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladvisorrole;
        private System.Windows.Forms.Label lblAssignmentDate;
        private System.Windows.Forms.ComboBox cmbadvisorRole;
        private System.Windows.Forms.DateTimePicker dTPAssigmentDay;
        private System.Windows.Forms.Button cmdalocatePAdvisor;
        private System.Windows.Forms.Label lblprojecttitle;
        private System.Windows.Forms.ComboBox cmbtitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbAdvisorId;
        private System.Windows.Forms.Label label1;
    }
}