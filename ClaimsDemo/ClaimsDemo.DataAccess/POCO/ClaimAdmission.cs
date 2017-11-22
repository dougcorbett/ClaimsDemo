using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimAdmission
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public DateTime StartDate { get; set; }
       public int? Hour { get; set; }
       public string PriorityCode { get; set; }
       public string SourceOfReferralCode { get; set; }

       public ClaimAdmission()
       {
       }

    }
}
