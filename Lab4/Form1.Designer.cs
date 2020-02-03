namespace Lab4
{
    partial class Lab4Form
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
            this.checkBtn = new System.Windows.Forms.Button();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.admissionsTxt = new System.Windows.Forms.TextBox();
            this.gpaLbl = new System.Windows.Forms.Label();
            this.admissionsLbl = new System.Windows.Forms.Label();
            this.totalAcceptedLbl = new System.Windows.Forms.Label();
            this.outAcceptedLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.outStatusLbl = new System.Windows.Forms.Label();
            this.totalRejectedLbl = new System.Windows.Forms.Label();
            this.outRejectedLbl = new System.Windows.Forms.Label();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(100, 228);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(124, 45);
            this.checkBtn.TabIndex = 0;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // gpaText
            // 
            this.gpaText.Location = new System.Drawing.Point(331, 40);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(100, 31);
            this.gpaText.TabIndex = 1;
            // 
            // admissionsTxt
            // 
            this.admissionsTxt.Location = new System.Drawing.Point(331, 83);
            this.admissionsTxt.Name = "admissionsTxt";
            this.admissionsTxt.Size = new System.Drawing.Size(100, 31);
            this.admissionsTxt.TabIndex = 2;
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(12, 43);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(119, 25);
            this.gpaLbl.TabIndex = 3;
            this.gpaLbl.Text = "Enter GPA:";
            // 
            // admissionsLbl
            // 
            this.admissionsLbl.AutoSize = true;
            this.admissionsLbl.Location = new System.Drawing.Point(12, 86);
            this.admissionsLbl.Name = "admissionsLbl";
            this.admissionsLbl.Size = new System.Drawing.Size(295, 25);
            this.admissionsLbl.TabIndex = 4;
            this.admissionsLbl.Text = "Enter Admissions Test Score:";
            // 
            // totalAcceptedLbl
            // 
            this.totalAcceptedLbl.AutoSize = true;
            this.totalAcceptedLbl.Location = new System.Drawing.Point(62, 327);
            this.totalAcceptedLbl.Name = "totalAcceptedLbl";
            this.totalAcceptedLbl.Size = new System.Drawing.Size(162, 25);
            this.totalAcceptedLbl.TabIndex = 5;
            this.totalAcceptedLbl.Text = "Total Accepted:";
            // 
            // outAcceptedLbl
            // 
            this.outAcceptedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outAcceptedLbl.Location = new System.Drawing.Point(290, 327);
            this.outAcceptedLbl.Name = "outAcceptedLbl";
            this.outAcceptedLbl.Size = new System.Drawing.Size(108, 25);
            this.outAcceptedLbl.TabIndex = 6;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(145, 154);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(79, 25);
            this.statusLbl.TabIndex = 7;
            this.statusLbl.Text = "Status:";
            // 
            // outStatusLbl
            // 
            this.outStatusLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outStatusLbl.Location = new System.Drawing.Point(290, 154);
            this.outStatusLbl.Name = "outStatusLbl";
            this.outStatusLbl.Size = new System.Drawing.Size(108, 25);
            this.outStatusLbl.TabIndex = 8;
            // 
            // totalRejectedLbl
            // 
            this.totalRejectedLbl.AutoSize = true;
            this.totalRejectedLbl.Location = new System.Drawing.Point(67, 387);
            this.totalRejectedLbl.Name = "totalRejectedLbl";
            this.totalRejectedLbl.Size = new System.Drawing.Size(157, 25);
            this.totalRejectedLbl.TabIndex = 9;
            this.totalRejectedLbl.Text = "Total Rejected:";
            // 
            // outRejectedLbl
            // 
            this.outRejectedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outRejectedLbl.Location = new System.Drawing.Point(290, 387);
            this.outRejectedLbl.Name = "outRejectedLbl";
            this.outRejectedLbl.Size = new System.Drawing.Size(108, 25);
            this.outRejectedLbl.TabIndex = 10;
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Location = new System.Drawing.Point(295, 228);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(124, 45);
            this.clearFormBtn.TabIndex = 12;
            this.clearFormBtn.Text = "Clear";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.clearFormBtn_Click);
            // 
            // Lab4Form
            // 
            this.AcceptButton = this.checkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearFormBtn;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.outRejectedLbl);
            this.Controls.Add(this.totalRejectedLbl);
            this.Controls.Add(this.outStatusLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.outAcceptedLbl);
            this.Controls.Add(this.totalAcceptedLbl);
            this.Controls.Add(this.admissionsLbl);
            this.Controls.Add(this.gpaLbl);
            this.Controls.Add(this.admissionsTxt);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.checkBtn);
            this.Name = "Lab4Form";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.TextBox admissionsTxt;
        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label admissionsLbl;
        private System.Windows.Forms.Label totalAcceptedLbl;
        private System.Windows.Forms.Label outAcceptedLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label outStatusLbl;
        private System.Windows.Forms.Label totalRejectedLbl;
        private System.Windows.Forms.Label outRejectedLbl;
        private System.Windows.Forms.Button clearFormBtn;
    }
}

