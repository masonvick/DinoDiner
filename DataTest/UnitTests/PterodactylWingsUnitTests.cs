using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using Xunit;


namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Pterodactyl Wings class.
    /// </summary>
    public class PterodactylWingsUnitTests
    {
        /// <summary>
        /// Pterodactyl Wings should inherit from the Entree class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            PterodactylWings wings = new PterodactylWings();
            Assert.IsAssignableFrom<Entree>(wings);
        }

        /// <summary>
        /// Name should change depending on the sauce for the wings.
        /// </summary>
        /// <param name="sauce">enum for the sauce</param>
        /// <param name="name">name of the wings</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, "Buffalo Pterodactyl Wings")]
        [InlineData(WingSauce.HoneyGlaze, "Honey Glaze Pterodactyl Wings")]
        [InlineData(WingSauce.Teriyaki, "Teriyaki Pterodactyl Wings")]
        public void NameShouldBeCorrect(WingSauce sauce, string name)
        {
            PterodactylWings wings = new PterodactylWings();
            wings.Sauce = sauce;
            Assert.Equal(name, wings.Name);
        }

        /// <summary>
        /// The price should always be $8.95.
        /// </summary>
        /// <param name="price">The price of the wings.</param>
        [Theory]
        [InlineData(8.95)]
        public void PriceShouldBeCorrect(decimal price)
        {
            PterodactylWings wings = new();
            Assert.Equal(wings.Price, price);

        }

        /// <summary>
        /// Calories change depending on the type of sauce.
        /// </summary>
        /// <param name="sauce">The sauce on the wings</param>
        /// <param name="calories">The total amount of calories</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, 360)]
        [InlineData(WingSauce.HoneyGlaze, 359)]
        [InlineData(WingSauce.Teriyaki, 342)]
        public void CaloriesShouldBeCorrect(WingSauce sauce, uint calories)
        {
            PterodactylWings wings = new();
            wings.Sauce = sauce;
            Assert.Equal(wings.Calories, calories);
        }
        
        /// <summary>
        /// The sauce should be defaulted to Buffalo.
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToBuffalo()
        {
            PterodactylWings wings = new();
            Assert.Equal(WingSauce.Buffalo, wings.Sauce);
        }

        /// <summary>
        /// Sauce should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            PterodactylWings wings = new();
            wings.Sauce = WingSauce.Teriyaki;
            Assert.Equal(WingSauce.Teriyaki, wings.Sauce);
            wings.Sauce = WingSauce.HoneyGlaze;
            Assert.Equal(WingSauce.HoneyGlaze, wings.Sauce);
            wings.Sauce = WingSauce.Buffalo;
            Assert.Equal(WingSauce.Buffalo, wings.Sauce);

        }

        /// <summary>
        /// Changing the sauce should notify of certain property changes.
        /// </summary>
        /// <param name="sauce">bool for sauce</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(WingSauce.Teriyaki, "Sauce")]
        [InlineData(WingSauce.HoneyGlaze, "Sauce")]
        [InlineData(WingSauce.Buffalo, "Sauce")]
        public void ChangingSauceShouldNotifyOfPropertyChanges(WingSauce sauce, string propertyName)
        {
            PterodactylWings wings = new();
            Assert.PropertyChanged(wings, propertyName, () => { wings.Sauce = sauce; });
        }

    }
}
