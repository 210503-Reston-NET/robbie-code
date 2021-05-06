using System.Collections.Generic;
using RRModels;

namespace RRDL

{
    /// <summary>
    /// Restaurant Reviews static collection storage
    /// </summary>
    public class RRSCStorage
    {
        public static List<Restaurant> Restaurants = new List<Restaurant>(new Restaurant("This is a name", "City", "State"));
    }
}