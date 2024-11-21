using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;
using Xunit;
using Xunit.Abstractions;


namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit tests for the Menu.cs class.
    /// </summary>
    public class MenuUnitTests
    {
        /// <summary>
        /// Tests to make sure the entree menu has the correct number of entrees.
        /// </summary>
        [Fact]
        public void EntreeMenuShouldHaveCorrectNumberOfEntrees()
        {
            IEnumerable<MenuItem> items = Menu.Entrees();

            Assert.Collection(items,
                item =>
                {
                    Assert.Equal(item.ToString(), new AllosaurusAll_AmericanBurger().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CarnotaurusCheeseburger().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DeinonychusDouble().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new TRexTriple().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new Brontowurst().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DinoNuggets().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new PrehistoricPBJ().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new PterodactylWings().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VelociWraptor().ToString());
                });
        }

        /// <summary>
        /// Tests to make sure the sides menu has the correct number of sides.
        /// </summary>
        [Fact]
        public void SidesMenuShouldHaveCorrectNumberOfSides()
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


            IEnumerable<MenuItem> items = Menu.Sides();

            Assert.Collection(items,
                item => { Assert.Equal(item.ToString(), smallFry.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumFry.ToString()); },
                item => { Assert.Equal(item.ToString(), largeFry.ToString()); },

                item => { Assert.Equal(item.ToString(), smallMac.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumMac.ToString()); },
                item => { Assert.Equal(item.ToString(), largeMac.ToString()); },

                item => { Assert.Equal(item.ToString(), smallSticks.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumSticks.ToString()); },
                item => { Assert.Equal(item.ToString(), largeSticks.ToString()); },

                item => { Assert.Equal(item.ToString(), smallTots.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumTots.ToString()); },
                item => { Assert.Equal(item.ToString(), largeTots.ToString()); }
                );
        }

        /// <summary>
        /// Test to make sure the drink menu has the correct number of drinks.
        /// </summary>
        [Fact]
        public void DrinkMenuShouldHaveCorrectNumberOfDrinks()
        {
            Plilosoda smallSoda = new() { Size = ServingSize.Small };
            Plilosoda mediumSoda = new() { Size = ServingSize.Medium };
            Plilosoda largeSoda = new() { Size = ServingSize.Large };

            CretaceousCoffee smallCoffee = new() { Size = ServingSize.Small };
            CretaceousCoffee mediumCoffee = new() { Size = ServingSize.Medium };
            CretaceousCoffee largeCoffee = new() { Size = ServingSize.Large };

            IEnumerable<MenuItem> items = Menu.Drinks();

            Assert.Collection(items,
                item => { Assert.Equal(item.ToString(), smallSoda.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumSoda.ToString()); },
                item => { Assert.Equal(item.ToString(), largeSoda.ToString()); },

                item => { Assert.Equal(item.ToString(), smallCoffee.ToString()); },
                item => { Assert.Equal(item.ToString(), mediumCoffee.ToString()); },
                item => { Assert.Equal(item.ToString(), largeCoffee.ToString()); });
        }


    }
}
