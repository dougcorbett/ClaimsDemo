using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class Claim006 : Claim
    {
        public Claim006()
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

            PatientControlNumber = "585858";
            MedicalRecordNumber = "555888";
            TypeOfBill = "0131";
            StatementPeriodFrom = new DateTime(2007, 8, 7);
            StatementPeriodThrough = new DateTime(2007, 8, 7);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Schmidt George",
                StreetAddress = "1051 Todd Drive",
                City = "Denver",
                State = "CO",
                Zip = "80120",
                BirthDate = new DateTime(1951, 2, 28),
                Gender = "M",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 8, 7),
                Hour = 5,
                PriorityCode = "1",
                SourceOfReferralCode = "7"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 24,
                StatusCode = 1
            };

            ValueCodeList = new List<ClaimValueCode>() {
                new ClaimValueCode() {  Amount = 3, Code = "80"}
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0250",
                    RevenueDescription = "Pharmacy",
                    ServiceDate = new DateTime(2007, 8, 7),
                    ServiceUnits = 1,
                    TotalCharges = 188.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "81003",
                    ServiceUnits = 1,
                    TotalCharges = 40.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "83874",
                    ServiceUnits = 1,
                    TotalCharges = 45.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "84484",
                    ServiceUnits = 1,
                    TotalCharges = 56.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "8387491",
                    ServiceUnits = 1,
                    TotalCharges = 45.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0320",
                    RevenueDescription = "DX X-Ray",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "74020",
                    ServiceUnits = 1,
                    TotalCharges = 123.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0450",
                    RevenueDescription = "Emerg Room",
                    ServiceDate = new DateTime(2007, 8, 7),
                    HCPCS = "9929125",
                    ServiceUnits = 1,
                    TotalCharges = 1982.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0637",
                    RevenueDescription = "Drug/Self Admin",
                    ServiceDate = new DateTime(2007, 8, 7),
                    ServiceUnits = 1,
                    TotalCharges = 5.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0730",
                    RevenueDescription = "EKG/ECG",
                    HCPCS = "93005",
                    ServiceDate = new DateTime(2007, 8, 7),
                    ServiceUnits = 1,
                    TotalCharges = 110.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0730",
                    RevenueDescription = "EKG/ECG",
                    HCPCS = "9300576",
                    ServiceDate = new DateTime(2007, 8, 7),
                    ServiceUnits = 1,
                    TotalCharges = 110.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0762",
                    RevenueDescription = "Observation Rm",
                    ServiceDate = new DateTime(2007, 8, 7),
                    ServiceUnits = 17,
                    TotalCharges = 600.00M
                }
            };

            PayerList = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                        Name = "Aetna",
                        HealthPlanID = "XYP",
                        ReleaseInfoCertIndicator = "Y",
                        AssignmentofBenefitsCertIndicator = "Y"
                }
            };

            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "555999";

            InsuredList = new List<ClaimInsured>()
            {
                new ClaimInsured()
                {
                    Name = "Schmidt George",
                    PatientsRelationshipTo = "18",
                    UniqueID = "555888555",
                    GroupName = "Mandy Stocking",
                    GroupNumber = "5555"
                }
            };

            EmployerNameList = new List<ClaimEmployerName>() { new ClaimEmployerName() { EmployerName = "Harding Mandy Stockings" } };


            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "78906"},
                new ClaimICDDiagnosisCode() { Code = "78650"},
                new ClaimICDDiagnosisCode() { Code = "78702"},
                new ClaimICDDiagnosisCode() { Code = "4019"}
            };

            AdmittingDiagnosisCode = "78906";

            ICDProcedureCodeList = new List<ClaimICDProcedureCode>()
            {
                new ClaimICDProcedureCode() { IsPrimary = true, Code = "6564", ProcedureDate = new DateTime(2007, 8, 17) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5459", ProcedureDate = new DateTime(2007, 8, 17) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5759", ProcedureDate = new DateTime(2007, 8, 17) }
            };

            PhysicianList = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "44412255512",
                    QualifierCode = "G2",
                    QualifierNumber = "AHA9988",
                    LastName = "Holzworth",
                    FirstName = "Wendell"
                }
            };
        }
    }
}
