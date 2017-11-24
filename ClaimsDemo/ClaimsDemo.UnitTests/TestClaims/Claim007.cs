using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class Claim007 : Claim
    {
        public Claim007()
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

            PatientControlNumber = "565656";
            MedicalRecordNumber = "5655501";
            TypeOfBill = "0131";
            StatementPeriodFrom = new DateTime(2007, 10, 24);
            StatementPeriodThrough = new DateTime(2007, 10, 24);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Logan Liz",
                StreetAddress = "228 3rd Ave",
                City = "New York",
                State = "NY",
                Zip = "12207",
                BirthDate = new DateTime(1966, 4, 26),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 10, 24),
                Hour = 15,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 18,
                StatusCode = 1
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0250",
                    RevenueDescription = "Pharmacy",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 100.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0258",
                    RevenueDescription = "IV Solutions",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 70.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0270",
                    RevenueDescription = "Med-Sur Supplies",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 45.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0272",
                    RevenueDescription = "Sterile Supply",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 277.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "80101",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 63.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "8010191",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 63.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "36415",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 5.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0360",
                    RevenueDescription = "OR Services",
                    HCPCS = "45385",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 1600.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0370",
                    RevenueDescription = "Anesthesia",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 87.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0410",
                    RevenueDescription = "Respiratory Svc",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 140.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0636",
                    RevenueDescription = "Drug/Detail Code",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 140.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0710",
                    RevenueDescription = "Recovery Room",
                    ServiceDate = new DateTime(2007, 10, 24),
                    ServiceUnits = 1,
                    TotalCharges = 450.00M
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
                    Name = "Logan Liz",
                    PatientsRelationshipTo = "18",
                    UniqueID = "123555666A",
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
                    NPI = "1122334455",
                    QualifierCode = "1G",
                    QualifierNumber = "555566",
                    LastName = "Dean",
                    FirstName = "Glen"
                }
            };
        }
    }
}
