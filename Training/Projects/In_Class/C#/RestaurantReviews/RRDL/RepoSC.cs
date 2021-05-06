using RRModels;
using System.Collections.Generic;

namespace RRDL


{
    /// <summary>
    /// Implementation of the IRepository that stores data in a Static Collection(SC)
    /// </summary>
    public class RepoSC : IRepository
    {
        public List<Restaurant> ReadAllRestaurants()
        {
            //Todo return a static collection of restaurants
            return RRSCStorage.Restaurants;
        }
    }
}