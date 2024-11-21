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
    /// Unit Tests for the Brontowurst entree.
    /// </summary>
    public class BrontowurstUnitTests
    {
        /// <summary>
        /// Brontowurst class should inherit from the Entree class.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.IsAssignableFrom<Entree>(wurst);
        }

        /// <summary>
        /// Name should always be "Brontowurst"
        /// </summary>
        /// <param name="onions">bool for if it contains onions</param>
        /// <param name="peppers">bool for if it contains peppers</param>
        /// <param name="name">The name of the entree. "Brontowurst"</param>
        [Theory]
        [InlineData(true,true, "Brontowurst")]
        [InlineData(true, false, "Brontowurst")]
        [InlineData(false, true, "Brontowurst")]
        [InlineData(false, false, "Brontowurst")]
        public void NameShouldBeCorrect(bool onions, bool peppers, string name)
        {
            Brontowurst wurst = new Brontowurst();
            wurst.Onions = onions;
            wurst.Peppers = peppers;
            Assert.Equal(name, wurst.Name);
           
        }

        /// <summary>
        /// Price should always be $5.86
        /// </summary>
        /// <param name="onions"> bool for if it contains onions</param>
        /// <param name="peppers">bool for if it contains peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void PriceShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst wurst = new Brontowurst();
            wurst.Onions = onions;
            wurst.Peppers = peppers;
            Assert.Equal(5.86m, wurst.Price);
        }


        /// <summary>
        /// Calories should always be 512.
        /// </summary>
        /// <param name="onions"> bool for if it contains onions</param>
        /// <param name="peppers">bool for if it contains peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CaloriesShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst wurst = new Brontowurst();
            wurst.Onions = onions;
            wurst.Peppers = peppers;
            Assert.Equal((uint)512, wurst.Calories);
        }

        /// <summary>
        /// Onions should be defaulted to true.
        /// </summary>
        [Fact]
        public void OnionsShouldDefaultToTrue()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.True(wurst.Onions);
        }

        /// <summary>
        /// Onions should be able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.Onions = false;
            Assert.False(wurst.Onions);
            wurst.Onions = true;
            Assert.True(wurst.Onions);
        }

        /// <summary>
        /// Peppers should be defaulted to true.
        /// </summary>
        [Fact]
        public void PeppersShouldDefaultToTrue()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.True(wurst.Peppers);
        }

        /// <summary>
        /// Peppers should be able to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeppers()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.Peppers = false;
            Assert.False(wurst.Peppers);
            wurst.Peppers = true;
            Assert.True(wurst.Peppers);
        }

        /// <summary>
        /// Changing the onion bool should notify of certain property changes.
        /// </summary>
        /// <param name="onion">bool for onion</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true,"Onions")]
        [InlineData(false, "Onions")]
        public void ChangingOnionsShouldNotifyOfPropertyChanges(bool onion, string propertyName)
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, propertyName, () => { wurst.Onions = onion; });
        }

        /// <summary>
        /// Changing the peppers bool should notify of certain property changes.
        /// </summary>
        /// <param name="peppers">bool for peppers</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Peppers")]
        [InlineData(false, "Peppers")]
        public void ChangingPeppersShouldNotifyOfPropertyChanges(bool peppers, string propertyName)
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, propertyName, () => { wurst.Peppers = peppers; });
        }

    }
}
