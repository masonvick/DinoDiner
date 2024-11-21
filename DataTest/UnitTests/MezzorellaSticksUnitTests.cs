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
    /// Unit Tests for the MezzorellaSticks class.
    /// </summary>
    public class MezzorellaSticksUnitTests
    {
        /// <summary>
        /// Class should be inheriting from the Side class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MezzorellaSticks sticks = new MezzorellaSticks();
            Assert.IsAssignableFrom<Side>(sticks);
        }

        /// <summary>
        /// The name of the side should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="name">name of the side</param>
        [Theory]
        [InlineData(ServingSize.Medium, "Medium Mezzorella Sticks")]
        [InlineData(ServingSize.Small, "Small Mezzorella Sticks")]
        [InlineData(ServingSize.Large, "Large Mezzorella Sticks")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            MezzorellaSticks sticks = new MezzorellaSticks();
            sticks.Size = size;
            Assert.Equal(sticks.Name, name);
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
            MezzorellaSticks sticks = new MezzorellaSticks();
            sticks.Size = size;
            Assert.Equal(sticks.Price, price);
        }

        /// <summary>
        /// The calories should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="calories">calories of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, 530)]
        [InlineData(ServingSize.Medium, 620)]
        [InlineData(ServingSize.Large, 730)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MezzorellaSticks sticks = new MezzorellaSticks();
            sticks.Size = size;
            Assert.Equal(sticks.Calories, calories);
        }

        /// <summary>
        /// The size of the entree should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MezzorellaSticks sticks = new MezzorellaSticks();
            sticks.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, sticks.Size);
            sticks.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, sticks.Size);
            sticks.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, sticks.Size);
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
            MezzorellaSticks sticks = new();
            Assert.PropertyChanged(sticks, propertyName, () => { sticks.Size = size; });
        }
    }
}
