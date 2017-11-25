using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimInsured
    {
       public string Name { get; set; }
       public string PatientsRelationshipTo { get; set; }
       public string UniqueID { get; set; }
       public string GroupName { get; set; }
       public string GroupNumber { get; set; }
    }
}
