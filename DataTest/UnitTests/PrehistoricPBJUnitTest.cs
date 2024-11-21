using Xunit;
using DinoDiner.Data.Entrees;

namespace DataTest
{
    public class PrehistoricPBJUnitTest
    {
        /// <summary>
        /// PeanutButter should default to true
        /// </summary>
        [Fact]
        public void PeanutButterShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Should be able to set PeanutButter to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeanutButter()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Jelly should default to true
        /// </summary>
        [Fact]
        public void JellyShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Jelly);
        }

        /// <summary>
        /// Should be able to set Jelly to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetJelly()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Toasted should default to true
        /// </summary>
        [Fact]
        public void ToastedShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Toasted);
        }

        /// <summary>
        /// Should be able to set Toasted to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetToasted()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Price should always be $3.75
        /// </summary>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        [InlineData(true, true, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        [Theory]
        public void PriceShouldBeCorrect(bool peanutButter, bool jelly, bool toasted)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(3.75m, pbj.Price);
        }

        /// <summary>
        /// Calories varies based on how the PBJ is made
        /// </summary>
        /// <details>
        /// 148 calories for the bread
        /// 188 calories for the peanut butter 
        /// 62 calories for the jelly
        /// </details>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        /// <param name="calories">The expected calories</param>
        [InlineData(true, true, true, 148+188+62)]
        [InlineData(true, true, false, 148+188+62)]
        [InlineData(true, false, true, 148+188)]
        [InlineData(false, true, true, 148+62)]
        [InlineData(false, false, true, 148)]
        [InlineData(true, false, false, 148+188)]
        [InlineData(false, true, false, 148+62)]
        [InlineData(false, false, false, 148)]
        [Theory]
        public void CaloriesShouldBeCorrect(bool peanutButter, bool jelly, bool toasted, uint calories)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(calories, pbj.Calories);
        }

        /// <summary>
        /// Name should be defaulted to "Prehistoric PBJ".
        /// </summary>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(true, true, true, "Prehistoric PBJ")]
        [InlineData(true, true, false, "Prehistoric PBJ")]
        [InlineData(true, false, true, "Prehistoric PBJ")]
        [InlineData(false, true, true, "Prehistoric PBJ")]
        [InlineData(false, false, true, "Prehistoric PBJ")]
        [InlineData(true, false, false, "Prehistoric PBJ")]
        [InlineData(false, false, false, "Prehistoric PBJ")]
        public void NameShouldBeCorrect(bool peanutButter, bool jelly, bool toasted, string name)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.PeanutButter = peanutButter;
            pbj.Jelly = jelly;
            pbj.Toasted = toasted;
            Assert.Equal(name, pbj.Name);
        }

        /// <summary>
        /// Prehistoric PBJ should inherit from the Entree class.
        /// </summary>
        [Fact]
        public void PrehistoricPBJShouldInheritFromEntree()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.IsAssignableFrom<Entree>(pbj);
        }

        /// <summary>
        /// Changing the peanut butter should notify of certain property changes.
        /// </summary>
        /// <param name="pb">bool for peanut butter</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "PeanutButter")]
        [InlineData(false, "PeanutButter")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingPeanutButterShouldNotifyOfPropertyChanges(bool pb, string propertyName)
        {
            PrehistoricPBJ pbj = new();
            Assert.PropertyChanged(pbj, propertyName, () => { pbj.PeanutButter = pb; });
        }

        /// <summary>
        /// Changing the jelly should notify of certain property changes.
        /// </summary>
        /// <param name="jelly">bool for jelly</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Jelly")]
        [InlineData(false, "Jelly")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingJellyShouldNotifyOfPropertyChanges(bool jelly, string propertyName)
        {
            PrehistoricPBJ pbj = new();
            Assert.PropertyChanged(pbj, propertyName, () => { pbj.Jelly = jelly; });
        }

        /// <summary>
        /// Changing whether or not it is toasted should notify of certain property changes.
        /// </summary>
        /// <param name="toasted">bool for toasted</param>
        /// <param name="propertyName">name of property being changed</param>
        [Theory]
        [InlineData(true, "Toasted")]
        [InlineData(false, "Toasted")]
        public void ChangingDressingShouldNotifyOfPropertyChanges(bool toasted, string propertyName)
        {
            PrehistoricPBJ pbj = new();
            Assert.PropertyChanged(pbj, propertyName, () => { pbj.Toasted = toasted; });
        }
    }
}