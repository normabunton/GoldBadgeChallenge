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
        public string ClaimId { get; set; } 
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }
        public bool IsValid { get; set; }
    public Claims() { }
    public Claims(string claimId, ClaimType claimType, string description, double claimAmount, string dateOfIncident, string dateOfClaim, bool isValid)
    {
            ClaimId = claimId;
            TypeOfClaim = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
    }
}
}
