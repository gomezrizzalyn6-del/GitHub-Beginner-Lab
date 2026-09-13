namespace GitHub_Beginner_Lab
{
    partial class Form1
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
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblyearlevel = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtyearlevel = new System.Windows.Forms.TextBox();
            this.btnsaveprofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(37, 37);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(71, 16);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "Student ID:";
            this.lblstudentid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(37, 104);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(95, 16);
            this.lblstudentname.TabIndex = 2;
            this.lblstudentname.Text = "Student Name:";
            // 
            // lblyearlevel
            // 
            this.lblyearlevel.AutoSize = true;
            this.lblyearlevel.Location = new System.Drawing.Point(37, 176);
            this.lblyearlevel.Name = "lblyearlevel";
            this.lblyearlevel.Size = new System.Drawing.Size(75, 16);
            this.lblyearlevel.TabIndex = 3;
            this.lblyearlevel.Text = "Year Level:";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(40, 56);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(100, 22);
            this.txtstudentid.TabIndex = 4;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(40, 123);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(100, 22);
            this.txtstudentname.TabIndex = 5;
            // 
            // txtyearlevel
            // 
            this.txtyearlevel.Location = new System.Drawing.Point(40, 195);
            this.txtyearlevel.Name = "txtyearlevel";
            this.txtyearlevel.Size = new System.Drawing.Size(100, 22);
            this.txtyearlevel.TabIndex = 6;
            this.txtyearlevel.TextChanged += new System.EventHandler(this.txtyearlevel_TextChanged);
            // 
            // btnsaveprofile
            // 
            this.btnsaveprofile.Location = new System.Drawing.Point(100, 320);
            this.btnsaveprofile.Name = "btnsaveprofile";
            this.btnsaveprofile.Size = new System.Drawing.Size(155, 72);
            this.btnsaveprofile.TabIndex = 7;
            this.btnsaveprofile.Text = "Save Profile";
            this.btnsaveprofile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsaveprofile);
            this.Controls.Add(this.txtyearlevel);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.lblyearlevel);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.lblstudentid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblyearlevel;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtyearlevel;
        private System.Windows.Forms.Button btnsaveprofile;
    }
}

