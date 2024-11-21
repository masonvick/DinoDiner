using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Enums;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Plilosoda class.
    /// </summary>
    public class PlilosodaUnitTests
    {
        /// <summary>
        /// This class should inherit from the Drink class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Plilosoda soda = new Plilosoda();
            Assert.IsAssignableFrom<Drink>(soda);
        }

        /// <summary>
        /// The name should change based on size and flavor of the drink.
        /// </summary>
        /// <param name="size">the size of the drink</param>
        /// <param name="flavor">the flavor of the drink</param>
        /// <param name="name">the name of the soda</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, "Small Cola Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, "Small Cherry Cola Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.DoctorDino, "Small Doctor Dino Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.LemonLime, "Small Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.DinoDew, "Small Dino Dew Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.Cola, "Medium Cola Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.CherryCola, "Medium Cherry Cola Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.DoctorDino, "Medium Doctor Dino Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.LemonLime, "Medium Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, "Medium Dino Dew Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.Cola, "Large Cola Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.CherryCola, "Large Cherry Cola Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.DoctorDino, "Large Doctor Dino Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.LemonLime, "Large Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.DinoDew, "Large Dino Dew Plilosoda")]
        public void NameShouldBeCorrect(ServingSize size, SodaFlavor flavor, string name)
        {
            Plilosoda soda = new Plilosoda();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal(name, soda.Name);
        }

        /// <summary>
        /// The price of the drink should change based on the size.
        /// </summary>
        /// <param name="size">size of the drink</param>
        /// <param name="price">price of the drink</param>
        [Theory]
        [InlineData(ServingSize.Small, 1.00)]
        [InlineData(ServingSize.Medium, 1.75)]
        [InlineData(ServingSize.Large, 2.5)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Plilosoda soda = new Plilosoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
        }

        /// <summary>
        /// The calories should change based on the size and flavor of the drink.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="flavor"></param>
        /// <param name="calories"></param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, 180)]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, 100)]
        [InlineData(ServingSize.Small, SodaFlavor.DoctorDino, 120)]
        [InlineData(ServingSize.Small, SodaFlavor.LemonLime, 41)]
        [InlineData(ServingSize.Small, SodaFlavor.DinoDew, 141)]
        [InlineData(ServingSize.Medium, SodaFlavor.Cola, 288)]
        [InlineData(ServingSize.Medium, SodaFlavor.CherryCola, 160)]
        [InlineData(ServingSize.Medium, SodaFlavor.DoctorDino, 192)]
        [InlineData(ServingSize.Medium, SodaFlavor.LemonLime, 66)]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, 256)]
        [InlineData(ServingSize.Large, SodaFlavor.Cola, 432)]
        [InlineData(ServingSize.Large, SodaFlavor.CherryCola, 240)]
        [InlineData(ServingSize.Large, SodaFlavor.DoctorDino, 288)]
        [InlineData(ServingSize.Large, SodaFlavor.LemonLime, 98)]
        [InlineData(ServingSize.Large, SodaFlavor.DinoDew, 338)]
        public void CaloriesShouldBeCorrect(ServingSize size, SodaFlavor flavor, uint calories)
        {
            Plilosoda soda = new Plilosoda();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal(calories, soda.Calories);
        }

        /// <summary>
        /// The size should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Plilosoda soda = new Plilosoda();
            soda.Size = ServingSize.Small;
            Assert.Equal(ServingSize.Small, soda.Size);
            soda.Size = ServingSize.Medium;
            Assert.Equal(ServingSize.Medium, soda.Size);
            soda.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, soda.Size);
        }

        /// <summary>
        /// The flavor should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Plilosoda soda = new Plilosoda();
            soda.Flavor = SodaFlavor.Cola;
            Assert.Equal(SodaFlavor.Cola, soda.Flavor);
            soda.Flavor = SodaFlavor.CherryCola;
            Assert.Equal(SodaFlavor.CherryCola, soda.Flavor);
            soda.Flavor = SodaFlavor.DoctorDino;
            Assert.Equal(SodaFlavor.DoctorDino, soda.Flavor);
            soda.Flavor = SodaFlavor.LemonLime;
            Assert.Equal(SodaFlavor.LemonLime, soda.Flavor);
            soda.Flavor = SodaFlavor.DinoDew;
            Assert.Equal(SodaFlavor.DinoDew, soda.Flavor);
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
            Plilosoda soda = new Plilosoda();
            Assert.PropertyChanged(soda, propertyName, () => { soda.Size = size; });
        }

        /// <summary>
        /// Changing the flavor should notify of certain property changes.
        /// </summary>
        /// <param name="flavor">flavor of drink</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(SodaFlavor.Cola, "Flavor")]
        [InlineData(SodaFlavor.CherryCola, "Flavor")]
        [InlineData(SodaFlavor.DoctorDino, "Flavor")]
        [InlineData(SodaFlavor.LemonLime, "Flavor")]
        [InlineData(SodaFlavor.DinoDew, "Flavor")]
        [InlineData(SodaFlavor.Cola, "Name")]
        [InlineData(SodaFlavor.CherryCola, "Name")]
        [InlineData(SodaFlavor.DoctorDino, "Name")]
        [InlineData(SodaFlavor.LemonLime, "Name")]
        [InlineData(SodaFlavor.DinoDew, "Name")]
        public void ChangingFlavorShouldNotifyOfPropertyChanges(SodaFlavor flavor, string propertyName)
        {
            Plilosoda soda = new Plilosoda();
            Assert.PropertyChanged(soda, propertyName, () => { soda.Flavor = flavor; });
        }
    }
}
