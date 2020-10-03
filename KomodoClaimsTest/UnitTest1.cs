using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using KomodoClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoClaimsTest
{
    [TestClass]
    public class UnitTest1
    {
        private ClaimRepo _Repo = new ClaimRepo();
        public void SeedRepository()
        //SeedContentList
        {
            Claim claim = new Claim(); //Blank constructor
            claim.ClaimID = "5";
            claim.TypeOfClaim = ClaimType.car;
            claim.Description = "Hit a pole";
            claim.ClaimAmount = 2500;
            claim.DateOfIncident = new DateTime(2018, 5, 6);
            claim.DateOfClaim = new DateTime(2018, 5, 8);
            _Repo.EnterNewClaim(claim);
            //Full constructor
            Claim claim6 = new Claim("6", ClaimType.home, "fell through ceiling", 1700, new DateTime(2018, 6, 15), new DateTime(2018, 6, 17));
        }

        //only test methods
        [TestMethod]
        public void SeeAllClaim()
        {
            //Arrange
            SeedRepository();
            //Act
            Queue<Claim> list = _Repo.SeeAllClaim();
            int actual = list.Count;
            //Assert
            Assert.AreEqual(3, actual);

        }
        [TestMethod]
        public void CreateNewClaimShouldIncreaseCount()
        {

            //Arrange
            SeedRepository();
            Claim claim6 = new Claim("6", ClaimType.home, "fell through ceiling", 1700, new DateTime(2018, 6, 15), new DateTime(2018, 6, 17));
            //Act
            Queue<Claim> list = _Repo.SeeAllClaim();
            int actual = list.Count;
            //Assert
            Assert.AreEqual(6, actual);
        }
       // [TestMethod]
        //public void SeeNextClaim()
       // {
            //Arrange
          //  SeedRepository();
            //Act

            //Assert
        //}


    }

}




















