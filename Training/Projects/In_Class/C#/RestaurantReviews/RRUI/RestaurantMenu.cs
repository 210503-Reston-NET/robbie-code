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
            Console.WriteLine("[1] Go Back.");
            string input = Console.ReadLine();

            switch(input)
            {
                case "0":
                    ViewRestaurants();
                    break;
                case "1":
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            }
            while(repeat);
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