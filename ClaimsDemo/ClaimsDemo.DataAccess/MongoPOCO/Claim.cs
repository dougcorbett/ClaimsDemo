using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class Claim
    {
        public ObjectId Id { get; set; }

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
        public String[] Conditions { get; set; }
        public ClaimDischarge Discharge { get; set; }
        public String[] DocumentControlNumbers { get; set; }
        public String[] EmployerNames { get; set; }
        public String[] ExternalCausesOfInjury { get; set; }
        public List<ClaimICDDiagnosisCode> ICDDiagnosisCodes { get; set; }
        public List<ClaimICDProcedureCode> ICDProcedureCodes { get; set; }
        public List<ClaimInsured> Insureds { get; set; }
        public List<ClaimOccurence> Occurences { get; set; }
        public List<ClaimOccurenceSpan> OccurenceSpans { get; set; }
        public ClaimPatient Patient { get; set; }
        public List<ClaimPayer> Payers { get; set; }
        public List<ClaimPhysician> Physicians { get; set; }
        public ClaimProvider Provider { get; set; }
        public String[] ReasonsForVisit { get; set; }
        public ClaimResponsibleParty ResponsibleParty { get; set; }
        public List<ClaimServiceLine> ServiceLines { get; set; }
        public String[] TreatmentAuthCodes { get; set; }
        public List<ClaimValueCode> ValueCodes { get; set; }
    }
}
