using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimInsured
    {
       public int Id { get; set; }
       public int ClaimId { get; set; }
       public string Name { get; set; }
       public string PatientsRelationshipTo { get; set; }
       public string UniqueID { get; set; }
       public string GroupName { get; set; }
       public string GroupNumber { get; set; }

       public ClaimInsured()
       {
       }

    }
}
