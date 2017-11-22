using System;

namespace ClaimsDemo.DataAccess.POCO
{
    public class ClaimICDProcedureCode
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string Code { get; set; }
        public DateTime ProcedureDate { get; set; }
        public Boolean IsPrimary { get; set; }
    }
}
