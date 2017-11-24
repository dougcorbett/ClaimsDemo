using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDemo.DataAccess.POCO;
using ClaimsDemo.UnitTests.TestClaims;

namespace ClaimsDemo.UnitTests
{
    public class TestClaimRepository
    {
        public Claim GetClaim(TestClaimsEnum claim)
        {
            Claim result = new Claim();

            switch (claim)
            {
                case TestClaimsEnum.Claim_Full:
                    result = new ClaimFull();
                    break;
                case TestClaimsEnum.Claim_001:
                    result = new Claim001();
                    break;
                case TestClaimsEnum.Claim_002:
                    result = new Claim002();
                    break;
                case TestClaimsEnum.Claim_003:
                    result = new Claim003();
                    break;
                case TestClaimsEnum.Claim_004:
                    result = new Claim004();
                    break;
                case TestClaimsEnum.Claim_005:
                    result = new Claim005();
                    break;
                case TestClaimsEnum.Claim_006:
                    result = new Claim006();
                    break;
                case TestClaimsEnum.Claim_007:
                    result = new Claim007();
                    break;
                case TestClaimsEnum.Claim_008:
                    result = new Claim008();
                    break;
                case TestClaimsEnum.Claim_009:
                    result = new Claim009();
                    break;
                case TestClaimsEnum.Claim_010:
                    result = new Claim010();
                    break;
                case TestClaimsEnum.Claim_011:
                    result = new Claim011();
                    break;
                case TestClaimsEnum.Claim_012:
                    result = new Claim012();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
