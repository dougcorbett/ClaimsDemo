namespace ClaimsDemo
{
    partial class frmClaimApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdDeleteData = new System.Windows.Forms.Button();
            this.txtClaimId = new System.Windows.Forms.TextBox();
            this.cmdLoadClaim = new System.Windows.Forms.Button();
            this.cmdSeedData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdDeleteData);
            this.panel2.Controls.Add(this.txtClaimId);
            this.panel2.Controls.Add(this.cmdLoadClaim);
            this.panel2.Controls.Add(this.cmdSeedData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 67);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 67);
            this.panel2.TabIndex = 6;
            // 
            // cmdDeleteData
            // 
            this.cmdDeleteData.Location = new System.Drawing.Point(247, 21);
            this.cmdDeleteData.Name = "cmdDeleteData";
            this.cmdDeleteData.Size = new System.Drawing.Size(102, 24);
            this.cmdDeleteData.TabIndex = 8;
            this.cmdDeleteData.Text = "Delete Data";
            this.cmdDeleteData.UseVisualStyleBackColor = true;
            this.cmdDeleteData.Click += new System.EventHandler(this.cmdDeleteData_Click);
            // 
            // txtClaimId
            // 
            this.txtClaimId.Location = new System.Drawing.Point(522, 23);
            this.txtClaimId.Name = "txtClaimId";
            this.txtClaimId.Size = new System.Drawing.Size(64, 20);
            this.txtClaimId.TabIndex = 7;
            // 
            // cmdLoadClaim
            // 
            this.cmdLoadClaim.Location = new System.Drawing.Point(592, 23);
            this.cmdLoadClaim.Name = "cmdLoadClaim";
            this.cmdLoadClaim.Size = new System.Drawing.Size(112, 24);
            this.cmdLoadClaim.TabIndex = 6;
            this.cmdLoadClaim.Text = "Load Claim";
            this.cmdLoadClaim.UseVisualStyleBackColor = true;
            this.cmdLoadClaim.Click += new System.EventHandler(this.cmdLoadClaim_Click);
            // 
            // cmdSeedData
            // 
            this.cmdSeedData.Location = new System.Drawing.Point(129, 21);
            this.cmdSeedData.Name = "cmdSeedData";
            this.cmdSeedData.Size = new System.Drawing.Size(102, 24);
            this.cmdSeedData.TabIndex = 5;
            this.cmdSeedData.Text = "Seed Data";
            this.cmdSeedData.UseVisualStyleBackColor = true;
            this.cmdSeedData.Click += new System.EventHandler(this.cmdSeedData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 67, 0, 0);
            this.panel1.Size = new System.Drawing.Size(745, 394);
            this.panel1.TabIndex = 5;
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(0, 67);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(745, 327);
            this.txtResults.TabIndex = 3;
            // 
            // frmClaimApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(761, 312);
            this.Name = "frmClaimApp";
            this.Text = "Claim Demo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdDeleteData;
        private System.Windows.Forms.TextBox txtClaimId;
        private System.Windows.Forms.Button cmdLoadClaim;
        private System.Windows.Forms.Button cmdSeedData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResults;
    }
}

