using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI

{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;

            List<Restaurant> Restaurants = new List<Restaurant>();

            do{
            Console.WriteLine("Welcome to my restaurant Reviews Application!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[0] Add a restaurant.");
            Console.WriteLine("[1] Exit.");
            string input = Console.ReadLine();

            switch (input){
                case "0":
                    //add a restaurant
                    Console.WriteLine("Please give name of restaurant.");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Please give name of City that the restaurant resides.");
                    string City = Console.ReadLine();
                    Console.WriteLine("Please give name of State that the restaurant resides.");
                    string State = Console.ReadLine();
                    try {
                        Restaurants.Add(addRestaurant(Name, City, State));
                        Console.Write("Added " + Name + " to list of restaurant.");
                    }
                    catch (Exception e){
                    }
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