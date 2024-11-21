using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the Allosaurus All-American Burger class.
    /// </summary>
    public class AllosaurusAllAmericanBurgerUnitTests
    {

        /// <summary>
        /// This class should be inherited from burger and from entree.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.IsAssignableFrom<Entree>(burger);
            Assert.IsAssignableFrom<Burger>(burger);
        }

        /// <summary>
        /// The name should always be "Allosaurus All-American Burger"
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="mustard">bool for mustard</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="patties">number of patties</param>
        /// <param name="name">name of burger</param>
        [Theory]
        [InlineData(true, true, true, 1, "Allosaurus All-American Burger")]
        [InlineData(true, true, false, 1, "Allosaurus All-American Burger")]
        [InlineData(true, false, true, 1, "Allosaurus All-American Burger")]
        [InlineData(false, true, true, 2, "Allosaurus All-American Burger")]
        [InlineData(true, false, false, 2, "Allosaurus All-American Burger")]
        [InlineData(true, false, true, 2, "Allosaurus All-American Burger")]
        [InlineData(true, true, false, 3, "Allosaurus All-American Burger")]
        [InlineData(false, false, false, 4, "Allosaurus All-American Burger")]
        public void NameShouldBeCorrect(bool ketchup, bool mustard, bool pickle, uint patties, string name)
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Ketchup = ketchup;
            burger.Mustard = mustard;
            burger.Pickle = pickle;
            burger.Patties = patties;
            Assert.Equal(burger.Name, name);
        }

        /// <summary>
        /// Price should change according to toppings and patties.
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="mustard">bool for mustard</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="patties">number of patties</param>
        /// <param name="price">price of burger</param>
        [Theory]
        [InlineData(true, true, true, 1, 2.10)]
        [InlineData(true, true, false, 1, 1.90)]
        [InlineData(true, false, true, 1, 1.90)]
        [InlineData(false, true, true, 2, 3.40)]
        [InlineData(true, false, false, 2, 3.20)]
        [InlineData(true, false, true, 2, 3.40)]
        [InlineData(true, true, false, 3, 4.90)]
        [InlineData(false, false, false, 4, 6.00)]
        public void PriceShouldBeCorrect(bool ketchup, bool mustard, bool pickle, uint patties, decimal price)
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Ketchup = ketchup;
            burger.Mustard = mustard;
            burger.Pickle = pickle;
            burger.Patties = patties;
            Assert.Equal(price, burger.Price);
        }

        /// <summary>
        /// Calories should change according to toppings and patties.
        /// </summary>
        /// <param name="ketchup">bool for ketchup</param>
        /// <param name="mustard">bool for mustard</param>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="patties">number of patties</param>
        /// <param name="calories">calories in the burger</param>
        [Theory]
        [InlineData(true, true, true, 1, 233)]
        [InlineData(true, true, false, 1, 226)]
        [InlineData(true, false, true, 1, 230)]
        [InlineData(false, true, true, 2, 418)]
        [InlineData(true, false, false, 2, 427)]
        [InlineData(true, false, true, 2, 434)]
        [InlineData(true, true, false, 3, 634)]
        [InlineData(false, false, false, 4, 816)]
        public void CaloriesShouldBeCorrect(bool ketchup, bool mustard, bool pickle, uint patties, uint calories)
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Ketchup = ketchup;
            burger.Mustard = mustard;
            burger.Pickle = pickle;
            burger.Patties = patties;
            Assert.Equal(calories, burger.Calories);
        }

        /// <summary>
        /// The number of patties should default to one.
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.Equal((uint)1, burger.Patties);
        }

        /// <summary>
        /// Patties should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Patties = 2;
            Assert.Equal((uint)2, burger.Patties);
            burger.Patties = 3;
            Assert.Equal((uint)3, burger.Patties);
            burger.Patties = 1;
            Assert.Equal((uint)1, burger.Patties);
        }

        /// <summary>
        /// Burger should have Ketchup by default.
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.True(burger.Ketchup);
        }

        /// <summary>
        /// Ketchup needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        /// <summary>
        /// Burger should have Mustard by default.
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.True(burger.Mustard);
        }

        /// <summary>
        /// Mustard needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            AllosaurusAll_AmericanBurger burger = new();
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
            AllosaurusAll_AmericanBurger burger = new();
            Assert.True(burger.Pickle);
        }

        /// <summary>
        /// Pickle needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Pickle = true;
            Assert.True(burger.Pickle);
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        /// <summary>
        /// Burger should not have Mayo by default.
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.False(burger.Mayo);
        }

        /// <summary>
        /// Mayo needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            AllosaurusAll_AmericanBurger burger = new();
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
            AllosaurusAll_AmericanBurger burger = new();
            Assert.False(burger.BBQ);
        }

        /// <summary>
        /// BBQ needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.BBQ = true;
            Assert.True(burger.BBQ);
            burger.BBQ = false;
            Assert.False(burger.BBQ);
        }

        /// <summary>
        /// Burger should not have Onion by default.
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.False(burger.Onion);
        }

        /// <summary>
        /// Onion needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSeOnion()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Onion = true;
            Assert.True(burger.Onion);
            burger.Onion = false;
            Assert.False(burger.Onion);
        }

        /// <summary>
        /// Burger should not have Tomato by default.
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.False(burger.Tomato);
        }

        /// <summary>
        /// Tomato needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            AllosaurusAll_AmericanBurger burger = new();
            burger.Tomato = true;
            Assert.True(burger.Tomato);
            burger.Tomato = false;
            Assert.False(burger.Tomato);
        }

        /// <summary>
        /// Burger should not have Lettuce by default.
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger burger = new();
            Assert.False(burger.Lettuce);
        }

        /// <summary>
        /// Lettuce needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// American Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.False(burger.SwissCheese);
        }

        /// <summary>
        /// Swiss Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Bacon needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.False(burger.Mushrooms);
        }

        /// <summary>
        /// Mushrooms needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
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
            AllosaurusAll_AmericanBurger burger = new AllosaurusAll_AmericanBurger();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Mushrooms = mushrooms; });
        }

    }
}
