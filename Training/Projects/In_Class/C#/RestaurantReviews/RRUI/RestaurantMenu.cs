using System;
using RRModels;
using RRBL;
using System.Collections.Generic;

namespace RRUI

{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;

        public RestaurantMenu(IRestaurantBL restaurantBL)
        {
            _restaurantBL = restaurantBL;
        }
        public void Start()
        {
            bool repeat = true;
            
            do{
            Console.WriteLine("Welcome to my restaurant Reviews Application!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[0] View Restraunt.");
            Console.WriteLine("[1] View Restraunt.");
            Console.WriteLine("[2] Go Back.");
            string input = Console.ReadLine();

            switch(input)
            {
                case "0":
                    ViewRestaurants();
                    break;
                case "1":
                    AddARestaurant();
                    break;
                case "2":
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            }
            while(repeat);
        }

        private void AddARestaurant()
        {
            System.Console.WriteLine("Enter the details of the restaurant you want to add");
            // Want to make sure end user doesn't input nothing
            // Come up with some validation to valdate the input I'm Recieving
            System.Console.WriteLine("Please Enter a Name");

        }

        public void ViewRestaurants()
        {
            List<Restaurant> results =  _restaurantBL.GetAllRestaurants();
            foreach(Restaurant restaurant in results)
            {
                Console.WriteLine(restaurant.ToString());
            }
        }

        
    }
}