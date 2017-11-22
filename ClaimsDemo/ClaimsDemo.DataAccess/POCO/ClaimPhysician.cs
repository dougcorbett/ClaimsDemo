using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimPhysician
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string PhysicianType { get; set; }
       public string NPI { get; set; }
       public string QualifierCode { get; set; }
       public string QualifierNumber { get; set; }
       public string LastName { get; set; }
       public string FirstName { get; set; }

       public ClaimPhysician()
       {
       }

    }
}
