using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.MongoPOCO;

namespace ClaimsDemo.DataAccess.TestClaims
{
    public class MClaim003 : Claim
    {
        public MClaim003()
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

            PatientControlNumber = "535353";
            MedicalRecordNumber = "998899";
            TypeOfBill = "0111";
            StatementPeriodFrom = new DateTime(2007, 8, 16);
            StatementPeriodThrough = new DateTime(2007, 8, 19);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Blake Suzanne",
                StreetAddress = "10 Johnson Blvd",
                City = "San Francisco",
                State = "CA",
                Zip = "94131",
                BirthDate = new DateTime(1979, 5, 23),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 8, 16),
                Hour = 8,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 10,
                StatusCode = 1
            };

            ValueCodes = new List<ClaimValueCode>() {
                new ClaimValueCode() {  Amount = 3, Code = "80"}
            };

            ServiceLines = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0122",
                    RevenueDescription = "OB/Semi-Pvt",
                    HCPCS = "60000",
                    ServiceUnits = 3,
                    TotalCharges = 1800.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0250",
                    RevenueDescription = "Pharmacy",
                    ServiceUnits = 1,
                    TotalCharges = 200.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0258",
                    RevenueDescription = "IV Solutions",
                    ServiceUnits = 1,
                    TotalCharges = 56.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0270",
                    RevenueDescription = "Med-Sur Supplies",
                    ServiceUnits = 1,
                    TotalCharges = 500.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceUnits = 1,
                    TotalCharges = 22.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0305",
                    RevenueDescription = "Hematology Tests",
                    ServiceUnits = 1,
                    TotalCharges = 60.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0360",
                    RevenueDescription = "OR Services",
                    ServiceUnits = 1,
                    TotalCharges = 2528.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0370",
                    RevenueDescription = "Anesthesia",
                    ServiceUnits = 1,
                    TotalCharges = 200.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0410",
                    RevenueDescription = "Respiratory Svc",
                    ServiceUnits = 1,
                    TotalCharges = 500.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0710",
                    RevenueDescription = "Recovery Room",
                    ServiceUnits = 1,
                    TotalCharges = 500.00M
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

            Insureds = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Blake Suzanne",
                    PatientsRelationshipTo = "18",
                    UniqueID = "BBB999888000",
                    GroupName = "Lajko Enterpri",
                    GroupNumber = "55555"
                }
            };

            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "65421"},
                new ClaimICDDiagnosisCode() { Code = "V270"},
                new ClaimICDDiagnosisCode() { Code = "2449"},
                new ClaimICDDiagnosisCode() { Code = "V270"},
                new ClaimICDDiagnosisCode() { Code = "V1259"},
                new ClaimICDDiagnosisCode() { Code = "V1072"}
            };

            AdmittingDiagnosisCode = "65421";

            ICDProcedureCodes = new List<ClaimICDProcedureCode>()
            {
                new ClaimICDProcedureCode() { IsPrimary = true, Code = "6564", ProcedureDate = new DateTime(2007, 8, 17) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5459", ProcedureDate = new DateTime(2007, 8, 17) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5759", ProcedureDate = new DateTime(2007, 8, 17) }
            };

            Physicians = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "3333344444",
                    QualifierCode = "G2",
                    QualifierNumber = "535399999",
                    LastName = "Hill",
                    FirstName = "Jill"
                }
            };
        }
    }
}
