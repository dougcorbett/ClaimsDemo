using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimTreatmentAuthCode
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Code { get; set; }
    }
}
