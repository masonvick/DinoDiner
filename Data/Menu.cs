using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data
{
    /// <summary>
    /// Class that represents all items on the Dino Diner menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the category of an item (entree, side, drink).
        /// </summary>
        public static string[] FoodTypes
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }


        /// <summary>
        /// Returns an order with all of the entrees on the menu.
        /// </summary>
        /// <returns>Order containing entrees</returns>
        public static IEnumerable<MenuItem> Entrees()
        {
            Order entrees = new()
            {
                new AllosaurusAll_AmericanBurger(),
                new CarnotaurusCheeseburger(),
                new DeinonychusDouble(),
                new TRexTriple(),
                new Brontowurst(),
                new DinoNuggets(),
                new PrehistoricPBJ(),
                new PterodactylWings(),
                new VelociWraptor(),
            };
            return entrees;
        }

        /// <summary>
        /// Returns an order with all sides on the menu, including one for each size.
        /// </summary>
        /// <returns>Order with all sides</returns>
        public static IEnumerable<MenuItem> Sides()
        {

            Fryceritops smallFry = new() { Size = ServingSize.Small };
            Fryceritops mediumFry = new() { Size = ServingSize.Medium };
            Fryceritops largeFry = new() { Size = ServingSize.Large };

            MeteorMacAndCheese smallMac = new() { Size = ServingSize.Small };
            MeteorMacAndCheese mediumMac = new() { Size = ServingSize.Medium };
            MeteorMacAndCheese largeMac = new() { Size = ServingSize.Large };

            MezzorellaSticks smallSticks = new() { Size = ServingSize.Small };
            MezzorellaSticks mediumSticks = new() { Size = ServingSize.Medium };
            MezzorellaSticks largeSticks = new() { Size = ServingSize.Large };

            Triceritots smallTots = new() { Size = ServingSize.Small };
            Triceritots mediumTots = new() { Size = ServingSize.Medium };
            Triceritots largeTots = new() { Size = ServingSize.Large };

            Order sides = new()
            {
                smallFry, mediumFry, largeFry,
                smallMac, mediumMac, largeMac,
                smallSticks, mediumSticks, largeSticks,
                smallTots, mediumTots, largeTots,
            };

            return sides;
        }

        /// <summary>
        /// Returns all drinks on the menu, including one for each size.
        /// </summary>
        /// <returns>Order containing the drinks</returns>
        public static IEnumerable<MenuItem> Drinks()
        {
            Plilosoda smallSoda = new() { Size = ServingSize.Small };
            Plilosoda mediumSoda = new() { Size = ServingSize.Medium };
            Plilosoda largeSoda = new() { Size = ServingSize.Large };

            CretaceousCoffee smallCoffee = new() { Size = ServingSize.Small };
            CretaceousCoffee mediumCoffee = new() { Size = ServingSize.Medium };
            CretaceousCoffee largeCoffee = new() { Size = ServingSize.Large };

            Order drinks = new()
            {
                smallSoda, mediumSoda, largeSoda,
                smallCoffee, mediumCoffee, largeCoffee,
            };

            return drinks;
        }

        /// <summary>
        /// Returns the full menu with entrees, sides, and drinks, with one for each size if the menu item has the option.
        /// </summary>
        /// <returns>Order containing all menu items</returns>
        public static IEnumerable<MenuItem> FullMenu()
        {


        //SIZES FOR SIDES
            Fryceritops smallFry = new() { Size = ServingSize.Small };
            Fryceritops mediumFry = new() { Size = ServingSize.Medium };
            Fryceritops largeFry = new() { Size = ServingSize.Large };

            MeteorMacAndCheese smallMac = new() { Size = ServingSize.Small };
            MeteorMacAndCheese mediumMac = new() { Size = ServingSize.Medium };
            MeteorMacAndCheese largeMac = new() { Size = ServingSize.Large };

            MezzorellaSticks smallSticks = new() { Size = ServingSize.Small };
            MezzorellaSticks mediumSticks = new() { Size = ServingSize.Medium };
            MezzorellaSticks largeSticks = new() { Size = ServingSize.Large };

            Triceritots smallTots = new() { Size = ServingSize.Small };
            Triceritots mediumTots = new() { Size = ServingSize.Medium };
            Triceritots largeTots = new() { Size = ServingSize.Large };


        //SIZES FOR DRINKS
            Plilosoda smallSoda = new() { Size = ServingSize.Small };
            Plilosoda mediumSoda = new() { Size = ServingSize.Medium };
            Plilosoda largeSoda = new() { Size = ServingSize.Large };

            CretaceousCoffee smallCoffee = new() { Size = ServingSize.Small };
            CretaceousCoffee mediumCoffee = new() { Size = ServingSize.Medium };
            CretaceousCoffee largeCoffee = new() { Size = ServingSize.Large };


            Order fullMenu = new Order()
            {
                new AllosaurusAll_AmericanBurger(),
                new CarnotaurusCheeseburger(),
                new DeinonychusDouble(),
                new TRexTriple(),
                new Brontowurst(),
                new DinoNuggets(),
                new PrehistoricPBJ(),
                new PterodactylWings(),
                new VelociWraptor(),

                smallFry, mediumFry, largeFry,
                smallMac, mediumMac, largeMac,
                smallSticks, mediumSticks, largeSticks,
                smallTots, mediumTots, largeTots,

                smallSoda, mediumSoda, largeSoda,
                smallCoffee, mediumCoffee, largeCoffee,
            };

            return fullMenu;
        }
    }
}
