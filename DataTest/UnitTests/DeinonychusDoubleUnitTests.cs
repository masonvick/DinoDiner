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
    /// Unit Tests for the Deinonychus Double class.
    /// </summary>
    public class DeinonychusDoubleUnitTests
    {
        /// <summary>
        /// This class should be inherited from burger and from entree.
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DeinonychusDouble burger = new();
            Assert.IsAssignableFrom<Entree>(burger);
            Assert.IsAssignableFrom<Burger>(burger);
        }

        /// <summary>
        /// The name for this burger should always be "Deinonychus Double".
        /// </summary>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="bbq">bool for bbq</param>
        /// <param name="onion">bool onion</param>
        /// <param name="patties">number of patties</param>
        /// <param name="name">name of the burger</param>
        [Theory]
        [InlineData(true, true, true, 1, "Deinonychus Double")]
        [InlineData(true, true, false, 1, "Deinonychus Double")]
        [InlineData(true, false, true, 1, "Deinonychus Double")]
        [InlineData(false, true, true, 2, "Deinonychus Double")]
        [InlineData(true, false, false, 2, "Deinonychus Double")]
        [InlineData(true, false, true, 2, "Deinonychus Double")]
        [InlineData(true, true, false, 3, "Deinonychus Double")]
        [InlineData(false, false, false, 4, "Deinonychus Double")]
        public void NameShouldBeCorrect(bool pickle, bool bbq, bool onion, uint patties, string name)
        {
            DeinonychusDouble burger = new();
            burger.Pickle = pickle;
            burger.BBQ = bbq;
            burger.Onion = onion;
            burger.Patties = patties;
            Assert.Equal(name, burger.Name);
        }

        /// <summary>
        /// Price should change according to toppings and number of patties.
        /// </summary>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="bbq">bool for bbq</param>
        /// <param name="onion">bool onion</param>
        /// <param name="patties">number of patties</param>
        /// <param name="price">price of the burger</param>
        [Theory]
        [InlineData(true, true, true, 1, 2.85)]
        [InlineData(true, true, false, 1, 2.45)]
        [InlineData(true, false, true, 1, 2.75)]
        [InlineData(false, true, true, 2, 4.15)]
        [InlineData(true, false, false, 2, 3.85)]
        [InlineData(true, false, true, 2, 4.25)]
        [InlineData(true, true, false, 3, 5.45)]
        [InlineData(false, false, false, 4, 6.65)]
        public void PriceShouldBeCorrect(bool pickle, bool bbq, bool onion, uint patties, decimal price)
        {
            DeinonychusDouble burger = new();
            burger.Pickle = pickle;
            burger.BBQ = bbq;
            burger.Onion = onion;
            burger.Patties = patties;
            Assert.Equal(price, burger.Price);
        }

        /// <summary>
        /// Calories should change based on the toppings and number of patties.
        /// </summary>
        /// <param name="pickle">bool for pickle</param>
        /// <param name="bbq">bool for bbq</param>
        /// <param name="onion">bool onion</param>
        /// <param name="patties">number of patties</param>
        /// <param name="calories">amount of calories</param>
        [Theory]
        [InlineData(true, true, true, 1, 444)]
        [InlineData(true, true, false, 1, 415)]
        [InlineData(true, false, true, 1, 350)]
        [InlineData(false, true, true, 2, 641)]
        [InlineData(true, false, false, 2, 525)]
        [InlineData(true, false, true, 2, 554)]
        [InlineData(true, true, false, 3, 823)]
        [InlineData(false, false, false, 4, 926)]
        public void CaloriesShouldBeCorrect(bool pickle, bool bbq, bool onion, uint patties, uint calories)
        {
            DeinonychusDouble burger = new();
            burger.Pickle = pickle;
            burger.BBQ = bbq;
            burger.Onion = onion;
            burger.Patties = patties;
            Assert.Equal(calories, burger.Calories);
        }

        /// <summary>
        /// The number of patties should be two by default.
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToTwo()
        {
            DeinonychusDouble burger = new();
            Assert.Equal((uint)2, burger.Patties);
        }

        /// <summary>
        /// Patties should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            CarnotaurusCheeseburger burger = new();
            burger.Patties = 4;
            Assert.Equal((uint)4, burger.Patties);
            burger.Patties = 8;
            Assert.Equal((uint)8, burger.Patties);
            burger.Patties = 1;
            Assert.Equal((uint)1, burger.Patties);

        }

        /// <summary>
        /// Burger should not have Ketchup by default.
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToFalse()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Ketchup);
        }

        /// <summary>
        /// Ketchup needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Mustard);
        }

        /// <summary>
        /// Mustard needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.True(burger.Pickle);
        }

        /// <summary>
        /// Pickle needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Mayo);
        }

        /// <summary>
        /// Mayo needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            burger.Mayo = true;
            Assert.True(burger.Mayo);
            burger.Mayo = false;
            Assert.False(burger.Mayo);
        }

        /// <summary>
        /// Burger should have BBQ by default.
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToTrue()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.True(burger.BBQ);
        }

        /// <summary>
        /// BBQ needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.True(burger.Onion);
        }

        /// <summary>
        /// Onion needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSeOnion()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Tomato);
        }

        /// <summary>
        /// Tomato needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Lettuce);
        }

        /// <summary>
        /// Lettuce needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// American Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            burger.AmericanCheese = true;
            Assert.True(burger.AmericanCheese);
            burger.AmericanCheese = false;
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// Burger should have Swiss Cheese by default.
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToTrue()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.True(burger.SwissCheese);
        }

        /// <summary>
        /// Swiss Cheese needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Bacon needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            burger.Bacon = true;
            Assert.True(burger.Bacon);
            burger.Bacon = false;
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Burger should have Mushrooms by default.
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToTrue()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.True(burger.Mushrooms);
        }

        /// <summary>
        /// Mushrooms needs to be able to be added and taken off the burger.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
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
            DeinonychusDouble burger = new DeinonychusDouble();
            Assert.PropertyChanged(burger, propertyName, () => { burger.Mushrooms = mushrooms; });
        }
    }
}
