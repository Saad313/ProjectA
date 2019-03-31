namespace ProjectA
{
    partial class EditEvaluation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttotalMarks = new System.Windows.Forms.TextBox();
            this.txttotalWiegtage = new System.Windows.Forms.TextBox();
            this.txtobtainMarks = new System.Windows.Forms.TextBox();
            this.dTPEvalDate = new System.Windows.Forms.DateTimePicker();
            this.cmdEditEval = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtgroupid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Weightage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Obtained Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Evaluation Date";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(308, 79);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 20);
            this.txtname.TabIndex = 6;
            // 
            // txttotalMarks
            // 
            this.txttotalMarks.Location = new System.Drawing.Point(308, 143);
            this.txttotalMarks.Name = "txttotalMarks";
            this.txttotalMarks.Size = new System.Drawing.Size(121, 20);
            this.txttotalMarks.TabIndex = 7;
            // 
            // txttotalWiegtage
            // 
            this.txttotalWiegtage.Location = new System.Drawing.Point(308, 211);
            this.txttotalWiegtage.Name = "txttotalWiegtage";
            this.txttotalWiegtage.Size = new System.Drawing.Size(121, 20);
            this.txttotalWiegtage.TabIndex = 8;
            // 
            // txtobtainMarks
            // 
            this.txtobtainMarks.Location = new System.Drawing.Point(308, 266);
            this.txtobtainMarks.Name = "txtobtainMarks";
            this.txtobtainMarks.Size = new System.Drawing.Size(121, 20);
            this.txtobtainMarks.TabIndex = 9;
            // 
            // dTPEvalDate
            // 
            this.dTPEvalDate.Location = new System.Drawing.Point(308, 328);
            this.dTPEvalDate.Name = "dTPEvalDate";
            this.dTPEvalDate.Size = new System.Drawing.Size(200, 20);
            this.dTPEvalDate.TabIndex = 11;
            // 
            // cmdEditEval
            // 
            this.cmdEditEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditEval.Location = new System.Drawing.Point(546, 391);
            this.cmdEditEval.Name = "cmdEditEval";
            this.cmdEditEval.Size = new System.Drawing.Size(87, 39);
            this.cmdEditEval.TabIndex = 12;
            this.cmdEditEval.Text = "Submit";
            this.cmdEditEval.UseVisualStyleBackColor = true;
            this.cmdEditEval.Click += new System.EventHandler(this.cmdEditEval_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(52, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Goto Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtgroupid
            // 
            this.txtgroupid.Location = new System.Drawing.Point(308, 29);
            this.txtgroupid.Name = "txtgroupid";
            this.txtgroupid.Size = new System.Drawing.Size(121, 20);
            this.txtgroupid.TabIndex = 14;
            // 
            // EditEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgroupid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmdEditEval);
            this.Controls.Add(this.dTPEvalDate);
            this.Controls.Add(this.txtobtainMarks);
            this.Controls.Add(this.txttotalWiegtage);
            this.Controls.Add(this.txttotalMarks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditEvaluation";
            this.Text = "EditEvaluation";
            this.Load += new System.EventHandler(this.EditEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotalMarks;
        private System.Windows.Forms.TextBox txttotalWiegtage;
        private System.Windows.Forms.TextBox txtobtainMarks;
        private System.Windows.Forms.DateTimePicker dTPEvalDate;
        private System.Windows.Forms.Button cmdEditEval;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtgroupid;
    }
}