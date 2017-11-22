using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimDocumentControlNumber
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string DocumentControlNumber { get; set; }

       public ClaimDocumentControlNumber()
       {
       }

    }
}
