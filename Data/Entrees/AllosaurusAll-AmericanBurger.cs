using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Specialized;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Class for the Allosaurus All-American Burger at DinoDiner.
    /// Comes with Ketchup, Mustard, and Pickle.
    /// </summary>
    public class AllosaurusAll_AmericanBurger : Burger, INotifyPropertyChanged
    {

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new();
                if (Ketchup == false) { instructions.Add("Hold Ketchup"); }
                if (Mustard == false) { instructions.Add("Hold Mustard"); }
                if (Pickle == false) { instructions.Add("Hold Pickle"); }
                if (BBQ) { instructions.Add("Add BBQ"); }
                if (Onion) { instructions.Add("Add Onion"); }
                if (Tomato) { instructions.Add("Add Tomato"); }
                if (Lettuce) { instructions.Add("Add Lettuce"); }
                if (AmericanCheese) { instructions.Add("Add American Cheese"); }
                if (SwissCheese) { instructions.Add("Add Swiss Cheese"); }
                if (Bacon) { instructions.Add("Add Bacon"); }
                if (Mushrooms) { instructions.Add("Add Mushrooms"); }

                return instructions;
            }
        }

        /// <summary>
        /// String that represents the name of this burger.
        /// "Allosaurus All-American Burger"
        /// </summary>
        public override string Name { get { return "Allosaurus All-American Burger"; } }

        
        /// <summary>
        /// Initializes Patties to one for this burger.
        /// </summary>
        public uint _patties = 1;
        
        /// <summary>
        /// Uint to represent the number of Patties on the burger.
        /// </summary>
        public override uint Patties
        {
            get => _patties;
            set
            {
                _patties = value;
                OnPropertyChanged(nameof(Patties));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Constructor to add toppings to the burger.
        /// </summary>
        public AllosaurusAll_AmericanBurger()
        {
            Ketchup = true;
            Mustard = true;
            Pickle = true;
        }

    }
}
