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
    /// Unit Tests for the Fryceritops class.
    /// </summary>
    public class FryceritopsUnitTests
    {
        /// <summary>
        /// Class should be inheriting from the Side class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Fryceritops fry = new Fryceritops();
            Assert.IsAssignableFrom<Side>(fry);
        }

        /// <summary>
        /// The name of the side should change based on the size.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="name">name of the side</param>
        [Theory]
        [InlineData(ServingSize.Medium, "Medium Fryceritops")]
        [InlineData(ServingSize.Small, "Small Fryceritops")]
        [InlineData(ServingSize.Large, "Large Fryceritops")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            Fryceritops fry = new Fryceritops();
            fry.Size = size;
            Assert.Equal(fry.Name, name);
        }

        /// <summary>
        /// The price of the side should change based on the size.
        /// </summary>
        /// <param name="size">the size of the side</param>
        /// <param name="price">the price of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.5)]
        [InlineData(ServingSize.Medium, 4)]
        [InlineData(ServingSize.Large, 5)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Fryceritops fry = new Fryceritops();
            fry.Size = size;
            Assert.Equal(fry.Price, price);
        }

        /// <summary>
        /// The calories should change based on the size and if there's sauce.
        /// </summary>
        /// <param name="size">size of the side</param>
        /// <param name="sauce">sauce on the side</param>
        /// <param name="calories">calories of the side</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 445)]
        [InlineData(ServingSize.Medium, true, 545)]
        [InlineData(ServingSize.Large, true, 590)]
        [InlineData(ServingSize.Small, false, 365)]
        [InlineData(ServingSize.Medium, false, 465)]
        [InlineData(ServingSize.Large, false, 510)]
        public void CaloriesShouldBeCorrect(ServingSize size, bool sauce, uint calories)
        {
            Fryceritops fry = new Fryceritops();
            fry.Size = size;
            fry.Sauce = sauce;
            Assert.Equal(fry.Calories, calories);
        }

        /// <summary>
        /// The size of the entree should have the ability to set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Fryceritops fry = new Fryceritops();
            fry.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, fry.Size);
            fry.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, fry.Size);
            fry.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, fry.Size);
        }

        /// <summary>
        /// The side should come with salt by default.
        /// </summary>
        [Fact]
        public void SaltShouldDefaultToTrue()
        {
            Fryceritops fry = new Fryceritops();
            Assert.True(fry.Salt);
        }

        /// <summary>
        /// The salt needs to have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalt()
        {
            Fryceritops fry = new Fryceritops();
            fry.Salt = false;
            Assert.False(fry.Salt);
            fry.Salt = true;
            Assert.True(fry.Salt);
        }

        /// <summary>
        /// The side should not come with sauce by default.
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToFalse()
        {
            Fryceritops fry = new Fryceritops();
            Assert.False(fry.Sauce);
        }
        
        /// <summary>
        /// Sauce needs to have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            Fryceritops fry = new Fryceritops();
            fry.Sauce = false;
            Assert.False(fry.Sauce);
            fry.Sauce = true;
            Assert.True(fry.Sauce);
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
            Fryceritops nugs = new();
            Assert.PropertyChanged(nugs, propertyName, () => { nugs.Size = size; });
        }

        /// <summary>
        /// Changing the salt should notify of certain property changes.
        /// </summary>
        /// <param name="salt">bool for salt</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true,"Salt")]
        [InlineData(false, "Salt")]
        public void ChangingSaltShouldNotifyOfPropertyChanges(bool salt, string propertyName)
        {
            Fryceritops fries = new();
            Assert.PropertyChanged(fries, propertyName, () => { fries.Salt = salt; });
        }

        /// <summary>
        /// Changing the sauce should notify of certain property changes.
        /// </summary>
        /// <param name="sauce">bool for sauce</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Sauce")]
        [InlineData(false, "Sauce")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingSauceShouldNotifyOfPropertyChanges(bool sauce, string propertyName)
        {
            Fryceritops fries = new();
            Assert.PropertyChanged(fries, propertyName, () => { fries.Sauce = sauce; });
        }


    }
}
