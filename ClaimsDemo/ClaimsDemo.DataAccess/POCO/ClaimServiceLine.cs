using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimServiceLine
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string RevenueCode { get; set; }
       public string RevenueDescription { get; set; }
       public string HCPCS { get; set; }
       public DateTime? ServiceDate { get; set; }
       public int? ServiceUnits { get; set; }
       public Decimal? TotalCharges { get; set; }
       public Decimal? NonCoveredCharges { get; set; }

       public ClaimServiceLine()
       {
       }

    }
}
