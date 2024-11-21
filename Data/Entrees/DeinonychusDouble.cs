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
    /// Class for the Deinonychus Double, a burger with 2 patties at Dino Diner.
    /// Comes with BBQ, Pickle, Onion, Mushrooms, and Swiss.
    /// </summary>
    public class DeinonychusDouble : Burger
    {

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> _instructions = new();
                if (Ketchup) { _instructions.Add("Add Ketchup"); }
                if (Mustard) { _instructions.Add("Add Mustard"); }
                if (Pickle == false) { _instructions.Add("Hold Pickle"); }
                if (BBQ == false) { _instructions.Add("Hold BBQ"); }
                if (Onion == false) { _instructions.Add("Hold Onion"); }
                if (Tomato) { _instructions.Add("Add Tomato"); }
                if (Lettuce) { _instructions.Add("Add Lettuce"); }
                if (AmericanCheese) { _instructions.Add("Add American Cheese"); }
                if (SwissCheese == false) { _instructions.Add("Hold Swiss Cheese"); }
                if (Bacon) { _instructions.Add("Add Bacon"); }
                if (Mushrooms == false) { _instructions.Add("Hold Mushrooms"); }

                return _instructions;
            }
        }

        /// <summary>
        /// String that represents the name of the burger.
        /// </summary>
        public override string Name { get { return "Deinonychus Double"; } }

        /// <summary>
        /// Constructor to add the toppings to the burger.
        /// </summary>
        public DeinonychusDouble()
        {
            BBQ = true;
            Pickle = true;
            Onion = true;
            Mushrooms = true;
            SwissCheese = true;
        }

        /// <summary>
        /// Initializes Patties to one for this burger.
        /// </summary>
        public uint _patties = 2;

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

    }
}
