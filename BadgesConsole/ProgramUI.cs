using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsole
{
    class ProgramUI
    {
        BadgeRepo _contentRepo = new BadgeRepo();
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
                        AddABadge();
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
        private void ListAllBadges() 
        {
        
        }
        private void EditABadge() 
        {
        
        }
        private void AddABadge() 
        {
        
        }
    }
}
 