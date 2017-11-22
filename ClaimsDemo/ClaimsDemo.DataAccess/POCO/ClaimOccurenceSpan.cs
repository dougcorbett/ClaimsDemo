using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimOccurenceSpan
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Code { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThroughDate { get; set; }
    }
}