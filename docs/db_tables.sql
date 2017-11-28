USE [Claims]
GO

ALTER TABLE [dbo].[Claim] DROP CONSTRAINT [CK_Claim_TypeOfBill_Not_000]
GO

ALTER TABLE [dbo].[ClaimValueCode] DROP CONSTRAINT [FK_ClaimValueCode_Claim]
GO

ALTER TABLE [dbo].[ClaimTreatmentAuthCode] DROP CONSTRAINT [FK_ClaimTreatmentAuthCode_Claim]
GO

ALTER TABLE [dbo].[ClaimServiceLine] DROP CONSTRAINT [FK_ClaimServiceLine_Claim]
GO

ALTER TABLE [dbo].[ClaimResponsibleParty] DROP CONSTRAINT [FK_ClaimResponsibleParty_Claim]
GO

ALTER TABLE [dbo].[ClaimReasonForVisit] DROP CONSTRAINT [FK_ClaimReasonForVisit_Claim]
GO

ALTER TABLE [dbo].[ClaimProviderPayTo] DROP CONSTRAINT [FK_ClaimProviderPayTo_ClaimProvider]
GO

ALTER TABLE [dbo].[ClaimProvider] DROP CONSTRAINT [FK_ClaimProvider_Claim]
GO

ALTER TABLE [dbo].[ClaimPhysician] DROP CONSTRAINT [FK_ClaimPhysician_Claim]
GO

ALTER TABLE [dbo].[ClaimPayer] DROP CONSTRAINT [FK_ClaimPayer_Claim]
GO

ALTER TABLE [dbo].[ClaimPatient] DROP CONSTRAINT [FK_ClaimPatient_Claim]
GO

ALTER TABLE [dbo].[ClaimOccurenceSpan] DROP CONSTRAINT [FK_ClaimOccurenceSpan_Claim]
GO

ALTER TABLE [dbo].[ClaimOccurence] DROP CONSTRAINT [FK_ClaimOccurence_Claim]
GO

ALTER TABLE [dbo].[ClaimInsured] DROP CONSTRAINT [FK_ClaimInsured_Claim]
GO

ALTER TABLE [dbo].[ClaimICDProcedureCode] DROP CONSTRAINT [FK_ClaimICDProcedureCode_Claim]
GO

ALTER TABLE [dbo].[ClaimICDDiagnosisCode] DROP CONSTRAINT [FK_ClaimICDDiagnosisCode_Claim]
GO

ALTER TABLE [dbo].[ClaimExternalCauseOfInjury] DROP CONSTRAINT [FK_ClaimExternalCauseOfInjury_Claim]
GO

ALTER TABLE [dbo].[ClaimEmployerName] DROP CONSTRAINT [FK_ClaimEmployerName_Claim]
GO

ALTER TABLE [dbo].[ClaimDocumentControlNumber] DROP CONSTRAINT [FK_ClaimDocumentControlNumber_Claim]
GO

ALTER TABLE [dbo].[ClaimDischarge] DROP CONSTRAINT [FK_ClaimDischarge_Claim]
GO

ALTER TABLE [dbo].[ClaimCondition] DROP CONSTRAINT [FK_ClaimCondition_Claim]
GO

ALTER TABLE [dbo].[ClaimAdmission] DROP CONSTRAINT [FK_ClaimAdmission_Claim]
GO

/****** Object:  Table [dbo].[ClaimValueCode]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimValueCode]
GO

/****** Object:  Table [dbo].[ClaimTreatmentAuthCode]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimTreatmentAuthCode]
GO

/****** Object:  Table [dbo].[ClaimServiceLine]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimServiceLine]
GO

/****** Object:  Table [dbo].[ClaimResponsibleParty]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimResponsibleParty]
GO

/****** Object:  Table [dbo].[ClaimReasonForVisit]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimReasonForVisit]
GO

/****** Object:  Table [dbo].[ClaimProviderPayTo]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimProviderPayTo]
GO

/****** Object:  Table [dbo].[ClaimProvider]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimProvider]
GO

/****** Object:  Table [dbo].[ClaimPhysician]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimPhysician]
GO

/****** Object:  Table [dbo].[ClaimPayer]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimPayer]
GO

/****** Object:  Table [dbo].[ClaimPatient]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimPatient]
GO

/****** Object:  Table [dbo].[ClaimOccurenceSpan]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimOccurenceSpan]
GO

/****** Object:  Table [dbo].[ClaimOccurence]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimOccurence]
GO

/****** Object:  Table [dbo].[ClaimInsured]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimInsured]
GO

/****** Object:  Table [dbo].[ClaimICDProcedureCode]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimICDProcedureCode]
GO

/****** Object:  Table [dbo].[ClaimICDDiagnosisCode]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimICDDiagnosisCode]
GO

/****** Object:  Table [dbo].[ClaimExternalCauseOfInjury]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimExternalCauseOfInjury]
GO

/****** Object:  Table [dbo].[ClaimEmployerName]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimEmployerName]
GO

/****** Object:  Table [dbo].[ClaimDocumentControlNumber]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimDocumentControlNumber]
GO

/****** Object:  Table [dbo].[ClaimDischarge]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimDischarge]
GO

/****** Object:  Table [dbo].[ClaimCondition]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimCondition]
GO

/****** Object:  Table [dbo].[ClaimAdmission]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[ClaimAdmission]
GO

/****** Object:  Table [dbo].[Claim]    Script Date: 11/28/2017 3:27:13 PM ******/
DROP TABLE [dbo].[Claim]
GO

/****** Object:  Table [dbo].[Claim]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Claim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientControlNumber] [varchar](20) NULL,
	[MedicalRecordNumber] [varchar](24) NULL,
	[TypeOfBill] [varchar](4) NULL,
	[FederalTaxNumber] [varchar](10) NULL,
	[StatementPeriodFrom] [date] NULL,
	[StatementPeriodThrough] [date] NULL,
	[AccidentState] [varchar](10) NULL,
	[NationalProviderIdentifier] [varchar](10) NULL,
	[PayerProvidedProviderID] [varchar](10) NULL,
	[OtherProviderID] [varchar](10) NULL,
	[PrivatePayerProviderID] [varchar](10) NULL,
	[ICDVersion] [char](1) NULL,
	[AdmittingDiagnosisCode] [varchar](10) NULL,
	[PPSCode] [varchar](10) NULL,
	[Remarks] [varchar](150) NULL,
 CONSTRAINT [PK_Claim1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimAdmission]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimAdmission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[Hour] [int] NULL,
	[PriorityCode] [varchar](1) NULL,
	[SourceOfReferralCode] [varchar](1) NULL,
 CONSTRAINT [PK_ClaimAdmission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ClaimAdmission_ClaimId] UNIQUE NONCLUSTERED 
(
	[ClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimCondition]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimCondition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](2) NOT NULL,
 CONSTRAINT [PK_ClaimCondition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimDischarge]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimDischarge](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Hour] [int] NULL,
	[StatusCode] [int] NULL,
 CONSTRAINT [PK_ClaimDischarge] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ClaimDischarge_ClaimId] UNIQUE NONCLUSTERED 
(
	[ClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimDocumentControlNumber]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimDocumentControlNumber](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[DocumentControlNumber] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ClaimDocumentControlNumber] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimEmployerName]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimEmployerName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[EmployerName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ClaimEmployerName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimExternalCauseOfInjury]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimExternalCauseOfInjury](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ClaimExternalCauseOfInjury] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimICDDiagnosisCode]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimICDDiagnosisCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](30) NOT NULL,
	[PresentOnAdmissionIndicator] [varchar](1) NULL,
 CONSTRAINT [PK_ClaimICDDiagnosisCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimICDProcedureCode]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimICDProcedureCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](30) NOT NULL,
	[ProcedureDate] [date] NOT NULL,
	[IsPrimary] [bit] NOT NULL,
 CONSTRAINT [PK_ClaimICDProcedureCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimInsured]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimInsured](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PatientsRelationshipTo] [varchar](2) NOT NULL,
	[UniqueID] [varchar](20) NULL,
	[GroupName] [varchar](50) NULL,
	[GroupNumber] [varchar](50) NULL,
 CONSTRAINT [PK_ClaimInsured] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimOccurence]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimOccurence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](2) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_ClaimOccurence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimOccurenceSpan]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimOccurenceSpan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](2) NOT NULL,
	[FromDate] [date] NOT NULL,
	[ThroughDate] [date] NOT NULL,
 CONSTRAINT [PK_ClaimOccurenceSpan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimPatient]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimPatient](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Name] [varchar](29) NOT NULL,
	[PatientID] [varchar](19) NULL,
	[StreetAddress] [varchar](40) NOT NULL,
	[City] [varchar](30) NOT NULL,
	[State] [varchar](2) NOT NULL,
	[Zip] [varchar](9) NOT NULL,
	[BirthDate] [date] NULL,
	[Gender] [varchar](1) NULL,
 CONSTRAINT [PK_ClaimPatient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ClaimPatient_ClaimId] UNIQUE NONCLUSTERED 
(
	[ClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimPayer]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimPayer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[PrecedenceOrder] [int] NOT NULL,
	[Name] [varchar](23) NOT NULL,
	[HealthPlanID] [varchar](10) NOT NULL,
	[ReleaseInfoCertIndicator] [varchar](1) NULL,
	[AssignmentofBenefitsCertIndicator] [varchar](1) NULL,
	[PriorPayments] [decimal](10, 2) NULL,
	[AmountDue] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ClaimPayer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimPhysician]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimPhysician](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[PhysicianType] [varchar](20) NOT NULL,
	[NPI] [varchar](20) NOT NULL,
	[QualifierCode] [varchar](2) NULL,
	[QualifierNumber] [varchar](10) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ClaimPhysician] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimProvider]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimProvider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[StreetAddress] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ClaimProvider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ClaimProvider_ClaimId] UNIQUE NONCLUSTERED 
(
	[ClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimProviderPayTo]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimProviderPayTo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimProviderId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[StreetAddress] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ClaimProviderPayTo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimReasonForVisit]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimReasonForVisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ClaimReasonForVisit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimResponsibleParty]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimResponsibleParty](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[StreetAddress] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ClaimResponsibleParty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ClaimResponsibleParty_ClaimId] UNIQUE NONCLUSTERED 
(
	[ClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimServiceLine]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimServiceLine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[RevenueCode] [varchar](4) NOT NULL,
	[RevenueDescription] [varchar](24) NULL,
	[HCPCS] [varchar](13) NULL,
	[ServiceDate] [date] NULL,
	[ServiceUnits] [int] NULL,
	[TotalCharges] [decimal](18, 2) NULL,
	[NonCoveredCharges] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ClaimServiceLine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimTreatmentAuthCode]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimTreatmentAuthCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](15) NOT NULL,
 CONSTRAINT [PK_ClaimTreatmentAuthCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ClaimValueCode]    Script Date: 11/28/2017 3:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClaimValueCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimId] [int] NOT NULL,
	[Code] [varchar](2) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ClaimValueCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ClaimAdmission]  WITH CHECK ADD  CONSTRAINT [FK_ClaimAdmission_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimAdmission] CHECK CONSTRAINT [FK_ClaimAdmission_Claim]
GO

ALTER TABLE [dbo].[ClaimCondition]  WITH CHECK ADD  CONSTRAINT [FK_ClaimCondition_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimCondition] CHECK CONSTRAINT [FK_ClaimCondition_Claim]
GO

ALTER TABLE [dbo].[ClaimDischarge]  WITH CHECK ADD  CONSTRAINT [FK_ClaimDischarge_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimDischarge] CHECK CONSTRAINT [FK_ClaimDischarge_Claim]
GO

ALTER TABLE [dbo].[ClaimDocumentControlNumber]  WITH CHECK ADD  CONSTRAINT [FK_ClaimDocumentControlNumber_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimDocumentControlNumber] CHECK CONSTRAINT [FK_ClaimDocumentControlNumber_Claim]
GO

ALTER TABLE [dbo].[ClaimEmployerName]  WITH CHECK ADD  CONSTRAINT [FK_ClaimEmployerName_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimEmployerName] CHECK CONSTRAINT [FK_ClaimEmployerName_Claim]
GO

ALTER TABLE [dbo].[ClaimExternalCauseOfInjury]  WITH CHECK ADD  CONSTRAINT [FK_ClaimExternalCauseOfInjury_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimExternalCauseOfInjury] CHECK CONSTRAINT [FK_ClaimExternalCauseOfInjury_Claim]
GO

ALTER TABLE [dbo].[ClaimICDDiagnosisCode]  WITH CHECK ADD  CONSTRAINT [FK_ClaimICDDiagnosisCode_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimICDDiagnosisCode] CHECK CONSTRAINT [FK_ClaimICDDiagnosisCode_Claim]
GO

ALTER TABLE [dbo].[ClaimICDProcedureCode]  WITH CHECK ADD  CONSTRAINT [FK_ClaimICDProcedureCode_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimICDProcedureCode] CHECK CONSTRAINT [FK_ClaimICDProcedureCode_Claim]
GO

ALTER TABLE [dbo].[ClaimInsured]  WITH CHECK ADD  CONSTRAINT [FK_ClaimInsured_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimInsured] CHECK CONSTRAINT [FK_ClaimInsured_Claim]
GO

ALTER TABLE [dbo].[ClaimOccurence]  WITH CHECK ADD  CONSTRAINT [FK_ClaimOccurence_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimOccurence] CHECK CONSTRAINT [FK_ClaimOccurence_Claim]
GO

ALTER TABLE [dbo].[ClaimOccurenceSpan]  WITH CHECK ADD  CONSTRAINT [FK_ClaimOccurenceSpan_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimOccurenceSpan] CHECK CONSTRAINT [FK_ClaimOccurenceSpan_Claim]
GO

ALTER TABLE [dbo].[ClaimPatient]  WITH CHECK ADD  CONSTRAINT [FK_ClaimPatient_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimPatient] CHECK CONSTRAINT [FK_ClaimPatient_Claim]
GO

ALTER TABLE [dbo].[ClaimPayer]  WITH CHECK ADD  CONSTRAINT [FK_ClaimPayer_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimPayer] CHECK CONSTRAINT [FK_ClaimPayer_Claim]
GO

ALTER TABLE [dbo].[ClaimPhysician]  WITH CHECK ADD  CONSTRAINT [FK_ClaimPhysician_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimPhysician] CHECK CONSTRAINT [FK_ClaimPhysician_Claim]
GO

ALTER TABLE [dbo].[ClaimProvider]  WITH CHECK ADD  CONSTRAINT [FK_ClaimProvider_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimProvider] CHECK CONSTRAINT [FK_ClaimProvider_Claim]
GO

ALTER TABLE [dbo].[ClaimProviderPayTo]  WITH CHECK ADD  CONSTRAINT [FK_ClaimProviderPayTo_ClaimProvider] FOREIGN KEY([ClaimProviderId])
REFERENCES [dbo].[ClaimProvider] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimProviderPayTo] CHECK CONSTRAINT [FK_ClaimProviderPayTo_ClaimProvider]
GO

ALTER TABLE [dbo].[ClaimReasonForVisit]  WITH CHECK ADD  CONSTRAINT [FK_ClaimReasonForVisit_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimReasonForVisit] CHECK CONSTRAINT [FK_ClaimReasonForVisit_Claim]
GO

ALTER TABLE [dbo].[ClaimResponsibleParty]  WITH CHECK ADD  CONSTRAINT [FK_ClaimResponsibleParty_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimResponsibleParty] CHECK CONSTRAINT [FK_ClaimResponsibleParty_Claim]
GO

ALTER TABLE [dbo].[ClaimServiceLine]  WITH CHECK ADD  CONSTRAINT [FK_ClaimServiceLine_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimServiceLine] CHECK CONSTRAINT [FK_ClaimServiceLine_Claim]
GO

ALTER TABLE [dbo].[ClaimTreatmentAuthCode]  WITH CHECK ADD  CONSTRAINT [FK_ClaimTreatmentAuthCode_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimTreatmentAuthCode] CHECK CONSTRAINT [FK_ClaimTreatmentAuthCode_Claim]
GO

ALTER TABLE [dbo].[ClaimValueCode]  WITH CHECK ADD  CONSTRAINT [FK_ClaimValueCode_Claim] FOREIGN KEY([ClaimId])
REFERENCES [dbo].[Claim] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ClaimValueCode] CHECK CONSTRAINT [FK_ClaimValueCode_Claim]
GO

ALTER TABLE [dbo].[Claim]  WITH CHECK ADD  CONSTRAINT [CK_Claim_TypeOfBill_Not_000] CHECK  (([TypeOfBill]<>'0000'))
GO

ALTER TABLE [dbo].[Claim] CHECK CONSTRAINT [CK_Claim_TypeOfBill_Not_000]
GO

