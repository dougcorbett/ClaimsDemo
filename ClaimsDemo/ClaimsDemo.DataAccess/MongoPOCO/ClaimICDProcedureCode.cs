using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimICDProcedureCode
    {
       public string Code { get; set; }
       public DateTime ProcedureDate { get; set; }
       public Boolean IsPrimary { get; set; }
    }
}
