namespace ProjectA
{
    partial class CreatGroup
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
            this.dTPgroupCreatdate = new System.Windows.Forms.DateTimePicker();
            this.lblgroupCreatDAte = new System.Windows.Forms.Label();
            this.lblstudent = new System.Windows.Forms.Label();
            this.cmbStudentsList = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdaddtogroup = new System.Windows.Forms.Button();
            this.cmdCreateGroup = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdgotomain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dTPgroupCreatdate
            // 
            this.dTPgroupCreatdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPgroupCreatdate.Location = new System.Drawing.Point(307, 44);
            this.dTPgroupCreatdate.Name = "dTPgroupCreatdate";
            this.dTPgroupCreatdate.Size = new System.Drawing.Size(200, 20);
            this.dTPgroupCreatdate.TabIndex = 0;
            // 
            // lblgroupCreatDAte
            // 
            this.lblgroupCreatDAte.AutoSize = true;
            this.lblgroupCreatDAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgroupCreatDAte.Location = new System.Drawing.Point(90, 46);
            this.lblgroupCreatDAte.Name = "lblgroupCreatDAte";
            this.lblgroupCreatDAte.Size = new System.Drawing.Size(145, 18);
            this.lblgroupCreatDAte.TabIndex = 1;
            this.lblgroupCreatDAte.Text = "Group Creation Date";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.Location = new System.Drawing.Point(90, 80);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(85, 18);
            this.lblstudent.TabIndex = 2;
            this.lblstudent.Text = "Student List";
            // 
            // cmbStudentsList
            // 
            this.cmbStudentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentsList.FormattingEnabled = true;
            this.cmbStudentsList.Location = new System.Drawing.Point(307, 77);
            this.cmbStudentsList.Name = "cmbStudentsList";
            this.cmbStudentsList.Size = new System.Drawing.Size(200, 21);
            this.cmbStudentsList.TabIndex = 3;
            this.cmbStudentsList.SelectedIndexChanged += new System.EventHandler(this.cmbStudentsList_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegNo});
            this.dataGridView1.Location = new System.Drawing.Point(93, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // RegNo
            // 
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.Name = "RegNo";
            // 
            // cmdaddtogroup
            // 
            this.cmdaddtogroup.Location = new System.Drawing.Point(432, 149);
            this.cmdaddtogroup.Name = "cmdaddtogroup";
            this.cmdaddtogroup.Size = new System.Drawing.Size(75, 23);
            this.cmdaddtogroup.TabIndex = 5;
            this.cmdaddtogroup.Text = "Submit";
            this.cmdaddtogroup.UseVisualStyleBackColor = true;
            this.cmdaddtogroup.Click += new System.EventHandler(this.cmdaddtogroup_Click);
            // 
            // cmdCreateGroup
            // 
            this.cmdCreateGroup.Location = new System.Drawing.Point(531, 408);
            this.cmdCreateGroup.Name = "cmdCreateGroup";
            this.cmdCreateGroup.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateGroup.TabIndex = 6;
            this.cmdCreateGroup.Text = "Creat Group";
            this.cmdCreateGroup.UseVisualStyleBackColor = true;
            this.cmdCreateGroup.Click += new System.EventHandler(this.cmdCreateGroup_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbStatus.Location = new System.Drawing.Point(307, 113);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(90, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // cmdgotomain
            // 
            this.cmdgotomain.Location = new System.Drawing.Point(93, 408);
            this.cmdgotomain.Name = "cmdgotomain";
            this.cmdgotomain.Size = new System.Drawing.Size(75, 23);
            this.cmdgotomain.TabIndex = 9;
            this.cmdgotomain.Text = "GotoMain";
            this.cmdgotomain.UseVisualStyleBackColor = true;
            this.cmdgotomain.Click += new System.EventHandler(this.cmdgotomain_Click);
            // 
            // CreatGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 453);
            this.Controls.Add(this.cmdgotomain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmdCreateGroup);
            this.Controls.Add(this.cmdaddtogroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbStudentsList);
            this.Controls.Add(this.lblstudent);
            this.Controls.Add(this.lblgroupCreatDAte);
            this.Controls.Add(this.dTPgroupCreatdate);
            this.Name = "CreatGroup";
            this.Text = "CreatGroup";
            this.Load += new System.EventHandler(this.CreatGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPgroupCreatdate;
        private System.Windows.Forms.Label lblgroupCreatDAte;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.ComboBox cmbStudentsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.Button cmdaddtogroup;
        private System.Windows.Forms.Button cmdCreateGroup;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdgotomain;
    }
}