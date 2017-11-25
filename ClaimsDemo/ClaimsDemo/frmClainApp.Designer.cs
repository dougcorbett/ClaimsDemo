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
            this.txtMongoClaimId = new System.Windows.Forms.TextBox();
            this.cmdLoadMongoClaim = new System.Windows.Forms.Button();
            this.cmdDeleteMongo = new System.Windows.Forms.Button();
            this.cmdSeedMongo = new System.Windows.Forms.Button();
            this.cmdDeleteSQL = new System.Windows.Forms.Button();
            this.txtSQLClaimId = new System.Windows.Forms.TextBox();
            this.cmdLoadSQLClaim = new System.Windows.Forms.Button();
            this.cmdSeedSQL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMongoClaimId);
            this.panel2.Controls.Add(this.cmdLoadMongoClaim);
            this.panel2.Controls.Add(this.cmdDeleteMongo);
            this.panel2.Controls.Add(this.cmdSeedMongo);
            this.panel2.Controls.Add(this.cmdDeleteSQL);
            this.panel2.Controls.Add(this.txtSQLClaimId);
            this.panel2.Controls.Add(this.cmdLoadSQLClaim);
            this.panel2.Controls.Add(this.cmdSeedSQL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 100);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 100);
            this.panel2.TabIndex = 6;
            // 
            // txtMongoClaimId
            // 
            this.txtMongoClaimId.Location = new System.Drawing.Point(282, 53);
            this.txtMongoClaimId.Name = "txtMongoClaimId";
            this.txtMongoClaimId.Size = new System.Drawing.Size(64, 20);
            this.txtMongoClaimId.TabIndex = 12;
            // 
            // cmdLoadMongoClaim
            // 
            this.cmdLoadMongoClaim.Location = new System.Drawing.Point(352, 53);
            this.cmdLoadMongoClaim.Name = "cmdLoadMongoClaim";
            this.cmdLoadMongoClaim.Size = new System.Drawing.Size(112, 24);
            this.cmdLoadMongoClaim.TabIndex = 11;
            this.cmdLoadMongoClaim.Text = "Load Mongo Claim";
            this.cmdLoadMongoClaim.UseVisualStyleBackColor = true;
            this.cmdLoadMongoClaim.Click += new System.EventHandler(this.cmdLoadMongoClaim_Click);
            // 
            // cmdDeleteMongo
            // 
            this.cmdDeleteMongo.Location = new System.Drawing.Point(141, 53);
            this.cmdDeleteMongo.Name = "cmdDeleteMongo";
            this.cmdDeleteMongo.Size = new System.Drawing.Size(102, 24);
            this.cmdDeleteMongo.TabIndex = 10;
            this.cmdDeleteMongo.Text = "Delete Mongo";
            this.cmdDeleteMongo.UseVisualStyleBackColor = true;
            this.cmdDeleteMongo.Click += new System.EventHandler(this.cmdDeleteMongo_Click);
            // 
            // cmdSeedMongo
            // 
            this.cmdSeedMongo.Location = new System.Drawing.Point(23, 53);
            this.cmdSeedMongo.Name = "cmdSeedMongo";
            this.cmdSeedMongo.Size = new System.Drawing.Size(102, 24);
            this.cmdSeedMongo.TabIndex = 9;
            this.cmdSeedMongo.Text = "Seed Mongo";
            this.cmdSeedMongo.UseVisualStyleBackColor = true;
            this.cmdSeedMongo.Click += new System.EventHandler(this.cmdSeedMongo_Click);
            // 
            // cmdDeleteSQL
            // 
            this.cmdDeleteSQL.Location = new System.Drawing.Point(141, 23);
            this.cmdDeleteSQL.Name = "cmdDeleteSQL";
            this.cmdDeleteSQL.Size = new System.Drawing.Size(102, 24);
            this.cmdDeleteSQL.TabIndex = 8;
            this.cmdDeleteSQL.Text = "Delete SQL ";
            this.cmdDeleteSQL.UseVisualStyleBackColor = true;
            this.cmdDeleteSQL.Click += new System.EventHandler(this.cmdDeleteData_Click);
            // 
            // txtSQLClaimId
            // 
            this.txtSQLClaimId.Location = new System.Drawing.Point(282, 23);
            this.txtSQLClaimId.Name = "txtSQLClaimId";
            this.txtSQLClaimId.Size = new System.Drawing.Size(64, 20);
            this.txtSQLClaimId.TabIndex = 7;
            // 
            // cmdLoadSQLClaim
            // 
            this.cmdLoadSQLClaim.Location = new System.Drawing.Point(352, 23);
            this.cmdLoadSQLClaim.Name = "cmdLoadSQLClaim";
            this.cmdLoadSQLClaim.Size = new System.Drawing.Size(112, 24);
            this.cmdLoadSQLClaim.TabIndex = 6;
            this.cmdLoadSQLClaim.Text = "Load SQL Claim";
            this.cmdLoadSQLClaim.UseVisualStyleBackColor = true;
            this.cmdLoadSQLClaim.Click += new System.EventHandler(this.cmdLoadClaim_Click);
            // 
            // cmdSeedSQL
            // 
            this.cmdSeedSQL.Location = new System.Drawing.Point(23, 23);
            this.cmdSeedSQL.Name = "cmdSeedSQL";
            this.cmdSeedSQL.Size = new System.Drawing.Size(102, 24);
            this.cmdSeedSQL.TabIndex = 5;
            this.cmdSeedSQL.Text = "Seed SQL";
            this.cmdSeedSQL.UseVisualStyleBackColor = true;
            this.cmdSeedSQL.Click += new System.EventHandler(this.cmdSeedData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panel1.Size = new System.Drawing.Size(745, 394);
            this.panel1.TabIndex = 5;
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(0, 100);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(745, 294);
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
        private System.Windows.Forms.Button cmdDeleteSQL;
        private System.Windows.Forms.TextBox txtSQLClaimId;
        private System.Windows.Forms.Button cmdLoadSQLClaim;
        private System.Windows.Forms.Button cmdSeedSQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button cmdDeleteMongo;
        private System.Windows.Forms.Button cmdSeedMongo;
        private System.Windows.Forms.TextBox txtMongoClaimId;
        private System.Windows.Forms.Button cmdLoadMongoClaim;
    }
}

