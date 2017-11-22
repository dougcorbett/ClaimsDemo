using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests
{
    [TestClass]
    public class ClaimTests
    {
        [TestMethod]
        public void WhenSavingAValidClaimToSQLServer_ItShouldSaveSuccessfully()
        {
            Claim claim = new Claim();
            claim.MedicalRecordNumber = "123";


        }
    }
}
