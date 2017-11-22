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
       public DateTime? StatementPeriodFrom { get; set; }
       public DateTime? StatementPeriodThrough { get; set; }
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
       public List<ClaimCondition> ConditionList { get; set; }
       public ClaimDischarge Discharge { get; set; }
       public List<ClaimDocumentControlNumber> DocumentControlNumberList { get; set; }
       public List<ClaimEmployerName> EmployerNameList { get; set; }
       public List<ClaimExternalCauseOfInjury> ExternalCauseOfInjuryList { get; set; }
       public List<ClaimICDDiagnosisCode> ICDDiagnosisCodeList { get; set; }
       public List<ClaimICDProcedureCode> ICDProcedureCodeList { get; set; }
       public List<ClaimInsured> InsuredList { get; set; }
       public List<ClaimOccurence> OccurenceList { get; set; }
       public List<ClaimOccurenceSpan> OccurenceSpanList { get; set; }
       public ClaimPatient Patient { get; set; }
       public List<ClaimPayer> PayerList { get; set; }
       public List<ClaimPhysician> PhysicianList { get; set; }
       public ClaimProvider Provider { get; set; }
       public List<ClaimReasonForVisit> ReasonForVisitList { get; set; }
       public ClaimResponsibleParty ResponsibleParty { get; set; }
       public List<ClaimServiceLine> ServiceLineList { get; set; }
       public List<ClaimTreatmentAuthCode> TreatmentAuthCodeList { get; set; }
       public List<ClaimValueCode> ValueCodeList { get; set; }

       public Claim()
       {
            Admission = new ClaimAdmission();
            ConditionList = new List<ClaimCondition>();
            Discharge = new ClaimDischarge();
            DocumentControlNumberList = new List<ClaimDocumentControlNumber>();
            EmployerNameList = new List<ClaimEmployerName>();
            ExternalCauseOfInjuryList = new List<ClaimExternalCauseOfInjury>();
            ICDDiagnosisCodeList = new List<ClaimICDDiagnosisCode>();
            ICDProcedureCodeList = new List<ClaimICDProcedureCode>();
            InsuredList = new List<ClaimInsured>();
            OccurenceList = new List<ClaimOccurence>();
            OccurenceSpanList = new List<ClaimOccurenceSpan>();
            Patient = new ClaimPatient();
            PayerList = new List<ClaimPayer>();
            PhysicianList = new List<ClaimPhysician>();
            Provider = new ClaimProvider();
            ReasonForVisitList = new List<ClaimReasonForVisit>();
            ResponsibleParty = new ClaimResponsibleParty();
            ServiceLineList = new List<ClaimServiceLine>();
            TreatmentAuthCodeList = new List<ClaimTreatmentAuthCode>();
            ValueCodeList = new List<ClaimValueCode>();
       }

    }
}
