using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepository
{
    public enum ClaimType
    {
        Car = 1, 
        Home, 
        Theft
    }
    public class Claims
    { 
        public int ClaimId { get; set; } 
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                TimeSpan claimTime = DateOfClaim - DateOfIncident;

                if (claimTime.TotalDays <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
        public Claims() { }
    public Claims (int claimId, ClaimType typeOfClaim, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
    {
            ClaimId = claimId;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;           
    }
}
}
