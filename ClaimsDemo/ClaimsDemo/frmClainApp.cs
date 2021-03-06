﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ClaimsDemo.DataAccess;
using ClaimsDemo.DataAccess.POCO;
using ClaimsDemo.DataAccess.TestClaims;

namespace ClaimsDemo
{
    public partial class frmClaimApp : Form
    {
        public frmClaimApp()
        {
            InitializeComponent();
        }

        private void cmdSeedData_Click(object sender, EventArgs e)
        {
            SQLClaimRepository repo = new SQLClaimRepository("Server=localhost;Database=Claims;Trusted_Connection=True;");

            repo.InsertClaim(new ClaimFull());
            repo.InsertClaim(new Claim001());
            repo.InsertClaim(new Claim002());
            repo.InsertClaim(new Claim003());
            repo.InsertClaim(new Claim004());
            repo.InsertClaim(new Claim005());
            repo.InsertClaim(new Claim006());
            repo.InsertClaim(new Claim007());
            repo.InsertClaim(new Claim008());
            repo.InsertClaim(new Claim009());
            repo.InsertClaim(new Claim010());
            repo.InsertClaim(new Claim011());
            repo.InsertClaim(new Claim012());

            txtResults.Text = "Database seeded.";

        }

        private void cmdLoadClaim_Click(object sender, EventArgs e)
        {
            SQLClaimRepository repo = new SQLClaimRepository("Server=localhost;Database=Claims;Trusted_Connection=True;");

            int claimId = 0;
            int.TryParse(txtSQLClaimId.Text, out claimId);
            Claim c = repo.GetClaim(claimId);

            if (c == null) { txtResults.Text = "Selected claim was not found."; }
            else { txtResults.Text = JsonConvert.SerializeObject(c, Formatting.Indented); }
        }

        private void cmdDeleteData_Click(object sender, EventArgs e)
        {
            SQLClaimRepository repo = new SQLClaimRepository("Server=localhost;Database=Claims;Trusted_Connection=True;");

            repo.DeleteAllClaims();

            txtResults.Text = "All claims deleted.";
        }

        private void cmdSeedMongo_Click(object sender, EventArgs e)
        {
            MongoClaimRepository repo = new MongoClaimRepository("mongodb://localhost:27017", "ClaimDB");

            repo.InsertClaim(new MClaimFull());
            repo.InsertClaim(new MClaim001());
            repo.InsertClaim(new MClaim002());
            repo.InsertClaim(new MClaim003());
            repo.InsertClaim(new MClaim004());
            repo.InsertClaim(new MClaim005());
            repo.InsertClaim(new MClaim006());
            repo.InsertClaim(new MClaim007());
            repo.InsertClaim(new MClaim008());
            repo.InsertClaim(new MClaim009());
            repo.InsertClaim(new MClaim010());
            repo.InsertClaim(new MClaim011());
            repo.InsertClaim(new MClaim012());

            txtResults.Text = "Mongo Database seeded.";
        }

        private void cmdDeleteMongo_Click(object sender, EventArgs e)
        {
            MongoClaimRepository repo = new MongoClaimRepository("mongodb://localhost:27017", "ClaimDB");

            repo.DropCollection("claims");

        }

        private void cmdLoadMongoClaim_Click(object sender, EventArgs e)
        {
            MongoClaimRepository repo = new MongoClaimRepository("mongodb://localhost:27017", "ClaimDB");

            string claimId = txtMongoClaimId.Text;
            DataAccess.MongoPOCO.Claim c = repo.GetClaim(claimId);

            if (c == null) { txtResults.Text = "Selected claim was not found."; }
            else { txtResults.Text = JsonConvert.SerializeObject(c, Formatting.Indented); }
        }
    }
}
