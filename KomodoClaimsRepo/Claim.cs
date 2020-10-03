using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsRepo
{
    public enum ClaimType
    {
        car = 1,
        home, 
        theft,
    }
   public class Claim
    {
        public string ClaimID { get; set; }
        public  ClaimType  TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public Claim() { }
        public Claim(string claimid, ClaimType claim, string description, double claimamount, DateTime dateofincident, DateTime dateofclaim)
        {
            ClaimID = claimid;
            TypeOfClaim = claim;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            IsValid = (dateofclaim - dateofincident).Days <31;
        }
    }
}
