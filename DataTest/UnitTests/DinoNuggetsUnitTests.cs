using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggetsUnitTests
    {
        /// <summary>
        /// DinoNuggets class should inherit from the Entree class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.IsAssignableFrom<Entree>(wurst);
        }

        /// <summary>
        /// Name should change based on the amount of nuggets.
        /// </summary>
        /// <param name="count">Number of nuggets</param>
        /// <param name="name">Name of nuggets</param>
        [Theory]
        [InlineData(1, "1 Dino Nugget")]
        [InlineData(2, "2 Dino Nuggets")]
        [InlineData(3, "3 Dino Nuggets")]
        [InlineData(4, "4 Dino Nuggets")]
        [InlineData(5, "5 Dino Nuggets")]
        [InlineData(6, "6 Dino Nuggets")]
        public void NameShouldBeCorrect(uint count, string name)
        {
            DinoNuggets nug = new DinoNuggets();
            nug.Count = count;
            Assert.Equal(name, nug.Name);
        }

        /// <summary>
        /// Price should change based on amount of nuggets.
        /// </summary>
        /// <param name="count">The number of dino nuggets</param>
        /// <param name="price">The price of an amount of nuggets</param>
        [Theory]
        [InlineData(1, 0.25)]
        [InlineData(2, 0.50)]
        [InlineData(3, 0.75)]
        [InlineData(4, 1.00)]
        [InlineData(5, 1.25)]
        [InlineData(6, 1.50)]
        public void PriceShouldBeCorrect(uint count, decimal price)
        {
            DinoNuggets nug = new DinoNuggets();
            nug.Count = count;
            Assert.Equal(nug.Price, price);
        }

        /// <summary>
        /// The calories should change based on the amount of nuggets.
        /// </summary>
        /// <param name="count">Number of dino nuggets </param>
        /// <param name="calories">Calories of all dino nuggets</param>
        [Theory]
        [InlineData(1, 61)]
        [InlineData(2, 122)]
        [InlineData(3, 183)]
        [InlineData(4, 244)]
        [InlineData(5, 305)]
        [InlineData(6, 366)]
        public void CaloriesShouldBeCorrect(uint count, uint calories)
        {
            DinoNuggets nug = new DinoNuggets();
            nug.Count = count;
            Assert.Equal(nug.Calories, calories);
        }
        
        /// <summary>
        /// The amount of nuggets should default to 6.
        /// </summary>
        [Fact]
        public void CountShouldDefaultToSix()
        {
            DinoNuggets nug = new DinoNuggets();
            Assert.True(6 == nug.Count);
        }

        /// <summary>
        /// The count should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCount()
        {
            DinoNuggets nug = new DinoNuggets();
            nug.Count = 2;
            Assert.True(2 == nug.Count);
            nug.Count = 4;
            Assert.True(4 == nug.Count);
            nug.Count = 6;
            Assert.True(6 == nug.Count);
        }

        /// <summary>
        /// Changing the count should notify of certain property changes.
        /// </summary>
        /// <param name="count">number of nuggets</param>
        /// <param name="propertyName">name of the property being changed</param>
        [Theory]
        [InlineData(1,"Count")]
        [InlineData(2, "Count")]
        [InlineData(3, "Name")]
        [InlineData(4, "Name")]
        [InlineData(5, "Price")]
        [InlineData(6, "Price")]
        [InlineData(7, "Calories")]
        [InlineData(8, "Calories")]
        public void ChangingCountShouldNotifyOfPropertyChanges(uint count, string propertyName)
        {
            DinoNuggets nugs = new DinoNuggets();
            Assert.PropertyChanged(nugs, propertyName, () => { nugs.Count = count; });
        }
    }
}
