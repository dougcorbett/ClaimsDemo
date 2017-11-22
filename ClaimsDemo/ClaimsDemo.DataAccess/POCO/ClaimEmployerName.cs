using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimEmployerName
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string EmployerName { get; set; }
    }
}
