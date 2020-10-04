using BadgesRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsole
{
    class ProgramUI
    {
        public static BadgeRepo _badgeRepo = new BadgeRepo();
      
        //method that runs/starts the application
        public void Run()
        {
            //SeedContentList();
            // MenuCommand();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello, Security Admin, What would you like to do?\n" +
                    "1 Add a badge\n" +
                    "2 Edit a badge\n" +
                    "3 List all Badges\n" +
                    "4 Exit");

                //Get user input
                string userresponseforbadgeinput = Console.ReadLine();
                //Evaluate the user's input and act accordingly
                switch (userresponseforbadgeinput)
                {
                    case "1":
                        //AddABadge
                        CreateNewBadge();
                        break;
                    case "2":
                        //EditABadge
                        EditABadge();
                        break;
                    case "3":
                        //ListAllBadges
                        ListAllBadges();
                        break;

                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.Clear();

            }
        }
        //View All Badges
        
        private void UpdateABadge()
        {            
            
        Console.WriteLine("Enter badge ID of the badge to update.");
            int badgeID = Convert.ToInt32(Console.ReadLine());
           Badge badge = _badgeRepo.GetABadge(badgeID);
            //Console.WriteLine("What would you like to do?\n" +
            //  "1 Remove a door\n" +
            //"2 Add a door");
        string userinputfordooroptions = Console.ReadLine();
            //Evaluate User Input
            switch (userinputfordooroptions)
            {
                case "1":
                    EliminateDoor();
                    break;
                case "2":
                    PlusADoor();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }

        //Helper Method
        private void CreateNewBadge() 
        {
            Badge badge = new Badge();
            //Input BadgeID
            
            Console.WriteLine("What is the number on the badge: ex: 12345");
            int badgeID = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Door that it needs access to

            bool keepAddingDoors;
            List<string> doorAccess = new List<string>();
            do
            {

                Console.WriteLine("List a door that it needs access to: ex: A5");
                
               doorAccess.Add(Console.ReadLine());
                Console.WriteLine("Any other doors(y/n)? ex: y");
                if (Console.ReadLine().ToLower() == "y")
                {
                    keepAddingDoors = true;
                }
                else
                {
                    keepAddingDoors = false;
                }
                
            }
            while (keepAddingDoors == true);
            Console.Clear();
            Console.WriteLine($" Badge ID :{badgeID}\n" +
                $" Accessible Doors: {doorAccess}\n" +
                $"\n" +
                $"\n" +
                $"Add badge to database? y/n ");
            if (Console.ReadLine() == "y") 
            {
                badge.BadgeID = badgeID;
                badge.DoorAccess = doorAccess;

            }

            _badgeRepo.AddABadge(badge);

        }
        private void EliminateDoor() 
        {
            Console.WriteLine("Which badge ID do you need to eliminate a door from? ex: A5");
            

        }
        private void PlusADoor() 
        {
            Console.WriteLine("Which badge ID do you need to plus a door to? ex: B7");
        }

        //public static 12345  = new(
        //    "\n +
        //   \n
        // "Doors are A7")

        //public static 22345  = new(
        //    "\n +
        //   \n
        // "Doors are A1,A4,B1,B2")

        //public static Badge 32345  = new Badge(
        //    "\n" +
        //   "\n"         

        //" Doors are A4, A5"
        //    new List<string> { A4,A5 }
    }
          
   
}
//Console.WriteLine("Which door would you like to remove?");
//Console.ReadLine();
//Console.WriteLine("Door Removed.");

//Helper Method

//SeedContentList
//Add a badge
//

//

//

//Console.WriteLine("List a door that it needs access to: A7");

//Console.WriteLine("Any other doors(y / n) ? ");
//Console.ReadLine("n");


//Update a badge
//Console.WriteLine(" What is the badge number to update? 12345");

//12345 has access to doors A5 & A7.

//Console.WriteLine("What would you like to do?");

//Remove a door
//Add a door
//> 1

//Console.WriteLine("Which door would you like to remove? A5")

// Console.WriteLine("Door removed.");

//12345 has access to door A7.

//#3 List all badges view
//Badge #	Door Access
//12345   A7
//22345   A1, A4, B1, B2
//32345   A4, A5