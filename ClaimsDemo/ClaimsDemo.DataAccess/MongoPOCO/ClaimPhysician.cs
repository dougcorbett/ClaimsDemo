using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimPhysician
    {
        public string PhysicianType { get; set; }
        public string NPI { get; set; }
        public string QualifierCode { get; set; }
        public string QualifierNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
