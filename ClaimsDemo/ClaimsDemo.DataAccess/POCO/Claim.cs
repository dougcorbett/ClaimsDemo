using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class Claim
    {
        public int Id { get; set; }
        public string PatientControlNumber { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string TypeOfBill { get; set; }
        public string FederalTaxNumber { get; set; }
        public DateTime StatementPeriodFrom { get; set; }
        public DateTime StatementPeriodThrough { get; set; }
        public string AccidentState { get; set; }
        public string NationalProviderIdentifier { get; set; }
        public string PayerProvidedProviderID { get; set; }
        public string OtherProviderID { get; set; }
        public string PrivatePayerProviderID { get; set; }
        public string ICDVersion { get; set; }
        public string AdmittingDiagnosisCode { get; set; }
        public string PPSCode { get; set; }
        public string Remarks { get; set; }

        public ClaimAdmission Admission { get; set; }
        public List<ClaimCondition> Conditions { get; set; }
        public ClaimDischarge Discharge { get; set; }
        public List<ClaimDocumentControlNumber> DocumentControlNumbers { get; set; }
        public List<ClaimEmployerName> EmployerNames { get; set; }
        public List<ClaimExternalCauseOfInjury> ExternalCausesOfInjury { get; set; }
        public List<ClaimICDDiagnosisCode> ICDDiagnosisCodes { get; set; }
        public List<ClaimICDProcedureCode> ICDProcedureCodes { get; set; }
        public List<ClaimInsured> Insured { get; set; }
        public List<ClaimOccurence> Occurences { get; set; }
        public List<ClaimOccurenceSpan> OccurenceSpans { get; set; }
        public ClaimPatient Patient { get; set; }
        public List<ClaimPayer> Payers { get; set; }
        public List<ClaimPhysician> Physicians { get; set; }
        public ClaimProvider Provider { get; set; }
        public List<ClaimReasonForVisit> ReasonsForVisit { get; set; }
        public ClaimResponsibleParty ResponsibleParty { get; set; }
        public List<ClaimServiceLine> ServiceLines { get; set; }
        public List<ClaimTreatmentAuthCode> TreatmentAuthCodes { get; set; }
        public List<ClaimValueCode> ValueCodes { get; set; }

        public Claim()
        {
            Admission = new ClaimAdmission();
            Conditions = new List<ClaimCondition>();
            Discharge = new ClaimDischarge();
            DocumentControlNumbers = new List<ClaimDocumentControlNumber>();
            EmployerNames = new List<ClaimEmployerName>();
            ExternalCausesOfInjury = new List<ClaimExternalCauseOfInjury>();
            ICDDiagnosisCodes = new List<ClaimICDDiagnosisCode>();
            ICDProcedureCodes = new List<ClaimICDProcedureCode>();
            Insured = new List<ClaimInsured>();
            Occurences = new List<ClaimOccurence>();
            OccurenceSpans = new List<ClaimOccurenceSpan>();
            Patient = new ClaimPatient();
            Payers = new List<ClaimPayer>();
            Physicians = new List<ClaimPhysician>();
            Provider = new ClaimProvider();
            ReasonsForVisit = new List<ClaimReasonForVisit>();
            ResponsibleParty = new ClaimResponsibleParty();
            ServiceLines = new List<ClaimServiceLine>();
            TreatmentAuthCodes = new List<ClaimTreatmentAuthCode>();
            ValueCodes = new List<ClaimValueCode>();
        }
    }
}
