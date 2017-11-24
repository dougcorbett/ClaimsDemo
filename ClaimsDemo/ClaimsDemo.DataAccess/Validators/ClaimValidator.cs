using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;

namespace ClaimsDemo.DataAccess.Validators
{
    public class ClaimValidator
    {
        public static bool IsValidForCreation(Claim c)
        {
            return true;
        }

        public static bool IsValidForUpdate(Claim c)
        {
            return (IsValidForCreation(c) & (c.Id != 0));
        }
    }
}
