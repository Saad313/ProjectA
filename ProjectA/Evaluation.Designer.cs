namespace ProjectA
{
    partial class Evaluation
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lbltotalweightage = new System.Windows.Forms.Label();
            this.lblobtainedMarks = new System.Windows.Forms.Label();
            this.lblevaluation = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.txttotalweightage = new System.Windows.Forms.TextBox();
            this.txtobtainedmarks = new System.Windows.Forms.TextBox();
            this.dtpEvaluationDate = new System.Windows.Forms.DateTimePicker();
            this.cmdevaluation = new System.Windows.Forms.Button();
            this.lblgroupid = new System.Windows.Forms.Label();
            this.cmbgroupid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(0, 54);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(0, 89);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lblTotalMarks.TabIndex = 1;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lbltotalweightage
            // 
            this.lbltotalweightage.AutoSize = true;
            this.lbltotalweightage.Location = new System.Drawing.Point(-1, 138);
            this.lbltotalweightage.Name = "lbltotalweightage";
            this.lbltotalweightage.Size = new System.Drawing.Size(86, 13);
            this.lbltotalweightage.TabIndex = 2;
            this.lbltotalweightage.Text = "Total Weightage";
            // 
            // lblobtainedMarks
            // 
            this.lblobtainedMarks.AutoSize = true;
            this.lblobtainedMarks.Location = new System.Drawing.Point(-1, 173);
            this.lblobtainedMarks.Name = "lblobtainedMarks";
            this.lblobtainedMarks.Size = new System.Drawing.Size(82, 13);
            this.lblobtainedMarks.TabIndex = 3;
            this.lblobtainedMarks.Text = "Obtained Marks";
            // 
            // lblevaluation
            // 
            this.lblevaluation.AutoSize = true;
            this.lblevaluation.Location = new System.Drawing.Point(-1, 211);
            this.lblevaluation.Name = "lblevaluation";
            this.lblevaluation.Size = new System.Drawing.Size(83, 13);
            this.lblevaluation.TabIndex = 4;
            this.lblevaluation.Text = "Evaluation Date";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(89, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 5;
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Location = new System.Drawing.Point(89, 89);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.Size = new System.Drawing.Size(100, 20);
            this.txttotalmarks.TabIndex = 6;
            // 
            // txttotalweightage
            // 
            this.txttotalweightage.Location = new System.Drawing.Point(91, 131);
            this.txttotalweightage.Name = "txttotalweightage";
            this.txttotalweightage.Size = new System.Drawing.Size(100, 20);
            this.txttotalweightage.TabIndex = 7;
            // 
            // txtobtainedmarks
            // 
            this.txtobtainedmarks.Location = new System.Drawing.Point(89, 166);
            this.txtobtainedmarks.Name = "txtobtainedmarks";
            this.txtobtainedmarks.Size = new System.Drawing.Size(100, 20);
            this.txtobtainedmarks.TabIndex = 8;
            // 
            // dtpEvaluationDate
            // 
            this.dtpEvaluationDate.Location = new System.Drawing.Point(89, 205);
            this.dtpEvaluationDate.Name = "dtpEvaluationDate";
            this.dtpEvaluationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEvaluationDate.TabIndex = 9;
            // 
            // cmdevaluation
            // 
            this.cmdevaluation.Location = new System.Drawing.Point(214, 250);
            this.cmdevaluation.Name = "cmdevaluation";
            this.cmdevaluation.Size = new System.Drawing.Size(75, 23);
            this.cmdevaluation.TabIndex = 10;
            this.cmdevaluation.Text = "Submit";
            this.cmdevaluation.UseVisualStyleBackColor = true;
            this.cmdevaluation.Click += new System.EventHandler(this.cmdevaluation_Click);
            // 
            // lblgroupid
            // 
            this.lblgroupid.AutoSize = true;
            this.lblgroupid.Location = new System.Drawing.Point(-1, 19);
            this.lblgroupid.Name = "lblgroupid";
            this.lblgroupid.Size = new System.Drawing.Size(45, 13);
            this.lblgroupid.TabIndex = 11;
            this.lblgroupid.Text = "GroupId";
            // 
            // cmbgroupid
            // 
            this.cmbgroupid.FormattingEnabled = true;
            this.cmbgroupid.Location = new System.Drawing.Point(89, 19);
            this.cmbgroupid.Name = "cmbgroupid";
            this.cmbgroupid.Size = new System.Drawing.Size(121, 21);
            this.cmbgroupid.TabIndex = 12;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 441);
            this.Controls.Add(this.cmbgroupid);
            this.Controls.Add(this.lblgroupid);
            this.Controls.Add(this.cmdevaluation);
            this.Controls.Add(this.dtpEvaluationDate);
            this.Controls.Add(this.txtobtainedmarks);
            this.Controls.Add(this.txttotalweightage);
            this.Controls.Add(this.txttotalmarks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblevaluation);
            this.Controls.Add(this.lblobtainedMarks);
            this.Controls.Add(this.lbltotalweightage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblname);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lbltotalweightage;
        private System.Windows.Forms.Label lblobtainedMarks;
        private System.Windows.Forms.Label lblevaluation;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.TextBox txttotalweightage;
        private System.Windows.Forms.TextBox txtobtainedmarks;
        private System.Windows.Forms.DateTimePicker dtpEvaluationDate;
        private System.Windows.Forms.Button cmdevaluation;
        private System.Windows.Forms.Label lblgroupid;
        private System.Windows.Forms.ComboBox cmbgroupid;
    }
}