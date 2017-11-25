using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace ClaimsDemo.DataAccess.MongoPOCO
{
    public class ClaimAdmission
    {
       public DateTime StartDate { get; set; }
       public int? Hour { get; set; }
       public string PriorityCode { get; set; }
       public string SourceOfReferralCode { get; set; }
    }
}
