using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimICDDiagnosisCode
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string Code { get; set; }
       public string PresentOnAdmissionIndicator { get; set; }

       public ClaimICDDiagnosisCode()
       {
       }

    }
}
