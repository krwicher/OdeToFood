using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class List : PageModel
    {
        private readonly IRestaurantData _data;

        public List(IRestaurantData data)
        {
            _data = data;
        }

        public void OnGet()
        {
            
        }
    }
}