using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepository
{
    public class ClaimsRepo
    {
        public Queue<Claims> _claimsList = new Queue<Claims>();
        public void AddClaimToList(Claims claims)
        {
            _claimsList.Enqueue(claims);
        }
        public Queue<Claims> GetClaims()
        {
            return _claimsList;
        }
        public void RemoveClaimFromQueue()
        {
            _claimsList.Dequeue();
        }
        public Queue<Claims> ClaimFromTopOfQueue
        {
            get
            {
                _claimsList.Peek();
            }
        }

        public bool UpdateClaim(string originalClaim, Claims newClaims)
        {
            Claims oldClaims = GetClaimsByClaimId(originalClaim);
            if (oldClaims != null)
            {
                oldClaims.ClaimId = newClaims.ClaimId;
                oldClaims.TypeOfClaim = newClaims.TypeOfClaim;
                oldClaims.Description = newClaims.Description;
                oldClaims.ClaimAmount = newClaims.ClaimAmount;
                oldClaims.DateOfIncident = newClaims.DateOfIncident;
                oldClaims.DateOfClaim = newClaims.DateOfClaim;
                oldClaims.IsValid = newClaims.IsValid;
                return true;
            }
            else
            {
                return false;
            }
        }       
        public Claims GetClaimsByClaimId(string claimId)
        {
           foreach(Claims claims in _claimsList)
            {
               if(claims.ClaimId == claimId)
               {
                   return claims;
                }
            }
            return null;
        }
    }
}
