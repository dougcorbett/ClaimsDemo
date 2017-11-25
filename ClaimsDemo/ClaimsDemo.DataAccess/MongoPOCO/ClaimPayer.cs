using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimPayer
    {
       public int PrecedenceOrder { get; set; }
       public string Name { get; set; }
       public string HealthPlanID { get; set; }
       public string ReleaseInfoCertIndicator { get; set; }
       public string AssignmentofBenefitsCertIndicator { get; set; }
       public Decimal? PriorPayments { get; set; }
       public Decimal? AmountDue { get; set; }
    }
}
