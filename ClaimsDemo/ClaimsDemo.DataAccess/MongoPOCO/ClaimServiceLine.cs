using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimServiceLine
    {
       public string RevenueCode { get; set; }
       public string RevenueDescription { get; set; }
       public string HCPCS { get; set; }
       public DateTime? ServiceDate { get; set; }
       public int? ServiceUnits { get; set; }
       public Decimal? TotalCharges { get; set; }
       public Decimal? NonCoveredCharges { get; set; }
    }
}
