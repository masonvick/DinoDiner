using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Enums;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Meteor Mac and Cheese class.
    /// </summary>
    public class MeteorMacAndCheeseUnitTests
    {
        /// <summary>
        /// Class should be inheriting from the Side class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.IsAssignableFrom<Side>(mac);
        }

        /// <summary>
        /// The name of the side should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="name">name of the side</param>
        [Theory]
        [InlineData(ServingSize.Medium, "Medium Meteor Mac & Cheese")]
        [InlineData(ServingSize.Small, "Small Meteor Mac & Cheese")]
        [InlineData(ServingSize.Large, "Large Meteor Mac & Cheese")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.Equal(mac.Name, name);
        }

        /// <summary>
        /// The price of the side should change based on the size.
        /// </summary>
        /// <param name="size">the size of the side</param>
        /// <param name="price">the price of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.5)]
        [InlineData(ServingSize.Medium, 4)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.Equal(mac.Price, price);
        }

        /// <summary>
        /// The calories should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="calories">calories of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, 365)]
        [InlineData(ServingSize.Medium, 465)]
        [InlineData(ServingSize.Large, 510)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.Equal(mac.Calories, calories);
        }

        /// <summary>
        /// The size of the entree should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, mac.Size);
            mac.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, mac.Size);
            mac.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, mac.Size);
        }

        /// <summary>
        /// Changing the size should notify of certain property changes.
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="propertyName">name of the property being changed</param>
        [Theory]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Small, "Calories")]
        [InlineData(ServingSize.Medium, "Calories")]
        [InlineData(ServingSize.Large, "Calories")]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Name")]
        public void ChangingSizeShouldNotifyOfPropertyChanges(ServingSize size, string propertyName)
        {
            MeteorMacAndCheese mac = new();
            Assert.PropertyChanged(mac, propertyName, () => { mac.Size = size; });
        }
    }
}
