using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimOccurence
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string Code { get; set; }
       public DateTime Date { get; set; }

       public ClaimOccurence()
       {
       }

    }
}
