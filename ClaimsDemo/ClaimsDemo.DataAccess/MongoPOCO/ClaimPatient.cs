using System;
using System.Collections.Generic;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimPatient
    {
       public string Name { get; set; }
       public string PatientID { get; set; }
       public string StreetAddress { get; set; }
       public string City { get; set; }
       public string State { get; set; }
       public string Zip { get; set; }
       public DateTime? BirthDate { get; set; }
       public string Gender { get; set; }
    }
}
