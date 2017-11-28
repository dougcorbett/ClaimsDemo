using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.MongoPOCO;

namespace ClaimsDemo.DataAccess.TestClaims
{
    public class MClaim012 : Claim
    {
        public MClaim012()
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

            PatientControlNumber = "5121212";
            MedicalRecordNumber = "121212";
            TypeOfBill = "0132";
            StatementPeriodFrom = new DateTime(2007, 5, 2);
            StatementPeriodThrough = new DateTime(2007, 5, 30);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Popa Tom",
                StreetAddress = "1977 Hyde Drive",
                City = "Nashville",
                State = "TN",
                Zip = "37205",
                BirthDate = new DateTime(1981, 5, 2),
                Gender = "M",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 5, 2),
                Hour = 11,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 13,
                StatusCode = 1
            };

            Occurences = new List<ClaimOccurence>()
            {
                new ClaimOccurence() { Code = "11", Date = new DateTime(2007, 4, 15)},
                new ClaimOccurence() { Code = "29", Date = new DateTime(2007, 5, 2)},
                new ClaimOccurence() { Code = "35", Date = new DateTime(2007, 5, 2)}
            };

            ValueCodes = new List<ClaimValueCode>()
            {
                new ClaimValueCode() { Code = "50", Amount = 3 }
            };

            ServiceLines = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    ServiceUnits = 3,
                    TotalCharges = 450.00M
                }
            };

            Payers = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Blue Cross",
                        HealthPlanID = "ABA",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "00099";

            Insureds = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Popa Tom",
                    PatientsRelationshipTo = "18",
                    UniqueID = "AAA512512512",
                    GroupName = "Gena Fashions",
                    GroupNumber = "1111"
                }
            };

            EmployerNames = new string[] { "Culver Ind" };

            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "3530"},
                new ClaimICDDiagnosisCode() { Code = "V571"}
            };

            AdmittingDiagnosisCode = "3530";

            Physicians = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "7776655544",
                    QualifierCode = "G2",
                    QualifierNumber = "FX9999",
                    LastName = "Sharp",
                    FirstName = "Courtney"
                }
            };
        }
    }
}
