using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimCondition
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string Code { get; set; }

       public ClaimCondition()
       {
       }

    }
}
