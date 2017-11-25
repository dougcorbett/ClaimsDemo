using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimProvider
    {
       public string Name { get; set; }
       public string StreetAddress { get; set; }
       public string City { get; set; }
       public string State { get; set; }
       public string Zip { get; set; }
       public string Phone { get; set; }

       public ClaimProviderPayTo PayTo { get; set; }
    }
}
