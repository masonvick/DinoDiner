using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Cretaceous Coffee class.
    /// </summary>
    public class CretaceousCoffeeUnitTests
    {
        /// <summary>
        /// This class should inherit from the Drink class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromDrink()
        {
            CretaceousCoffee coffee = new();
            Assert.IsAssignableFrom<Drink>(coffee);
        }

        /// <summary>
        /// The name should change according to the Size.
        /// </summary>
        /// <param name="size">size of the coffee</param>
        /// <param name="name">name of the coffee</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Cretaceous Coffee")]
        [InlineData(ServingSize.Medium, "Medium Cretaceous Coffee")]
        [InlineData(ServingSize.Large, "Large Cretaceous Coffee")]
        public void NameShouldBeCorrect(ServingSize size, String name)
        {
            CretaceousCoffee coffee = new();
            coffee.Size = size;
            Assert.Equal(name, coffee.Name);
        }

        /// <summary>
        /// Price should change depending on the Size.
        /// </summary>
        /// <param name="size">size of the coffee</param>
        /// <param name="price">price of the coffee</param>
        [Theory]
        [InlineData(ServingSize.Small, .75)]
        [InlineData(ServingSize.Medium, 1.25)]
        [InlineData(ServingSize.Large, 2.00)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            CretaceousCoffee coffee = new();
            coffee.Size = size;
            Assert.Equal(price, coffee.Price);
        }

        /// <summary>
        /// THe calories shoudl change based on if there is cream or not.
        /// </summary>
        /// <param name="cream">bool if there is cream</param>
        /// <param name="calories">calories of the coffee</param>
        [Theory]
        [InlineData(true, 64)]
        [InlineData(false, 0)]
        public void CaloriesShouldBeCorrect(bool cream, uint calories)
        {
            CretaceousCoffee coffee = new();
            coffee.Cream = cream;
            Assert.Equal(calories, coffee.Calories);
        }

        /// <summary>
        /// The Size should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CretaceousCoffee coffee = new();
            coffee.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, coffee.Size);
            coffee.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, coffee.Size);
            coffee.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, coffee.Size);
        }

        /// <summary>
        /// The Cream should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCream()
        {
            CretaceousCoffee coffee = new();
            coffee.Cream = true;
            Assert.True(coffee.Cream);
            coffee.Cream = false;
            Assert.False(coffee.Cream);
        }
        
        /// <summary>
        /// There should be no cream on the coffee by default.
        /// </summary>
        [Fact]
        public void CreamShouldDefaultToFalse()
        {
            CretaceousCoffee coffee = new();
            Assert.False(coffee.Cream);
        }

        /// <summary>
        /// Changing the size should notify of certain property changes.
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Name")]
        public void ChangingSizeShouldNotifyOfPropertyChanges(ServingSize size, string propertyName)
        {
            CretaceousCoffee coffee = new CretaceousCoffee();
            Assert.PropertyChanged(coffee, propertyName, () => { coffee.Size = size; });
        }

        /// <summary>
        /// Changing the cream should notify of certain property changes.
        /// </summary>
        /// <param name="cream">number of cream</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Cream")]
        [InlineData(false, "Cream")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingCreamShouldNotifyOfPropertyChanges(bool cream, string propertyName)
        {
            CretaceousCoffee coffee = new CretaceousCoffee();
            Assert.PropertyChanged(coffee, propertyName, () => { coffee.Cream = cream; });
        }
    }
}
