using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KomodoClaimsRepo;

namespace KomodoClaimsConsole
{
    class ProgramUI
    {
        ClaimRepo _claimRepo = new ClaimRepo();

        public void Run()
        {
            _claimRepo.SeedContentList();
            Menu();
        }
        //menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Select a menu option\n" +
                    "1 SeeAllClaim \n" +
                    "2 EnterNewClaim/n" +
                    "3 TakeCareOfNextClaim");

                //Get user input
                string input = Console.ReadLine();
                //Evaluate user's input and act accordingly
                switch (input)
                {
                    //view all claims
                    case "1":
                        SeeAllClaim();
                        break;
                    //enter new claim
                    case "2":
                        EnterNewClaim();
                        break;
                    //take care of next claim
                    case "3":
                        _claimRepo.SeeNextClaim();
                        //write claim and properties
                        //cw do you want to handle this claim y or n
                        //if else yes new method to handle/delete claim
                        //if no cc public void DeleteNextClaim() 
                        //{
                        //    SeeNextClaim();
                        //    _listOfClaim.Dequeue();
                        //}
                        break;
                    
                    //Default
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                        //exit
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        private void SeeAllClaim()
        {
            Queue<Claim> _listofclaim = _claimRepo.SeeAllClaim();
            foreach (Claim claim in _listofclaim)
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"TypeOfClaim:{claim.TypeOfClaim}\n" +
                    $"Description:{claim.Description}\n" +
                    $"ClaimAmount:{claim.ClaimAmount}\n" +
                    $"DateOfIncident:{claim.DateOfIncident}\n" +
                    $"DateOfClaim:{claim.DateOfClaim}\n" +
                    $"IsValid:{claim.IsValid}"
                    );
            }
        }



        private void EnterNewClaim()
        {

            Claim newClaim = new Claim();
            //ClaimID
            Console.WriteLine("Enter ClaimID");
            newClaim.ClaimID = Console.ReadLine();
            //newClaim.ClaimID = newClaim.ClaimID;

            //Type
            Console.WriteLine("Choose Claim type: 1, 2, 3\n" +
                "1 Car \n" +
                "2 Home\n" +
                "3 Theft");
            string userclaimtypeinput = Console.ReadLine();
            //Using convert.toint32 needs to go BEFORE the value you are converting
            int claimTypeID = Convert.ToInt32(userclaimtypeinput);
            ClaimType claimType = (ClaimType)claimTypeID;
            //string ClaimType = Console.ReadLine();
            //newClaim.TypeOfClaim = new TypeOfClaim (ClaimType);

            //Description
            Console.WriteLine("Enter a brief description");
            newClaim.Description = Console.ReadLine();

            //Amount
            Console.WriteLine("Enter the amount of the claim");
            string priceAsString = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(priceAsString);

            //DateOfAccident
            Console.WriteLine("Date of the Incident");
            string dateAsString = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(dateAsString);

            //DateOfClaim
            Console.WriteLine("Date claim was filed");
            string dateAsString2 = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateAsString2);

            



        }
        public void DeleteNextClaim()
        {
            Console.WriteLine("Do you want to deal with this claim now? Please respond yes or no");
            Console.ReadLine();
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Thank you");
                Console.Clear();
            }
            else 
            {
                _claimRepo.SeeNextClaim();
            }
        }
       
        public void SeedContentList()
        {
            Claim claim = new Claim();//Blank constructor

            claim.ClaimID = "4";

            claim.TypeOfClaim = ClaimType.car;

            claim.Description = "Wreck on I-70";

            claim.ClaimAmount = 2000;

            claim.DateOfIncident = new DateTime(2018, 4, 27);

            claim.DateOfClaim = new DateTime(2018, 4, 28);
        }

    }

}





