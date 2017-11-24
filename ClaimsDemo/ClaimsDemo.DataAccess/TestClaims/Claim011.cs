using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.DataAccess.TestClaims
{
    public class Claim011 : Claim
    {
        public Claim011()
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

            PatientControlNumber = "5111111";
            MedicalRecordNumber = "1010555";
            TypeOfBill = "0134";
            StatementPeriodFrom = new DateTime(2007, 11, 3);
            StatementPeriodThrough = new DateTime(2007, 11, 30);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Burns Ted",
                StreetAddress = "1975 Donnelly Street",
                City = "Hyattsville",
                State = "MD",
                Zip = "20702",
                BirthDate = new DateTime(1942, 8, 22),
                Gender = "M",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 9, 2),
                Hour = 11,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 13,
                StatusCode = 1
            };

            OccurenceList = new List<ClaimOccurence>()
            {
                new ClaimOccurence() { Code = "11", Date = new DateTime(2007, 4, 21)},
                new ClaimOccurence() { Code = "29", Date = new DateTime(2007, 4, 21)},
                new ClaimOccurence() { Code = "35", Date = new DateTime(2007, 4, 21)}
            };

            ValueCodeList = new List<ClaimValueCode>()
            {
                new ClaimValueCode() { Code = "50", Amount = 5 }
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97140GP",
                    ServiceDate = new DateTime(2007, 11, 3),
                    ServiceUnits = 1,
                    TotalCharges = 150.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97140GP",
                    ServiceDate = new DateTime(2007, 11, 7),
                    ServiceUnits = 1,
                    TotalCharges = 150.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97140GP",
                    ServiceDate = new DateTime(2007, 11, 10),
                    ServiceUnits = 1,
                    TotalCharges = 150.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97140GP",
                    ServiceDate = new DateTime(2007, 11, 15),
                    ServiceUnits = 1,
                    TotalCharges = 150.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0421",
                    RevenueDescription = "Phys Therp/Visit",
                    HCPCS = "97530GP",
                    ServiceDate = new DateTime(2007, 11, 30),
                    ServiceUnits = 1,
                    TotalCharges = 100.00M
                }
            };

            PayerList = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Medicare",
                        HealthPlanID = "XXX",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "999888";

            InsuredList = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Burns Ted",
                    PatientsRelationshipTo = "18",
                    UniqueID = "510510510A"
                }
            };

            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "3530"},
                new ClaimICDDiagnosisCode() { Code = "V571"}
            };

            AdmittingDiagnosisCode = "3530";

            PhysicianList = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "8787811111",
                    QualifierCode = "1G",
                    QualifierNumber = "X55555",
                    LastName = "Everts",
                    FirstName = "Wendy"
                }
            };
        }
    }
}
