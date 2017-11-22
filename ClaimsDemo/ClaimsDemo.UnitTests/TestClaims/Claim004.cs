using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class Claim004 : Claim
    {
        public Claim004()
        {
            Provider = new ClaimProvider()
            {
                Name = "Faith United Hospital",
                StreetAddress = "700 LaCross Ave",
                City = "City",
                State = "XX",
                Zip = "12345",
                Phone = "9892223333"
            };

            PatientControlNumber = "545454";
            MedicalRecordNumber = "555444";
            TypeOfBill = "0111";
            StatementPeriodFrom = new DateTime(2007, 8, 17);
            StatementPeriodThrough = new DateTime(2007, 8, 17);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Green Shirley",
                StreetAddress = "10 Johnson Blvd",
                City = "San Francisco",
                State = "CA",
                Zip = "94131",
                BirthDate = new DateTime(2007, 8, 17),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 8, 17),
                Hour = 1,
                PriorityCode = "4",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 15,
                StatusCode = 1
            };

            ValueCodes = new List<ClaimValueCode>() {
                new ClaimValueCode() {  Amount = 2, Code = "80"}
            };

            ServiceLines = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0170",
                    RevenueDescription = "Nursery",
                    HCPCS = "35000",
                    ServiceUnits = 2,
                    TotalCharges = 700.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0250",
                    RevenueDescription = "Pharmacy",
                    ServiceUnits = 1,
                    TotalCharges = 44.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceUnits = 1,
                    TotalCharges = 250.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0471",
                    RevenueDescription = "Audiology/Dx",
                    ServiceUnits = 1,
                    TotalCharges = 160.00M
                }
            };

            Payers = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Blue Cross",
                        HealthPlanID = "XUP",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "00099";

            Insured = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Green Shirley",
                    PatientsRelationshipTo = "19",
                    UniqueID = "BBB999888000",
                    GroupName = "Lakjo Enterpri",
                    GroupNumber = "77799"
                }
            };

            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "V3000"}
            };

            AdmittingDiagnosisCode = "V3000";

            Physicians = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    NPI = "5551166611",
                    QualifierNumber = "5499777",
                    LastName = "Copeland",
                    FirstName = "Heather"
                }
            };
        }
    }
}
