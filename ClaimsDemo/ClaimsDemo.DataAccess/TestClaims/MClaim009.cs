using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.MongoPOCO;

namespace ClaimsDemo.DataAccess.TestClaims
{
    public class MClaim009 : Claim
    {
        public MClaim009()
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

            PatientControlNumber = "595959";
            MedicalRecordNumber = "999555";
            TypeOfBill = "0133";
            StatementPeriodFrom = new DateTime(2007, 5, 5);
            StatementPeriodThrough = new DateTime(2007, 5, 25);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Fracture Virginia",
                StreetAddress = "801 Kensington Rd",
                City = "Chicago",
                State = "IL",
                Zip = "60600",
                BirthDate = new DateTime(1952, 12, 23),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 4, 21),
                Hour = 11,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 13,
                StatusCode = 1
            };

            ServiceLines = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 5),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 7),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 11),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 15),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 20),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 22),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97110GP",
                    ServiceDate = new DateTime(2007, 5, 25),
                    ServiceUnits = 1,
                    TotalCharges = 85.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0431",
                    RevenueDescription = "Occup Therp/Visit",
                    HCPCS = "97010GO",
                    ServiceDate = new DateTime(2007, 5, 7),
                    ServiceUnits = 1,
                    TotalCharges = 90.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0431",
                    RevenueDescription = "Occup Therp/Visit",
                    HCPCS = "97010GO",
                    ServiceDate = new DateTime(2007, 5, 11),
                    ServiceUnits = 1,
                    TotalCharges = 90.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0431",
                    RevenueDescription = "Occup Therp/Visit",
                    HCPCS = "97010GO",
                    ServiceDate = new DateTime(2007, 5, 15),
                    ServiceUnits = 1,
                    TotalCharges = 90.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0431",
                    RevenueDescription = "Occup Therp/Visit",
                    HCPCS = "97010GO",
                    ServiceDate = new DateTime(2007, 5, 20),
                    ServiceUnits = 1,
                    TotalCharges = 90.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0431",
                    RevenueDescription = "Occup Therp/Visit",
                    HCPCS = "97010GO",
                    ServiceDate = new DateTime(2007, 5, 22),
                    ServiceUnits = 1,
                    TotalCharges = 90.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0434",
                    RevenueDescription = "Occup Therp/Eval",
                    HCPCS = "97003GO",
                    ServiceDate = new DateTime(2007, 5, 7),
                    ServiceUnits = 1,
                    TotalCharges = 150.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0441",
                    RevenueDescription = "Speech Therp/Visit",
                    HCPCS = "92507GN",
                    ServiceDate = new DateTime(2007, 5, 7),
                    ServiceUnits = 1,
                    TotalCharges = 75.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0441",
                    RevenueDescription = "Speech Therp/Visit",
                    HCPCS = "92507GN",
                    ServiceDate = new DateTime(2007, 5, 11),
                    ServiceUnits = 1,
                    TotalCharges = 75.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0441",
                    RevenueDescription = "Speech Therp/Visit",
                    HCPCS = "92507GN",
                    ServiceDate = new DateTime(2007, 5, 15),
                    ServiceUnits = 1,
                    TotalCharges = 75.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0441",
                    RevenueDescription = "Speech Therp/Visit",
                    HCPCS = "92507GN",
                    ServiceDate = new DateTime(2007, 5, 20),
                    ServiceUnits = 1,
                    TotalCharges = 75.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0444",
                    RevenueDescription = "Speech Therp/Eval",
                    HCPCS = "92506GN",
                    ServiceDate = new DateTime(2007, 5, 5),
                    ServiceUnits = 1,
                    TotalCharges = 160.00M
                }

            };

            Payers = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Medicare",
                        HealthPlanID = "XXX",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                },
                new ClaimPayer()
                {
                        Name = "Cigna",
                        HealthPlanID = "212",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "99888";
            OtherProviderID = "55555";

            Insureds = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Fracture Virginia",
                    PatientsRelationshipTo = "18",
                    UniqueID = "555999555A",
                    GroupName = "Denny Mfg",
                    GroupNumber = "98765"
                },
                new ClaimInsured()
                {
                    Name = "Fracture Virginia",
                    PatientsRelationshipTo = "18",
                    UniqueID = "33222333"
                }
            };

            EmployerNames = new string[] { "Jenny Trafalet Sweets" };

            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "7197"}
            };

            AdmittingDiagnosisCode = "7197";

            Physicians = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "1212156565",
                    QualifierCode = "1G",
                    QualifierNumber = "X99999",
                    LastName = "Tomei",
                    FirstName = "Deb"
                }
            };
        }
    }
}
