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
    /// Unit Tests for the Triceritots class.
    /// </summary>
    public class TriceritotsUnitTests
    {
        /// <summary>
        /// Class should be inheriting from the Side class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Triceritots tots = new Triceritots();
            Assert.IsAssignableFrom<Side>(tots);
        }

        /// <summary>
        /// The name of the side should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="name">name of the side</param>
        [Theory]
        [InlineData(ServingSize.Medium, "Medium Triceritots")]
        [InlineData(ServingSize.Small, "Small Triceritots")]
        [InlineData(ServingSize.Large, "Large Triceritots")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.Equal(tots.Name, name);
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
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.Equal(tots.Price, price);
        }

        /// <summary>
        /// The calories should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="calories">calories of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, 351)]
        [InlineData(ServingSize.Medium, 409)]
        [InlineData(ServingSize.Large, 583)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.Equal(tots.Calories, calories);
        }

        /// <summary>
        /// The size of the entree should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Triceritots tots = new Triceritots();
            tots.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, tots.Size);
            tots.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, tots.Size);
            tots.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, tots.Size);
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
            Triceritots tots = new();
            Assert.PropertyChanged(tots, propertyName, () => { tots.Size = size; });
        }
    }
}
