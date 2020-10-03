using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CafeRepository2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeUnitTest2
{
    [TestClass]
   public class UnitTest2
    {
       private CafeRepository _Repo = new CafeRepository();
        public void SeedRepository()
        // SeedContentList
        {
            Meal meal = new Meal();//Blank constructor
            meal.MealNumber = "5";
            meal.Name = "hamburger";
            meal.Description = "Steak, potato, broccoli";
            meal.Ingredients = "Steak, baked potato, steamed broccoli";
            meal.Price = 13.95;
            //Full constructor
            Meal Steak = new Meal("4", "Steak", "Steak, potato, broccoli", "Steak, baked potato, steamed broccoli", 13.95);

            _Repo.AddMealToList(Steak);
            _Repo.AddMealToList(meal);


        }
            //only test methods
            [TestMethod]
            public void DisplayAllContent()
            {
            //Arrange
            SeedRepository();
            //Act
            List<Meal> list = _Repo.GetMealList();
            int actual = list.Count;
            //Assert
            Assert.AreEqual(2, actual);
            }

        [TestMethod]
        public void CreateNewContentShouldIncreaseCount()
        {
            //Arrange
            SeedRepository();
            Meal Steak = new Meal("4", "Steak", "Steak, potato, broccoli", "Steak, baked potato, steamed broccoli", 13.95);
            //Act
            _Repo.AddMealToList(Steak);           
            List<Meal> list = _Repo.GetMealList();
            int actual = list.Count;
            //Assert
            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void RemoveMealFromList()
        {
            //Arrange
            SeedRepository();
            Meal Steak = new Meal("4", "Steak", "Steak, potato, broccoli", "Steak, baked potato, steamed broccoli", 13.95);
            //Act
            bool actual = _Repo.RemoveMealFromList("4");


            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void GetMealByNumber()
        {
            //Arrange
            SeedRepository();
            //Act
            Meal hamburger = _Repo.GetMealByNumber("5");
            //Assert
            Assert.AreEqual("hamburger",hamburger.Name);
            

        }
    }

}

