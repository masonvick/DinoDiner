using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Data;
using DinoDiner.Data.Enums;
using System.Linq;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<MenuItem> OrderItems { get; protected set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            FoodTypes = new string[3];
        }

        public string SearchTerms { get; set; }

        public string[] FoodTypes { get; set; }

        public void OnGet(string SearchTerms, string[] FoodTypes, decimal? PriceMin, decimal? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            OrderItems = Menu.FullMenu();

            // Search movie titles for the SearchTerms
            if (SearchTerms != null)
            {
                OrderItems = OrderItems.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            // Filter by FoodType
            if (FoodTypes != null && FoodTypes.Length != 0)
            {
                OrderItems = OrderItems.Where(item =>
                    item.FoodType != null &&
                    FoodTypes.Contains(item.FoodType)
                    );
            }
            // Filter by Price
            if (PriceMin != null || PriceMax != null)
            {
                if (PriceMin == null)
                {
                    OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
                }
                else if (PriceMax == null)
                {
                    OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
                    OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
                }
            }
            // Filter by Calories
            if (CaloriesMin != null || CaloriesMax != null)
            {
                if (CaloriesMin == null)
                {
                    OrderItems = OrderItems.Where(item => item.Calories <= CaloriesMax);
                }
                else if (PriceMax == null)
                {
                    OrderItems = OrderItems.Where(item => item.Calories >= CaloriesMin);
                }
                else
                {
                    OrderItems = OrderItems.Where(item => item.Calories <= CaloriesMax);
                    OrderItems = OrderItems.Where(item => item.Calories >= CaloriesMin);
                }
            }
        }
    }
}