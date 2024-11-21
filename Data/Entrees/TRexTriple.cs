using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Class to represent the T-Rex Triple, a burger.
    /// </summary>
    public class TRexTriple : Burger, INotifyPropertyChanged
    {

        /// <summary>
        /// Event handler for notifying when changing the collection.
        /// </summary>
        public event NotifyCollectionChangedEventHandler? NotifyCollectionChanged;

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> _instructions = new();
                if (Ketchup == false) { _instructions.Add("Hold Ketchup"); }
                if (Mustard) { _instructions.Add("Add Mustard"); }
                if (Pickle == false) { _instructions.Add("Hold Pickle"); }
                if (BBQ) { _instructions.Add("Add BBQ"); }
                if (Onion == false) { _instructions.Add("Hold Onion"); }
                if (Tomato == false) { _instructions.Add("Hold Tomato"); }
                if (Lettuce == false) { _instructions.Add("Hold Lettuce"); }
                if (AmericanCheese) { _instructions.Add("Add American Cheese"); }
                if (SwissCheese) { _instructions.Add("Add Swiss Cheese"); }
                if (Bacon) { _instructions.Add("Add Bacon"); }
                if (Mushrooms) { _instructions.Add("Add Mushrooms"); }

                return _instructions;
            }
        }

        /// <summary>
        /// Represents the name of the TRexTRiple.
        /// </summary>
        public override string Name { get { return "T-Rex Triple"; } } 

        /// <summary>
        /// Constructor that adds the toppings to the burger.
        /// </summary>
        public TRexTriple()
        {
            Ketchup = true;
            Mayo = true;
            Pickle = true;
            Onion = true;
            Lettuce = true;
            Tomato = true;
        }

        /// <summary>
        /// Initializes Patties to one for this burger.
        /// </summary>
        public uint _patties = 3;

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
        