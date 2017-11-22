using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaimsDemo.DataAccess.POCO;
using System.Collections.Generic;
using ClaimsDemo.DataAccess;
using ClaimsDemo.UnitTests.TestClaims;

namespace ClaimsDemo.UnitTests
{
    [TestClass]
    public class ClaimTests
    {
        [TestMethod]
        public void WhenSavingAValidClaimToSQLServer_ItShouldSaveSuccessfully()
        {


            // generate patient from data

            // get contract from patient

            // patient test repo

            TestClaimRepository repo = new TestClaimRepository();

            Claim claim = repo.GetClaim(TestClaimsEnum.Claim_001);

            //Claim claim = new Claim001();
            //SQLRepository repo = new SQLRepository();
            //repo.Save(claim);

        }
    }
}
