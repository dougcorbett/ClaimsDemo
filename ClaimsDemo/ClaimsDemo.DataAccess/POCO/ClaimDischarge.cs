using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimDischarge
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int Hour { get; set; }
        public int StatusCode { get; set; }
    }
}