using System;
using RRBL;
using RRModels;
using System.Collections.Generic;

namespace RRUI

{
    public class MainMenu : IMenu
    {
        public IMenu subMenu;
        public void Start()
        {
            bool repeat = true;

            List<Restaurant> Restaurants = new List<Restaurant>();

            do{
            Console.WriteLine("Welcome to my restaurant Reviews Application!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[0] CRUD restaurant.");
            Console.WriteLine("[1] Exit.");
            string input = Console.ReadLine();

            switch (input){
                case "0":
                    subMenu = new RestaurantMenu(new RestaurantBL(new RepoSC()));
                    subMenu.Start();
                    break;
                case "1":
                // Exit
                    Console.WriteLine("Goodbye cruel world.");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Please input a valid option.");
                    break;
            }
            } while(repeat);

            
        }

        private Restaurant addRestaurant(string name, string city, string state)
        {
            Restaurant Restaurant = new Restaurant(name, city, state);
            return Restaurant;
        }
    }
}