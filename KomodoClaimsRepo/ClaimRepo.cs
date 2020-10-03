using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsRepo
{
    public class ClaimRepo
    {
        public Queue<Claim> _listOfClaim = new Queue<Claim>();


        //Create
        public void EnterNewClaim(Claim claim)
        {
            _listOfClaim.Enqueue(claim);
        }
        //Read
        public Queue<Claim> SeeAllClaim()
        {
            return _listOfClaim;
        }



        public Claim SeeNextClaim()
        {
            return _listOfClaim.Peek();
        }
        public void DeleteNextClaim() 
        {
            SeeNextClaim();
            _listOfClaim.Dequeue();
        }

        public void SeedContentList()
        {

            _listOfClaim.Enqueue(new Claim("1", ClaimType.car, "Car Accident on 464", 400, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27)));

            _listOfClaim.Enqueue(new Claim("2", ClaimType.home, "House fire in kitchen", 4000, new DateTime(2018, 4, 25), new DateTime(2018, 4, 12)));

            _listOfClaim.Enqueue(new Claim("3", ClaimType.theft, "Stolen pancakes", 4, new DateTime(2018, 4, 25), new DateTime(2018, 06, 01)));
        }






    }
}

