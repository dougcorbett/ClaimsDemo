using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimOccurenceSpan
    {
       public string Code { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ThroughDate { get; set; }
    }
}
