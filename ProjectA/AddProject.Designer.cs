namespace ProjectA
{
    partial class AddProject
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.cmdAddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(94, 66);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(35, 18);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(94, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(204, 66);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 20);
            this.txttitle.TabIndex = 2;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(204, 128);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 20);
            this.txtdescription.TabIndex = 3;
            // 
            // cmdAddProject
            // 
            this.cmdAddProject.Location = new System.Drawing.Point(318, 219);
            this.cmdAddProject.Name = "cmdAddProject";
            this.cmdAddProject.Size = new System.Drawing.Size(75, 23);
            this.cmdAddProject.TabIndex = 4;
            this.cmdAddProject.Text = "Add Project";
            this.cmdAddProject.UseVisualStyleBackColor = true;
            this.cmdAddProject.Click += new System.EventHandler(this.cmdAddProject_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.cmdAddProject);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbltitle);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button cmdAddProject;
    }
}