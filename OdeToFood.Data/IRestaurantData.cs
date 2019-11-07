using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Location = "loc1",
                    Name = "name1",
                    CuisineType = CuisineType.Indian
                },
                new Restaurant()
                {
                    Id = 2,
                    Location = "loc2",
                    Name = "name2",
                    CuisineType = CuisineType.Italian
                },
                new Restaurant()
                {
                    Id = 3,
                    Location = "loc3",
                    Name = "name3",
                    CuisineType = CuisineType.Mexican
                },
                new Restaurant()
                {
                    Id = 4,
                    Location = "loc4",
                    Name = "name4",
                    CuisineType = CuisineType.None
                }
            };
        }
        
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in _restaurants
                orderby r.Name
                select r;
        }
    }
}