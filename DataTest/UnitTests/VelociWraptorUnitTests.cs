using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using Xunit;

namespace DataTest.UnitTests
{
    /// <summary>
    /// Unit Tests for the VelociWraptor class.
    /// </summary>
    public class VelociWraptorUnitTests
    {
        /// <summary>
        /// VelociWraptor class should inherit from Entree class
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            VelociWraptor wrap = new();
            Assert.IsAssignableFrom<Entree>(wrap);
        }

        /// <summary>
        /// The name should remain the same at all times.
        /// </summary>
        /// <param name="dressing">bool for dessing</param>
        /// <param name="cheese">bool for cheese</param>
        /// <param name="name">name of the wrap</param>
        [Theory]
        [InlineData(true,true, "Veloci-Wraptor")]
        [InlineData(true,false, "Veloci-Wraptor")]
        [InlineData(false,true, "Veloci-Wraptor")]
        [InlineData(false,false, "Veloci-Wraptor")]
        public void NameShouldBeCorrect(bool dressing, bool cheese, string name)
        {
            VelociWraptor wrap = new();
            wrap.Dressing = dressing;
            wrap.Cheese = cheese;
            Assert.Equal(wrap.Name, name);
        }

        /// <summary>
        /// Price of the wrap. Should always be $6.25.
        /// </summary>
        /// <param name="dressing">bool if there is dressing</param>
        /// <param name="cheese">bool if there is cheese</param>
        /// <param name="price">the price of the wrap</param>
        [Theory]
        [InlineData(true, true, 6.25)]
        [InlineData(true, false, 6.25)]
        [InlineData(false, true, 6.25)]
        [InlineData(false, false, 6.25)]
        public void PriceShouldBeCorrect(bool dressing, bool cheese, decimal price)
        {
            VelociWraptor wrap = new();
            wrap.Dressing = dressing;
            wrap.Cheese = cheese;
            Assert.Equal(wrap.Price, price);
        }

        /// <summary>
        /// Calories should change according to whether or not there's cheese and/or dressing.
        /// </summary>
        /// <param name="dressing">bool if there is dressing</param>
        /// <param name="cheese">bool if there is cheese</param>
        /// <param name="calories">the calories of the wrap</param>
        [Theory]
        [InlineData(true, true, 732)]
        [InlineData(true, false, 710)]
        [InlineData(false, true, 638)]
        [InlineData(false, false, 616)]
        public void CaloriesShouldbeCorrect(bool dressing, bool cheese, uint calories)
        {
            VelociWraptor wrap = new();
            wrap.Dressing = dressing;
            wrap.Cheese = cheese;
            Assert.Equal(calories, wrap.Calories);
        }

        /// <summary>
        /// Dressing should be on the wrap by default.
        /// </summary>
        [Fact]
        public void DressingShouldDefaultToTrue()
        {
            VelociWraptor wrap = new();
            Assert.True(wrap.Dressing);
        }

        /// <summary>
        /// Dressing should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDressing()
        {
            VelociWraptor wrap = new();
            wrap.Dressing = false;
            Assert.False(wrap.Dressing);
            wrap.Dressing = true;
            Assert.True(wrap.Dressing);
        }

        /// <summary>
        /// Cheese should be on the wrap by default.
        /// </summary>
        [Fact]
        public void CheeseShouldDefaultToTrue()
        {
            VelociWraptor wrap = new();
            Assert.True(wrap.Cheese);
        }

        /// <summary>
        /// Cheese should have the ability to be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            VelociWraptor wrap = new();
            wrap.Cheese = false;
            Assert.False(wrap.Cheese);
            wrap.Cheese = true;
            Assert.True(wrap.Cheese);
        }

        /// <summary>
        /// Changing the dressing should notify of certain property changes.
        /// </summary>
        /// <param name="dressing">bool for dressing</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Dressing")]
        [InlineData(false, "Dressing")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingDressingShouldNotifyOfPropertyChanges(bool dressing, string propertyName)
        {
            VelociWraptor wrap = new();
            Assert.PropertyChanged(wrap, propertyName, () => { wrap.Dressing = dressing; });
        }

        /// <summary>
        /// Changing the cheese should notify of certain property changes.
        /// </summary>
        /// <param name="cheese">bool for cheese</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Cheese")]
        [InlineData(false, "Cheese")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingCheeseShouldNotifyOfPropertyChanges(bool cheese, string propertyName)
        {
            VelociWraptor wrap = new();
            Assert.PropertyChanged(wrap, propertyName, () => { wrap.Cheese = cheese; });
        }

    }
}
