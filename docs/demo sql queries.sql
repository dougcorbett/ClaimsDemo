use Claims
go

-- simple query
select c.* 
from Claim c
where c.Id = 164
-- 1

-- Two table query
select c.* 
from Claim c
left join ClaimServiceLine sl on sl.ClaimId = c.Id
where c.Id = 164
-- 11

-- Three table query
select c.*, sl.* , d.*
from Claim c
left join ClaimServiceLine sl on sl.ClaimId = c.Id
left join ClaimICDDiagnosisCode d on d.ClaimId = c.Id
where c.Id = 164
-- 44

-- get claim id with predicates on two joined tables
select c.Id
from Claim c
left join ClaimServiceLine sl on sl.ClaimId = c.Id
left join ClaimICDDiagnosisCode d on d.ClaimId = c.Id
where sl.RevenueCode = '0120' and d.code = '6141'
-- 4

-- Get claims with Attending physician “Rick Martins”
select c.Id
from Claim c 
left join ClaimPhysician p on c.Id = p.ClaimId
where p.LastName = 'Martins' and p.FirstName = 'Rick' 


-- a whole lot of queries involved to build a claim
select * from Claim
select * from ClaimAdmission
select * from ClaimCondition
select * from ClaimDischarge
select * from ClaimDocumentControlNumber
select * from ClaimEmployerName
select * from ClaimExternalCauseOfInjury
select * from ClaimICDDiagnosisCode
select * from ClaimICDProcedureCode
select * from ClaimInsured
select * from ClaimOccurence
select * from ClaimOccurenceSpan
select * from ClaimPatient
select * from ClaimPayer
select * from ClaimPhysician
select * from ClaimProvider
select * from ClaimProviderPayTo
select * from ClaimReasonForVisit
select * from ClaimResponsibleParty
select * from ClaimServiceLine
select * from ClaimTreatmentAuthCode
select * from ClaimValueCode


-- delete from claim