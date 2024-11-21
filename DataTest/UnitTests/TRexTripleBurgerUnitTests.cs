using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using Xunit;


namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the TRex Triple Burger class.
    /// </summary>
    public class TRexTripleBurgerUnitTests
    {
        /// <summary>
        /// This class should be inherited from burger and from entree.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            TRexTriple burger = new();
            Assert.IsAssignableFrom<Entree>(burger);
            Assert.IsAssignableFrom<Burger>(burger);
        }

        /// <summary>
        /// Name should always be "T-Rex Triple".
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="mayo">bool for mayo</param>
        /// <param name="patties">numer of patties</param>
        /// <param name="name">name of burger</param>
        [Theory]
        [InlineData(true, true, true, 1, "T-Rex Triple")]
        [InlineData(true, true, false, 1, "T-Rex Triple")]
        [InlineData(true, false, true, 1, "T-Rex Triple")]
        [InlineData(false, true, true, 2, "T-Rex Triple")]
        [InlineData(true, false, false, 2, "T-Rex Triple")]
        [InlineData(true, false, true, 2, "T-Rex Triple")]
        [InlineData(true, true, false, 3, "T-Rex Triple")]
        [InlineData(false, false, false, 4, "T-Rex Triple")]
        public void NameShouldBeCorrect(bool ketchup, bool pickle, bool mayo, uint patties, string name)
        {
            TRexTriple burger = new();
            burger.Ketchup = ketchup;
            burger.Pickle = pickle;
            burger.Mayo = mayo;
            burger.Patties = patties;
            Assert.Equal(burger.Name, name);
        }

        /// <summary>
        /// Price should change depending on the toppings and amount of patties.
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="mayo">bool for mayo</param>
        /// <param name="patties">numer of patties</param>
        /// <param name="price">price of the burger</param>
        [Theory]
        [InlineData(true, true, true, 1, 3.0)]
        [InlineData(true, true, false, 1, 3.0)]
        [InlineData(true, false, true, 1, 2.8)]
        [InlineData(false, true, true, 2, 4.3)]
        [InlineData(true, false, false, 2, 4.3)]
        [InlineData(true, false, true, 2, 4.3)]
        [InlineData(true, true, false, 3, 6.0)]
        [InlineData(false, false, false, 4, 7.1)]
        public void PriceShouldBeCorrect(bool ketchup, bool pickle, bool mayo, uint patties, decimal price)
        {
            TRexTriple burger = new();
            burger.Ketchup = ketchup;
            burger.Pickle = pickle;
            burger.Mayo = mayo;
            burger.Patties = patties;
            Assert.Equal(burger.Price, price);
        }

        /// <summary>
        /// Calories should change depending on the toppings and amount of patties.
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="mayo">bool for mayo</param>
        /// <param name="patties">numer of patties</param>
        /// <param name="calories">amount of calories</param>
        [Theory]
        [InlineData(true, true, true, 1, 325)]
        [InlineData(true, true, false, 1, 325)]
        [InlineData(true, false, true, 1, 318)]
        [InlineData(false, true, true, 2, 510)]
        [InlineData(true, false, false, 2, 522)]
        [InlineData(true, false, true, 2, 522)]
        [InlineData(true, true, false, 3, 733)]
        [InlineData(false, false, false, 4, 911)]
        public void CaloriesShouldBeCorrect(bool ketchup, bool pickle, bool mayo, uint patties, uint calories)
        {
            TRexTriple burger = new();
            burger.Ketchup = ketchup;
            burger.Pickle = pickle;
            burger.Mayo = mayo;
            burger.Patties = patties;
            Assert.Equal(burger.Calories, calories);
        }

        /// <summary>
        /// There should be three patties on the burger by default.
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToThree()
        {
            TRexTriple burger = new();
            Assert.Equal((uint)3, burger.Patties);
        }

        /// <summary>
        /// Patties should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            CarnotaurusCheeseburger burger = new();
            burger.Patties = 5;
            Assert.Equal((uint)5, burger.Patties);
            burger.Patties = 1;
            Assert.Equal((uint)1, burger.Patties);
            burger.Patties = 4;
            Assert.Equal((uint)4, burger.Patties);
        }

        /// <summary>
        /// Burger should have Ketchup by default.
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Ketchup);
        }

        /// <summary>
        /// Ketchup needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            TRexTriple burger = new TRexTriple();
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        /// <summary>
        /// Burger should not have Mustard by default.
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.Mustard);
        }

        /// <summary>
        /// Mustard needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            TRexTriple burger = new TRexTriple();
            burger.Mustard = true;
            Assert.True(burger.Mustard);
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        /// <summary>
        /// Burger should have Pickle as default.
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Pickle);
        }

        /// <summary>
        /// Pickle needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            TRexTriple burger = new TRexTriple();
            burger.Pickle = true;
            Assert.True(burger.Pickle);
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        /// <summary>
        /// Burger should have Mayo by default.
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Mayo);
        }

        /// <summary>
        /// Mayo needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            TRexTriple burger = new TRexTriple();
            burger.Mayo = true;
            Assert.True(burger.Mayo);
            burger.Mayo = false;
            Assert.False(burger.Mayo);
        }

        /// <summary>
        /// Burger should not have BBQ by default.
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.BBQ);
        }

        /// <summary>
        /// BBQ needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            TRexTriple burger = new TRexTriple();
            burger.BBQ = true;
            Assert.True(burger.BBQ);
            burger.BBQ = false;
            Assert.False(burger.BBQ);
        }

        /// <summary>
        /// Burger should have Onion by default.
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Onion);
        }

        /// <summary>
        /// Onion needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSeOnion()
        {
            TRexTriple burger = new TRexTriple();
            burger.Onion = true;
            Assert.True(burger.Onion);
            burger.Onion = false;
            Assert.False(burger.Onion);
        }

        /// <summary>
        /// Burger should have Tomato by default.
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Tomato);
        }

        /// <summary>
        /// Tomato needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            TRexTriple burger = new TRexTriple();
            burger.Tomato = true;
            Assert.True(burger.Tomato);
            burger.Tomato = false;
            Assert.False(burger.Tomato);
        }

        /// <summary>
        /// Burger should have Lettuce by default.
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToTrue()
        {
            TRexTriple burger = new TRexTriple();
            Assert.True(burger.Lettuce);
        }

        /// <summary>
        /// Lettuce needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            TRexTriple burger = new TRexTriple();
            burger.Lettuce = true;
            Assert.True(burger.Lettuce);
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
        }

        /// <summary>
        /// Burger should not have American Cheese by default.
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// American Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            TRexTriple burger = new TRexTriple();
            burger.AmericanCheese = true;
            Assert.True(burger.AmericanCheese);
            burger.AmericanCheese = false;
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// Burger should not have Swiss Cheese by default.
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.SwissCheese);
        }

        /// <summary>
        /// Swiss Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            TRexTriple burger = new TRexTriple();
            burger.SwissCheese = true;
            Assert.True(burger.SwissCheese);
            burger.SwissCheese = false;
            Assert.False(burger.SwissCheese);
        }

        /// <summary>
        /// Burger should not have Bacon by default.
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Bacon needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            TRexTriple burger = new TRexTriple();
            burger.Bacon = true;
            Assert.True(burger.Bacon);
            burger.Bacon = false;
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Burger should not have Mushrooms by default.
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            TRexTriple burger = new TRexTriple();
            Assert.False(burger.Mushrooms);
        }

        /// <summary>
        /// Mushrooms needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            TRexTriple burger = new TRexTriple();
            burger.Mushrooms = true;
            Assert.True(burger.Mushrooms);
            burger.Mushrooms = false;
            Assert.False(burger.Mushrooms);
        }

        /// <summary>
        /// This burger class should implement INotifyChanged.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            TRexTriple burger = new TRexTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Changing the patties should notify of certain property changes.
        /// </summary>
        /// <param name="patties">number of patties</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(1, "Patties")]
        [InlineData(2, "Patties")]
        [InlineData(3, "Patties")]
        [InlineData(1, "Price")]
        [InlineData(2, "Price")]
        [InlineData(3, "Price")]
        [InlineData(1, "Calories")]
        [InlineData(2, "Calories")]
        [InlineData(3, "Calories")]
        public void ChangingPattiesShouldNotifyOfPropertyChanges(uint patties, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Patties = patties; });
        }

        /// <summary>
        /// Changing the ketchup bool should notify of certain property changes.
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Ketchup")]
        [InlineData(false, "Ketchup")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingKetchupShouldNotifyOfPropertyChanges(bool ketchup, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Ketchup = ketchup; });
        }

        /// <summary>
        /// Changing the mustard bool should notify of certain property changes.
        /// </summary>
        /// <param name="mustard">bool for mustard</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Mustard")]
        [InlineData(false, "Mustard")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingMustardShouldNotifyOfPropertyChanges(bool mustard, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Mustard = mustard; });
        }

        /// <summary>
        /// Changing the pickle bool should notify of certain property changes.
        /// </summary>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Pickle")]
        [InlineData(false, "Pickle")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingPickleShouldNotifyOfPropertyChanges(bool pickle, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Pickle = pickle; });
        }

        /// <summary>
        /// Changing the mayo bool should notify of certain property changes.
        /// </summary>
        /// <param name="mayo">bool for mayo</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Mayo")]
        [InlineData(false, "Mayo")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingMayoShouldNotifyOfPropertyChanges(bool mayo, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Mayo = mayo; });
        }

        /// <summary>
        /// Changing the bbq bool should notify of certain property changes.
        /// </summary>
        /// <param name="bbq">bool for bbq</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "BBQ")]
        [InlineData(false, "BBQ")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingBBQShouldNotifyOfPropertyChanges(bool bbq, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.BBQ = bbq; });
        }

        /// <summary>
        /// Changing the onion bool should notify of certain property changes.
        /// </summary>
        /// <param name="onion">bool for onion</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Onion")]
        [InlineData(false, "Onion")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingOnionShouldNotifyOfPropertyChanges(bool onion, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Onion = onion; });
        }

        /// <summary>
        /// Changing the tomato bool should notify of certain property changes.
        /// </summary>
        /// <param name="tomato">bool for tomato</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Tomato")]
        [InlineData(false, "Tomato")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingTomatoShouldNotifyOfPropertyChanges(bool tomato, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Tomato = tomato; });
        }

        /// <summary>
        /// Changing the lettuce bool should notify of certain property changes.
        /// </summary>
        /// <param name="lettuce">bool for lettuce</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Lettuce")]
        [InlineData(false, "Lettuce")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingLettuceShouldNotifyOfPropertyChanges(bool lettuce, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Lettuce = lettuce; });
        }

        /// <summary>
        /// Changing the american bool should notify of certain property changes.
        /// </summary>
        /// <param name="american">bool for american</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "AmericanCheese")]
        [InlineData(false, "AmericanCheese")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingAmericanCheeseShouldNotifyOfPropertyChanges(bool american, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.AmericanCheese = american; });
        }

        /// <summary>
        /// Changing the swiss bool should notify of certain property changes.
        /// </summary>
        /// <param name="swiss">bool for swiss</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "SwissCheese")]
        [InlineData(false, "SwissCheese")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingSwissCheeseShouldNotifyOfPropertyChanges(bool swiss, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.SwissCheese = swiss; });
        }

        /// <summary>
        /// Changing the bacon bool should notify of certain property changes.
        /// </summary>
        /// <param name="bacon">bool for bacon</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Bacon")]
        [InlineData(false, "Bacon")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingBaconShouldNotifyOfPropertyChanges(bool bacon, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Bacon = bacon; });
        }

        /// <summary>
        /// Changing the mushrooms bool should notify of certain property changes.
        /// </summary>
        /// <param name="mushrooms">bool for mushrooms</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Mushrooms")]
        [InlineData(false, "Mushrooms")]
        [InlineData(true, "Price")]
        [InlineData(false, "Price")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingMushroomsShouldNotifyOfPropertyChanges(bool mushrooms, string propertyName)
        {
            TRexTriple burger = new TRexTriple();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Mushrooms = mushrooms; });
        }
    }
}
