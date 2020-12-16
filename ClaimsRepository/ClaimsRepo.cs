using System;
using System.Collections.Generic;
using System.Data;
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
        public Claims ClaimFromTopOfQueue()
        {
           return _claimsList.Peek();
        }

        public bool UpdateClaim( int originalClaims, Claims newClaims)
        {
            Claims oldClaims = GetClaimsByClaimId(originalClaims);
            if (oldClaims != null)
            {
                oldClaims.ClaimId = newClaims.ClaimId;
                oldClaims.TypeOfClaim = newClaims.TypeOfClaim;
                oldClaims.Description = newClaims.Description;
                oldClaims.ClaimAmount = newClaims.ClaimAmount;
                oldClaims.DateOfIncident = newClaims.DateOfIncident;
                oldClaims.DateOfClaim = newClaims.DateOfClaim;
             
                return true;
            }
            else
            {
                return false;
            }
        }       
        public Claims GetClaimsByClaimId(int claimId)
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
