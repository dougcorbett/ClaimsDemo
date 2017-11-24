using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.DataAccess.TestClaims
{
    public class Claim002 : Claim
    {
        public Claim002()
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

            PatientControlNumber = "525252";
            MedicalRecordNumber = "555999";
            TypeOfBill = "0131";
            StatementPeriodFrom = new DateTime(2007, 1, 19);
            StatementPeriodThrough = new DateTime(2007, 1, 20);
            FederalTaxNumber = "12-3456789";

            Patient = new ClaimPatient()
            {
                Name = "Strong Wendy",
                StreetAddress = "2014 Annie St",
                City = "Detroit",
                State = "MI",
                Zip = "48234",
                BirthDate = new DateTime(1951, 7, 24),
                Gender = "F",
            };

            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 1, 19),
                Hour = 22,
                PriorityCode = "2",
                SourceOfReferralCode = "1"
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 4,
                StatusCode = 1
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "80101",
                    ServiceDate = new DateTime(2007, 1, 19),
                    ServiceUnits = 1,
                    TotalCharges = 65.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "82055",
                    ServiceDate = new DateTime(2007, 1, 19),
                    ServiceUnits = 1,
                    TotalCharges = 60.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0300",
                    RevenueDescription = "Lab",
                    HCPCS = "86001",
                    ServiceDate = new DateTime(2007, 1, 19),
                    ServiceUnits = 1,
                    TotalCharges = 40.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0450",
                    RevenueDescription = "Emerg Room",
                    HCPCS = "9928525",
                    TotalCharges = 1269.00M
                },
                new ClaimServiceLine()
                {
                    RevenueCode = "0637",
                    RevenueDescription = "Drug/Self Admin",
                    TotalCharges = 5.12M,
                    NonCoveredCharges = 5.12M
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
                    Name = "Strong Wendy",
                    PatientsRelationshipTo = "18",
                    UniqueID = "333222555"
                }
            };

            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "311"},
                new ClaimICDDiagnosisCode() { Code = "3008"},
                new ClaimICDDiagnosisCode() { Code = "30500"},
                new ClaimICDDiagnosisCode() { Code = "4019"}
            };

            AdmittingDiagnosisCode = "3008";

            PhysicianList = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "111122222",
                    QualifierCode = "1G",
                    QualifierNumber = "UP1234",
                    LastName = "Lucido",
                    FirstName = "Mary Jo"
                }
            };
        }
    }
}
