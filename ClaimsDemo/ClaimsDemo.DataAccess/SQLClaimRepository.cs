﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClaimsDemo.DataAccess.POCO;
using ClaimsDemo.DataAccess.Validators;
using Dapper;

namespace ClaimsDemo.DataAccess
{
    public class SQLClaimRepository
    {
        private string _connString;
        private SqlConnection _conn = null;
        private bool _connWasPassedIn = false;

        private SQLClaimRepository() { }

        public SQLClaimRepository(string connString) { _connString = connString; }

        public SQLClaimRepository(SqlConnection conn)
        {
            _conn = conn;
            _connWasPassedIn = true;
        }

        public int? InsertClaim(Claim c)
        {
            SqlConnection conn = GetConnection();

            int? result = InsertClaim(conn, c);

            if (!_connWasPassedIn) conn.Dispose();

            return result;
        }

        private int? InsertClaim(SqlConnection conn, Claim c)
        {
            int? result = null;

            if (ClaimValidator.IsValidForCreation(c))
            {

                string sql = @" INSERT INTO Claim ( 
                                          PatientControlNumber,
                                          MedicalRecordNumber,
                                          TypeOfBill,
                                          FederalTaxNumber,
                                          StatementPeriodFrom,
                                          StatementPeriodThrough,
                                          AccidentState,
                                          NationalProviderIdentifier,
                                          PayerProvidedProviderID,
                                          OtherProviderID,
                                          PrivatePayerProviderID,
                                          ICDVersion,
                                          AdmittingDiagnosisCode,
                                          PPSCode,
                                          Remarks)
                                VALUES  ( @PatientControlNumber,
                                          @MedicalRecordNumber,
                                          @TypeOfBill,
                                          @FederalTaxNumber,
                                          @StatementPeriodFrom,
                                          @StatementPeriodThrough,
                                          @AccidentState,
                                          @NationalProviderIdentifier,
                                          @PayerProvidedProviderID,
                                          @OtherProviderID,
                                          @PrivatePayerProviderID,
                                          @ICDVersion,
                                          @AdmittingDiagnosisCode,
                                          @PPSCode,
                                          @Remarks);
                                SELECT CAST(SCOPE_IDENTITY() as int)";

                result = conn.Query<int>(sql, new
                {
                    PatientControlNumber = c.PatientControlNumber,
                    MedicalRecordNumber = c.MedicalRecordNumber,
                    TypeOfBill = c.TypeOfBill,
                    FederalTaxNumber = c.FederalTaxNumber,
                    StatementPeriodFrom = c.StatementPeriodFrom,
                    StatementPeriodThrough = c.StatementPeriodThrough,
                    AccidentState = c.AccidentState,
                    NationalProviderIdentifier = c.NationalProviderIdentifier,
                    PayerProvidedProviderID = c.PayerProvidedProviderID,
                    OtherProviderID = c.OtherProviderID,
                    PrivatePayerProviderID = c.PrivatePayerProviderID,
                    ICDVersion = c.ICDVersion,
                    AdmittingDiagnosisCode = c.AdmittingDiagnosisCode,
                    PPSCode = c.PPSCode,
                    Remarks = c.Remarks
                }).Single();
            }
            
            if (c.Admission != null) {
                c.Admission.ClaimId = (int)result;
                InsertAdmission(conn, c.Admission);
            }

            if (c.ConditionList.Count() > 0)
            {
                for (int i = 0; i < c.ConditionList.Count(); i++)
                {
                    c.ConditionList[i].ClaimId = (int)result;
                    InsertCondition(conn, c.ConditionList[i]);
                }
            }

            if (c.Discharge != null)
            {
                c.Discharge.ClaimId = (int)result;
                InsertDischarge(conn, c.Discharge);
            }

            if (c.DocumentControlNumberList.Count() > 0)
            {
                for (int i = 0; i < c.DocumentControlNumberList.Count(); i++)
                {
                    c.DocumentControlNumberList[i].ClaimId = (int)result;
                    InsertDocumentControlNumber(conn, c.DocumentControlNumberList[i]);
                }
            }

            if (c.EmployerNameList.Count() > 0)
            {
                for (int i = 0; i < c.EmployerNameList.Count(); i++)
                {
                    c.EmployerNameList[i].ClaimId = (int)result;
                    InsertEmployerName(conn, c.EmployerNameList[i]);
                }
            }

            if (c.ExternalCauseOfInjuryList.Count() > 0)
            {
                for (int i = 0; i < c.ExternalCauseOfInjuryList.Count(); i++)
                {
                    c.ExternalCauseOfInjuryList[i].ClaimId = (int)result;
                    InsertExternalCauseOfInjury(conn, c.ExternalCauseOfInjuryList[i]);
                }
            }

            if (c.ICDDiagnosisCodeList.Count() > 0)
            {
                for (int i = 0; i < c.ICDDiagnosisCodeList.Count(); i++)
                {
                    c.ICDDiagnosisCodeList[i].ClaimId = (int)result;
                    InsertICDDiagnosisCode(conn, c.ICDDiagnosisCodeList[i]);
                }
            }

            if (c.ICDProcedureCodeList.Count() > 0)
            {
                for (int i = 0; i < c.ICDProcedureCodeList.Count(); i++)
                {
                    c.ICDProcedureCodeList[i].ClaimId = (int)result;
                    InsertICDProcedureCode(conn, c.ICDProcedureCodeList[i]);
                }
            }

            if (c.InsuredList.Count() > 0)
            {
                for (int i = 0; i < c.InsuredList.Count(); i++)
                {
                    c.InsuredList[i].ClaimId = (int)result;
                    InsertInsured(conn, c.InsuredList[i]);
                }
            }

            if (c.OccurenceList.Count() > 0)
            {
                for (int i = 0; i < c.OccurenceList.Count(); i++)
                {
                    c.OccurenceList[i].ClaimId = (int)result;
                    InsertOccurence(conn, c.OccurenceList[i]);
                }
            }

            if (c.OccurenceSpanList.Count() > 0)
            {
                for (int i = 0; i < c.OccurenceSpanList.Count(); i++)
                {
                    c.OccurenceSpanList[i].ClaimId = (int)result;
                    InsertOccurenceSpan(conn, c.OccurenceSpanList[i]);
                }
            }

            if (c.Patient != null)
            {
                c.Patient.ClaimId = (int)result;
                InsertPatient(conn, c.Patient);
            }

            if (c.PayerList.Count() > 0)
            {
                for (int i = 0; i < c.PayerList.Count(); i++)
                {
                    c.PayerList[i].ClaimId = (int)result;
                    InsertPayer(conn, c.PayerList[i]);
                }
            }

            if (c.PhysicianList.Count() > 0)
            {
                for (int i = 0; i < c.PhysicianList.Count(); i++)
                {
                    c.PhysicianList[i].ClaimId = (int)result;
                    InsertPhysician(conn, c.PhysicianList[i]);
                }
            }

            if (c.Provider != null)
            {
                c.Provider.ClaimId = (int)result;
                InsertProvider(conn, c.Provider);
            }

            if (c.ReasonForVisitList.Count() > 0)
            {
                for (int i = 0; i < c.ReasonForVisitList.Count(); i++)
                {
                    c.ReasonForVisitList[i].ClaimId = (int)result;
                    InsertReasonForVisit(conn, c.ReasonForVisitList[i]);
                }
            }

            if (c.ResponsibleParty != null)
            {
                c.ResponsibleParty.ClaimId = (int)result;
                InsertResponsibleParty(conn, c.ResponsibleParty);
            }

            if (c.ServiceLineList.Count() > 0)
            {
                for (int i = 0; i < c.ServiceLineList.Count(); i++)
                {
                    c.ServiceLineList[i].ClaimId = (int)result;
                    InsertServiceLine(conn, c.ServiceLineList[i]);
                }
            }

            if (c.TreatmentAuthCodeList.Count() > 0)
            {
                for (int i = 0; i < c.TreatmentAuthCodeList.Count(); i++)
                {
                    c.TreatmentAuthCodeList[i].ClaimId = (int)result;
                    InsertTreatmentAuthCode(conn, c.TreatmentAuthCodeList[i]);
                }
            }

            if (c.ValueCodeList.Count() > 0)
            {
                for (int i = 0; i < c.ValueCodeList.Count(); i++)
                {
                    c.ValueCodeList[i].ClaimId = (int)result;
                    InsertValueCode(conn, c.ValueCodeList[i]);
                }
            }









            return result;
        }

        private int? InsertAdmission(SqlConnection conn, ClaimAdmission v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimAdmission ( 
                                     ClaimId,
                                     StartDate,
                                     Hour,
                                     PriorityCode,
                                     SourceOfReferralCode)
                            VALUES ( @ClaimId,
                                     @StartDate,
                                     @Hour,
                                     @PriorityCode,
                                     @SourceOfReferralCode);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                StartDate = v.StartDate,
                Hour = v.Hour,
                PriorityCode = v.PriorityCode,
                SourceOfReferralCode = v.SourceOfReferralCode
            }).Single();

            return result;
        }

        private int? InsertCondition(SqlConnection conn, ClaimCondition v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimCondition ( 
                                     ClaimId,
                                     Code)
                            VALUES ( @ClaimId,
                                     @Code);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code
            }).Single();

            return result;
        }

        private int? InsertDischarge(SqlConnection conn, ClaimDischarge v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimDischarge ( 
                                     ClaimId,
                                     Hour,
                                     StatusCode)
                            VALUES ( @ClaimId,
                                     @Hour,
                                     @StatusCode);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Hour = v.Hour,
                StatusCode = v.StatusCode
            }).Single();

            return result;
        }

        private int? InsertDocumentControlNumber(SqlConnection conn, ClaimDocumentControlNumber v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimDocumentControlNumber ( 
                                     ClaimId,
                                     DocumentControlNumber)
                            VALUES ( @ClaimId,
                                     @DocumentControlNumber);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                DocumentControlNumber = v.DocumentControlNumber
            }).Single();

            return result;
        }

        private int? InsertEmployerName(SqlConnection conn, ClaimEmployerName v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimEmployerName ( 
                                     ClaimId,
                                     EmployerName)
                            VALUES ( @ClaimId,
                                     @EmployerName);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                EmployerName = v.EmployerName
            }).Single();

            return result;
        }

        private int? InsertExternalCauseOfInjury(SqlConnection conn, ClaimExternalCauseOfInjury v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimExternalCauseOfInjury ( 
                                     ClaimId,
                                     Code)
                            VALUES ( @ClaimId,
                                     @Code);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code
            }).Single();

            return result;
        }

        private int? InsertICDDiagnosisCode(SqlConnection conn, ClaimICDDiagnosisCode v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimICDDiagnosisCode ( 
                                     ClaimId,
                                     Code,
                                     PresentOnAdmissionIndicator)
                            VALUES ( @ClaimId,
                                     @Code,
                                     @PresentOnAdmissionIndicator);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code,
                PresentOnAdmissionIndicator = v.PresentOnAdmissionIndicator
            }).Single();

            return result;
        }

        private int? InsertICDProcedureCode(SqlConnection conn, ClaimICDProcedureCode v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimICDProcedureCode ( 
                                     ClaimId,
                                     Code,
                                     ProcedureDate,
                                     IsPrimary)
                            VALUES ( @ClaimId,
                                     @Code,
                                     @ProcedureDate,
                                     @IsPrimary);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code,
                ProcedureDate = v.ProcedureDate,
                IsPrimary = v.IsPrimary
            }).Single();

            return result;
        }

        private int? InsertInsured(SqlConnection conn, ClaimInsured v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimInsured ( 
                                     ClaimId,
                                     Name,
                                     PatientsRelationshipTo,
                                     UniqueID,
                                     GroupName,
                                     GroupNumber)
                            VALUES ( @ClaimId,
                                     @Name,
                                     @PatientsRelationshipTo,
                                     @UniqueID,
                                     @GroupName,
                                     @GroupNumber);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Name = v.Name,
                PatientsRelationshipTo = v.PatientsRelationshipTo,
                UniqueID = v.UniqueID,
                GroupName = v.GroupName,
                GroupNumber = v.GroupNumber
            }).Single();

            return result;
        }

        private int? InsertOccurence(SqlConnection conn, ClaimOccurence v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimOccurence ( 
                                     ClaimId,
                                     Code,
                                     Date)
                            VALUES ( @ClaimId,
                                     @Code,
                                     @Date);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code,
                Date = v.Date
            }).Single();

            return result;
        }

        private int? InsertOccurenceSpan(SqlConnection conn, ClaimOccurenceSpan v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimOccurenceSpan ( 
                                     ClaimId,
                                     Code,
                                     FromDate,
                                     ThroughDate)
                            VALUES ( @ClaimId,
                                     @Code,
                                     @FromDate,
                                     @ThroughDate);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code,
                FromDate = v.FromDate,
                ThroughDate = v.ThroughDate
            }).Single();

            return result;
        }

        private int? InsertPatient(SqlConnection conn, ClaimPatient v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimPatient ( 
                                     ClaimId,
                                     Name,
                                     PatientID,
                                     StreetAddress,
                                     City,
                                     State,
                                     Zip,
                                     BirthDate,
                                     Gender)
                            VALUES ( @ClaimId,
                                     @Name,
                                     @PatientID,
                                     @StreetAddress,
                                     @City,
                                     @State,
                                     @Zip,
                                     @BirthDate,
                                     @Gender);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Name = v.Name,
                PatientID = v.PatientID,
                StreetAddress = v.StreetAddress,
                City = v.City,
                State = v.State,
                Zip = v.Zip,
                BirthDate = v.BirthDate,
                Gender = v.Gender
            }).Single();

            return result;
        }

        private int? InsertPayer(SqlConnection conn, ClaimPayer v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimPayer ( 
                                     ClaimId,
                                     PrecedenceOrder,
                                     Name,
                                     HealthPlanID,
                                     ReleaseInfoCertIndicator,
                                     AssignmentofBenefitsCertIndicator,
                                     PriorPayments,
                                     AmountDue)
                            VALUES ( @ClaimId,
                                     @PrecedenceOrder,
                                     @Name,
                                     @HealthPlanID,
                                     @ReleaseInfoCertIndicator,
                                     @AssignmentofBenefitsCertIndicator,
                                     @PriorPayments,
                                     @AmountDue);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                PrecedenceOrder = v.PrecedenceOrder,
                Name = v.Name,
                HealthPlanID = v.HealthPlanID,
                ReleaseInfoCertIndicator = v.ReleaseInfoCertIndicator,
                AssignmentofBenefitsCertIndicator = v.AssignmentofBenefitsCertIndicator,
                PriorPayments = v.PriorPayments,
                AmountDue = v.AmountDue
            }).Single();

            return result;
        }

        private int? InsertPhysician(SqlConnection conn, ClaimPhysician v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimPhysician ( 
                                     ClaimId,
                                     PhysicianType,
                                     NPI,
                                     QualifierCode,
                                     QualifierNumber,
                                     LastName,
                                     FirstName)
                            VALUES ( @ClaimId,
                                     @PhysicianType,
                                     @NPI,
                                     @QualifierCode,
                                     @QualifierNumber,
                                     @LastName,
                                     @FirstName);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                PhysicianType = v.PhysicianType,
                NPI = v.NPI,
                QualifierCode = v.QualifierCode,
                QualifierNumber = v.QualifierNumber,
                LastName = v.LastName,
                FirstName = v.FirstName
            }).Single();

            return result;
        }

        private int? InsertProvider(SqlConnection conn, ClaimProvider v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimProvider ( 
                                     ClaimId,
                                     Name,
                                     StreetAddress,
                                     City,
                                     State,
                                     Zip,
                                     Phone)
                            VALUES ( @ClaimId,
                                     @Name,
                                     @StreetAddress,
                                     @City,
                                     @State,
                                     @Zip,
                                     @Phone);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Name = v.Name,
                StreetAddress = v.StreetAddress,
                City = v.City,
                State = v.State,
                Zip = v.Zip,
                Phone = v.Phone
            }).Single();

            if (v.PayToList.Count() > 0)
            {
                for (int i = 0; i < v.PayToList.Count(); i++)
                {
                    v.PayToList[i].ClaimProviderId = (int)result;
                    InsertProviderPayTo(conn, v.PayToList[i]);
                }
            }

            return result;
        }

        private int? InsertProviderPayTo(SqlConnection conn, ClaimProviderPayTo v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimProviderPayTo ( 
                                     ClaimProviderId,
                                     Name,
                                     StreetAddress,
                                     City,
                                     State,
                                     Zip)
                            VALUES ( @ClaimProviderId,
                                     @Name,
                                     @StreetAddress,
                                     @City,
                                     @State,
                                     @Zip);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimProviderId = v.ClaimProviderId,
                Name = v.Name,
                StreetAddress = v.StreetAddress,
                City = v.City,
                State = v.State,
                Zip = v.Zip                
            }).Single();

            return result;
        }

        private int? InsertReasonForVisit(SqlConnection conn, ClaimReasonForVisit v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimReasonForVisit ( 
                                     ClaimId,
                                     Code)
                            VALUES ( @ClaimId,
                                     @Code);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code
            }).Single();

            return result;
        }

        private int? InsertResponsibleParty(SqlConnection conn, ClaimResponsibleParty v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimResponsibleParty ( 
                                     ClaimId,
                                     Name,
                                     StreetAddress,
                                     City,
                                     State,
                                     Zip)
                            VALUES ( @ClaimId,
                                     @Name,
                                     @StreetAddress,
                                     @City,
                                     @State,
                                     @Zip);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Name = v.Name,
                StreetAddress = v.StreetAddress,
                City = v.City,
                State = v.State,
                Zip = v.Zip
            }).Single();

            return result;
        }

        private int? InsertServiceLine(SqlConnection conn, ClaimServiceLine v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimServiceLine ( 
                                     ClaimId,
                                     RevenueCode,
                                     RevenueDescription,
                                     HCPCS,
                                     ServiceDate,
                                     ServiceUnits,
                                     TotalCharges,
                                     NonCoveredCharges)
                            VALUES ( @ClaimId,
                                     @RevenueCode,
                                     @RevenueDescription,
                                     @HCPCS,
                                     @ServiceDate,
                                     @ServiceUnits,
                                     @TotalCharges,
                                     @NonCoveredCharges);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                RevenueCode = v.RevenueCode,
                RevenueDescription = v.RevenueDescription,
                HCPCS = v.HCPCS,
                ServiceDate = v.ServiceDate,
                ServiceUnits = v.ServiceUnits,
                TotalCharges = v.TotalCharges,
                NonCoveredCharges = v.NonCoveredCharges                
            }).Single();

            return result;
        }

        private int? InsertTreatmentAuthCode(SqlConnection conn, ClaimTreatmentAuthCode v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimTreatmentAuthCode ( 
                                     ClaimId,
                                     Code)
                            VALUES ( @ClaimId,
                                     @Code);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code
            }).Single();

            return result;
        }

        private int? InsertValueCode(SqlConnection conn, ClaimValueCode v)
        {
            int? result = null;

            string sql = @" INSERT INTO ClaimValueCode ( 
                                     ClaimId,
                                     Code,
                                     Amount)
                            VALUES ( @ClaimId,
                                     @Code,
                                     @Amount);
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            result = conn.Query<int>(sql, new
            {
                ClaimId = v.ClaimId,
                Code = v.Code,
                Amount = v.Amount
            }).Single();

            return result;
        }
        







        public Claim GetClaim(int Id)
        {
            SqlConnection conn = GetConnection();

            Claim result = GetClaim(conn, Id);

            if (!_connWasPassedIn) conn.Dispose();

            return result;
        }

        private Claim GetClaim(SqlConnection conn, int Id)
        {
            Claim result = null;

            string sql = @" Select  Id, 
                                    PatientControlNumber,
                                    MedicalRecordNumber,
                                    TypeOfBill,
                                    FederalTaxNumber,
                                    StatementPeriodFrom,
                                    StatementPeriodThrough,
                                    AccidentState,
                                    NationalProviderIdentifier,
                                    PayerProvidedProviderID,
                                    OtherProviderID,
                                    PrivatePayerProviderID,
                                    ICDVersion,
                                    AdmittingDiagnosisCode,
                                    PPSCode,
                                    Remarks 
                            from Claim 
                            where Id = @Id";

            result = conn.Query<Claim>(sql, new { Id = Id }).FirstOrDefault();

            return result;
        }

        public List<Claim> GetManyClaims()
        {
            SqlConnection conn = GetConnection();

            List<Claim> result = GetManyClaims(conn);

            if (!_connWasPassedIn) conn.Dispose();

            return result;
        }

        private List<Claim> GetManyClaims(SqlConnection conn)
        {
            IEnumerable<Claim> result = null;

            string sql = @" Select  Id, 
                                    PatientControlNumber,
                                    MedicalRecordNumber,
                                    TypeOfBill,
                                    FederalTaxNumber,
                                    StatementPeriodFrom,
                                    StatementPeriodThrough,
                                    AccidentState,
                                    NationalProviderIdentifier,
                                    PayerProvidedProviderID,
                                    OtherProviderID,
                                    PrivatePayerProviderID,
                                    ICDVersion,
                                    AdmittingDiagnosisCode,
                                    PPSCode,
                                    Remarks 
                            from Claim";

            result = conn.Query<Claim>(sql);

            return result.ToList<Claim>();
        }

        public void UpdateClaim(Claim c)
        {
            SqlConnection conn = GetConnection();

            UpdateClaim(conn, c);

            if (!_connWasPassedIn) conn.Dispose();
        }

        private void UpdateClaim(SqlConnection conn, Claim c)
        {
            if (ClaimValidator.IsValidForUpdate(c))
            {
                string sql = @" update Claim
                                set PatientControlNumber = @PatientControlNumber,
                                    MedicalRecordNumber = @MedicalRecordNumber,
                                    TypeOfBill = @TypeOfBill,
                                    FederalTaxNumber = @FederalTaxNumber,
                                    StatementPeriodFrom = @StatementPeriodFrom,
                                    StatementPeriodThrough = @StatementPeriodThrough,
                                    AccidentState = @AccidentState,
                                    NationalProviderIdentifier = @NationalProviderIdentifier,
                                    PayerProvidedProviderID = @PayerProvidedProviderID,
                                    OtherProviderID = @OtherProviderID,
                                    PrivatePayerProviderID = @PrivatePayerProviderID,
                                    ICDVersion = @ICDVersion,
                                    AdmittingDiagnosisCode = @AdmittingDiagnosisCode,
                                    PPSCode = @PPSCode,
                                    Remarks = @Remarks 
                            where Id = @Id";

                conn.Execute(sql, new
                {
                    Id = c.Id,
                    PatientControlNumber = c.PatientControlNumber,
                    MedicalRecordNumber = c.MedicalRecordNumber,
                    TypeOfBill = c.TypeOfBill,
                    FederalTaxNumber = c.FederalTaxNumber,
                    StatementPeriodFrom = c.StatementPeriodFrom,
                    StatementPeriodThrough = c.StatementPeriodThrough,
                    AccidentState = c.AccidentState,
                    NationalProviderIdentifier = c.NationalProviderIdentifier,
                    PayerProvidedProviderID = c.PayerProvidedProviderID,
                    OtherProviderID = c.OtherProviderID,
                    PrivatePayerProviderID = c.PrivatePayerProviderID,
                    ICDVersion = c.ICDVersion,
                    AdmittingDiagnosisCode = c.AdmittingDiagnosisCode,
                    PPSCode = c.PPSCode,
                    Remarks = c.Remarks
                });
            }
        }

        public void DeleteClaim(int Id)
        {
            SqlConnection conn = GetConnection();

            DeleteClaim(conn, Id);

            if (!_connWasPassedIn) conn.Dispose();
        }

        private void DeleteClaim(SqlConnection conn, int Id)
        {
            string sql = @" delete from Claim 
                            where Id = @Id";

            conn.Execute(sql, new { Id = Id });
        }

        private SqlConnection GetConnection()
        {
            SqlConnection results;

            if (_conn == null)
            {
                results = new SqlConnection(_connString);
                results.Open();
            }
            else { results = _conn; }

            return results;
        }




      
    }
}
