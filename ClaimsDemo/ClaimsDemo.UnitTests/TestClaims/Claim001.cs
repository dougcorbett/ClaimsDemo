using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class Claim001: Claim
    {
        public Claim001()
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

            PatientControlNumber = "515151";
            MedicalRecordNumber = "998899";
            TypeOfBill = "0111";
            StatementPeriodFrom = new DateTime(2007, 12, 9);
            StatementPeriodThrough = new DateTime(2007, 12, 12);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Hill Patricia",
                StreetAddress = "1975 Jaguar Dr",
                City = "Chicago",
                State = "IL",
                Zip = "60600",
                BirthDate = new DateTime(1970, 8, 16),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 12, 09),
                Hour = 8,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 22,
                StatusCode = 1
            };

            ValueCodes = new List<ClaimValueCode>() {
                new ClaimValueCode() {  Amount = 3, Code = "30"}
            };

            ServiceLines = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0120",
                    RevenueDescription = "Room-Board/Semi",
                    HCPCS = "40000",
                    ServiceUnits = 3,
                    TotalCharges = 1200.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0250",
                    RevenueDescription = "Pharmacy",
                    HCPCS = "40000",
                    ServiceUnits = 3,
                    TotalCharges = 1200.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0120",
                    RevenueDescription = "Room-Board/Semi",
                    ServiceUnits = 1,
                    TotalCharges = 450.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0258",
                    RevenueDescription = "IV Solutions",
                    ServiceUnits = 1,
                    TotalCharges = 175.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0270",
                    RevenueDescription = "Med-Sur Supplies",
                    ServiceUnits = 1,
                    TotalCharges = 300.00M
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
                    RevenueCode = "0311",
                    RevenueDescription = "Cytology Tests",
                    ServiceUnits = 1,
                    TotalCharges = 50.00M
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
                    TotalCharges = 250.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0450",
                    RevenueDescription = "Emerg Room",
                    ServiceUnits = 1,
                    TotalCharges = 469.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0710",
                    RevenueDescription = "Recovery Room",
                    ServiceUnits = 1,
                    TotalCharges = 300.00M
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
            PayerProvidedProviderID = "0099";

            Insured = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Hill Patricia",
                    PatientsRelationshipTo = "18",
                    UniqueID = "BBB999888000",
                    GroupName = "Rudolph Inc",
                    GroupNumber = "77799"
                }
            };

            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "6178", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6146", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6141", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6206", PresentOnAdmissionIndicator = "Y"}
            };

            AdmittingDiagnosisCode = "2259";

            ICDProcedureCodes = new List<ClaimICDProcedureCode>()
            {
                new ClaimICDProcedureCode() { IsPrimary = true, Code = "6564", ProcedureDate = new DateTime(2007, 12, 9) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5459", ProcedureDate = new DateTime(2007, 12, 9) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5759", ProcedureDate = new DateTime(2007, 12, 9) }
            };

            Physicians = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    NPI = "9998887776",
                    QualifierCode = "G2",
                    QualifierNumber = "12312311",
                    LastName = "Martins",
                    FirstName = "Rick"
                }
            };
        }
    }
}
