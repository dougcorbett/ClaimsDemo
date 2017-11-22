using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimValueCode
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Code { get; set; }
        public Decimal Amount { get; set; }
    }
}
