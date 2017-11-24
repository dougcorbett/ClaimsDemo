using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class Claim008 : Claim
    {
        public Claim008()
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

            PatientControlNumber = "575757";
            MedicalRecordNumber = "5777777";
            TypeOfBill = "0131";
            StatementPeriodFrom = new DateTime(2007, 5, 5);
            StatementPeriodThrough = new DateTime(2007, 5, 5);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Robinson Rick",
                StreetAddress = "1101 Leo Sq",
                City = "Ft Lauderdale",
                State = "FL",
                Zip = "06165",
                BirthDate = new DateTime(1940, 6, 28),
                Gender = "M",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 5, 5),
                Hour = 7,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 20,
                StatusCode = 1
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "80101",
                    ServiceDate = new DateTime(2007, 5, 5),
                    ServiceUnits = 1,
                    TotalCharges = 60.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0311",
                    RevenueDescription = "Cytology Tests",
                    HCPCS = "88305",
                    ServiceDate = new DateTime(2007, 5, 5),
                    ServiceUnits = 1,
                    TotalCharges = 100.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0750",
                    RevenueDescription = "Gastro-Intstl Svc",
                    HCPCS = "45385",
                    ServiceDate = new DateTime(2007, 5, 5),
                    ServiceUnits = 1,
                    TotalCharges = 975.00M
                }
            };

            PayerList = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Cigna",
                        HealthPlanID = "212",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "5555";

            InsuredList = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Robinson Rick",
                    PatientsRelationshipTo = "18",
                    UniqueID = "555777555",
                    GroupName = "Rudolph Inc",
                    GroupNumber = "77799"
                }
            };

            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "2113"}
            };

            AdmittingDiagnosisCode = "2113";

            PhysicianList = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "6661266612",
                    QualifierCode = "G2",
                    QualifierNumber = "G1555777",
                    LastName = "Hill",
                    FirstName = "Dean"
                },
                new ClaimPhysician()
                {
                    PhysicianType = "Operating",
                    NPI = "6661266612",
                    QualifierCode = "G2",
                    QualifierNumber = "G1555777",
                    LastName = "Hill",
                    FirstName = "Dean"
                }
            };
        }
    }
}
