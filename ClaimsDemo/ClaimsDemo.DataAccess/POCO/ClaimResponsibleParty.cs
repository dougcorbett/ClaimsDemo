using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimResponsibleParty
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
