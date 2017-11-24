using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.UnitTests.TestClaims
{
    public class ClaimFull: Claim
    {
        public ClaimFull()
        {

            PatientControlNumber = "515151";
            MedicalRecordNumber = "998899";
            TypeOfBill = "0111";
            FederalTaxNumber = "12-3456789";
            StatementPeriodFrom = new DateTime(2007, 12, 9);
            StatementPeriodThrough = new DateTime(2007, 12, 12);
            AccidentState = "C";
            NationalProviderIdentifier = "1234512345";
            PayerProvidedProviderID = "0099";
            OtherProviderID = "ABC";
            PrivatePayerProviderID = "0123abc";
            ICDVersion = "9";
            AdmittingDiagnosisCode = "2259";
            PPSCode = "xxxhs";
            Remarks = "Some interesting remmarks";
            
            Admission = new ClaimAdmission()
            {
                StartDate = new DateTime(2007, 12, 09),
                Hour = 8,
                PriorityCode = "3",
                SourceOfReferralCode = "1"
            };

            ConditionList = new List<ClaimCondition>()
            {
                new ClaimCondition() { Code = "gg" }
            };

            Discharge = new ClaimDischarge()
            {
                Hour = 22,
                StatusCode = 1
            };

            DocumentControlNumberList = new List<ClaimDocumentControlNumber>()
            {
                new ClaimDocumentControlNumber() {  DocumentControlNumber = "ed123" }
            };

            EmployerNameList = new List<ClaimEmployerName>()
            {
                new ClaimEmployerName() {   EmployerName = "Mom and pop company" }
            };

            ExternalCauseOfInjuryList = new List<ClaimExternalCauseOfInjury>()
            {
                new ClaimExternalCauseOfInjury() { Code = "s1" }
            };

            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>()
            {
                new ClaimICDDiagnosisCode() { Code = "6178", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6146", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6141", PresentOnAdmissionIndicator = "Y"},
                new ClaimICDDiagnosisCode() { Code = "6206", PresentOnAdmissionIndicator = "Y"}
            };

            ICDProcedureCodeList = new List<ClaimICDProcedureCode>()
            {
                new ClaimICDProcedureCode() { IsPrimary = true, Code = "6564", ProcedureDate = new DateTime(2007, 12, 9) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5459", ProcedureDate = new DateTime(2007, 12, 9) },
                new ClaimICDProcedureCode() { IsPrimary = false, Code = "5759", ProcedureDate = new DateTime(2007, 12, 9) }
            };

            InsuredList = new List<ClaimInsured>()
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

            OccurenceList = new List<ClaimOccurence>()
            {
                new ClaimOccurence() { Code = "23", Date = new DateTime(2007, 3, 12) }
            };

            OccurenceSpanList = new List<ClaimOccurenceSpan>()
            {
                new ClaimOccurenceSpan() { Code = "12", FromDate = new DateTime(2007, 3, 1), ThroughDate = new DateTime(2007, 3, 4) }
            };

            Patient = new ClaimPatient()
            {
                PatientID = "23332",
                Name = "Hill Patricia",
                StreetAddress = "1975 Jaguar Dr",
                City = "Chicago",
                State = "IL",
                Zip = "60600",
                BirthDate = new DateTime(1970, 8, 16),
                Gender = "F",
            };

            PayerList = new List<ClaimPayer>()
            {
                new ClaimPayer()
                {
                    PrecedenceOrder = 1,
                    Name = "Blue Cross",
                    HealthPlanID = "XUP",
                    ReleaseInfoCertIndicator = "Y",
                    AssignmentofBenefitsCertIndicator = "Y",
                    PriorPayments = 12.44M,
                    AmountDue = 3.44M
                }
            };

            PhysicianList = new List<ClaimPhysician>()
            {
                new ClaimPhysician()
                {
                    PhysicianType = "Attending",
                    NPI = "9998887776",
                    QualifierCode = "G2",
                    QualifierNumber = "12312311",
                    LastName = "Martins",
                    FirstName = "Rick"
                }
            };

            Provider = new ClaimProvider()
            {
                Name = "Faith United Hospital",
                StreetAddress = "700 LaCross Ave",
                City = "City",
                State = "XX",
                Zip = "12345",
                Phone = "9892223333",
                PayToList = new List<ClaimProviderPayTo>()
                {
                    new ClaimProviderPayTo() {
                        Name = "Billing Office",
                        StreetAddress = "444 Oak Rd.",
                        City = "Ozarks",
                        State = "MA",
                        Zip = "43221"
                    }
                }
            };

            ReasonForVisitList = new List<ClaimReasonForVisit>()
            {
                new ClaimReasonForVisit() { Code = "CW" }
            };

            ResponsibleParty = new ClaimResponsibleParty()
            {
                Name = "Tom Hanks",
                StreetAddress = "123 Anyplace Drive",
                City = "New York",
                State = "NY",
                Zip = "29381"
            };

            ServiceLineList = new List<ClaimServiceLine>()
            {
                new ClaimServiceLine()
                {
                    RevenueCode = "0120",
                    RevenueDescription = "Room-Board/Semi",
                    ServiceDate = new DateTime(2007, 4, 4),
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

            TreatmentAuthCodeList = new List<ClaimTreatmentAuthCode>()
            {
                new ClaimTreatmentAuthCode() { Code = "12312344" }
            };

            ValueCodeList = new List<ClaimValueCode>() {
                new ClaimValueCode() {  Amount = 3, Code = "30"}
            };
        }
    }
}
