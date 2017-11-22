using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimProviderPayTo
    {
        public int Id { get; set; }
        public int ClaimProviderId { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
