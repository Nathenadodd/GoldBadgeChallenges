using CafeRepository2;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsoleApp2
{
    class ProgramUI
    {
        CafeRepository _contentRepo = new CafeRepository();

        //method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Select a menu option:\n" +
                    "1.View all items on meal list\n" +
                    "2.Add items to meal list\n" +
                    "3.Remove items from meal list\n" +
                    "4.Exit");

                //Get user input
                string input = Console.ReadLine();
                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //View all items on meal list
                        DisplayAllContent();
                        break;
                    case "2":
                        //Add items 
                        CreateNewContent();
                        break;
                    case "3":
                        //Remove item from meal list
                        DeleteExistingContent();
                        break;
                    case "4":
                        //Exit
                        keepRunning = false;
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
        //View existing menu by mealnumber

        private void DisplayAllContent()
        {
            List<Meal> _listofMeal = _contentRepo.GetMealList();
            foreach (Meal content in _listofMeal)
            {
                Console.WriteLine($"MealNumber: {content.MealNumber}\n" +
                    $"Name: {content.Name}\n" +
                    $"Description: {content.Description}\n" +
                    $"Ingredients: {content.Ingredients}\n" +
                    $"Price: {content.Price}"
                    );
            }

        }
        //add items to menu
        private void CreateNewContent()
        {
            Meal newContent = new Meal();

            //MealNumber 
            Console.WriteLine("Enter the number for the meal:");
            newContent.MealNumber = Console.ReadLine();

            // Name 
            Console.WriteLine("Enter the name of the meal");
            newContent.Name = Console.ReadLine();
            //     Description 
            Console.WriteLine("Enter the description of the meal");
            newContent.Description = Console.ReadLine();

            //   Ingredients
            Console.WriteLine("Enter the ingredients used in the meal");
            newContent.Ingredients = Console.ReadLine();

            //    Price
            Console.WriteLine("Enter the price of the meal(9.95, 10.95, 11.95 etc)");
            string priceAsString = Console.ReadLine();
            newContent.Price = double.Parse(priceAsString);
            _contentRepo.AddMealToList(newContent);


        }

        //Delete by number
        private void DeleteExistingContent()
        {
            Console.WriteLine("Enter the number of the meal you would like to delete");
            string input = Console.ReadLine();
            _contentRepo.RemoveMealFromList(input);
        }
        private void SeedContentList()
        {
            _contentRepo.AddMealToList(new Meal("#1", "Chicken Classic", "Fried chicken breast with Rice, steamed cabbage, and corn bread","Breaded & deep fried chicken, seasoned and steamed cabbage, Mama's homemade cornbread", 11.95));

            _contentRepo.AddMealToList(new Meal("#2", "Country Ham", "Country ham with mashed potatoes, brown gravy, corn and Mama's sweet rolls","ham, mashed potatoes, brown gravy, corn, sweet rolls", 11.95));

            _contentRepo.AddMealToList(new Meal("#3", "Mama's Chili", "A bottomless bowl of Mama's super secret famous chili","ground beef, chili powder, assorted spices, beans, veggies", 9.95));
        }
    }
}
