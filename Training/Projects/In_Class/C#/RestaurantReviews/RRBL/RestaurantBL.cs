using System.Collections.Generic;
using RRModels;
using RRDL;

namespace RRBL
{
    /// <summary>
    /// Bussiness Logic class for the restaurant model
    /// </summary>
    /// <returns></returns>
    public class RestaurantBL: IRestaurantBL
    {
        // Some things to note:
        // BL classes are in charge of processing. sanitizing. further validating data
        // As the name suggests, its in charge of processing logic. Like, how does the ordering process work
        // in a storeApp
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the Data Layer(DL)
        private IRepository _repo;
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        }
        public List<Restaurant> GetAllRestaurants()
        {
            // Note that this method isn't depended on any inputs/parameters, i can just directly call the 
            // DL method in charge of getting all restaurants.
            return _repo.ReadAllRestaurants();
        }
    }
}