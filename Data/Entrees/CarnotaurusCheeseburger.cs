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
    /// Class that represents the Carnotaurus Cheeseburger at Dino Diner.
    /// 1 Patty with Tomato, Ketchuo, Picke, and American Cheese.
    /// </summary>
    public class CarnotaurusCheeseburger : Burger, INotifyPropertyChanged
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
                if (Onion) { _instructions.Add("Add Onion"); }
                if (Tomato == false) { _instructions.Add("Hold Tomato"); }
                if (Lettuce) { _instructions.Add("Add Lettuce"); }
                if (AmericanCheese == false) { _instructions.Add("Hold American Cheese"); }
                if (SwissCheese) { _instructions.Add("Add Swiss Cheese"); }
                if (Bacon) { _instructions.Add("Add Bacon"); }
                if (Mushrooms) { _instructions.Add("Add Mushrooms"); }

                return _instructions;
            }
        }

        /// <summary>
        /// String that represents the Name of the cheeseburger.
        /// </summary>
        public override string Name { get { return "Carnotaurus Cheeseburger"; } }


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
        /// Constructor to add the toppings to the burger.
        /// </summary>
        public CarnotaurusCheeseburger()
        {
            Tomato = true;
            Ketchup = true;
            Pickle = true;
            AmericanCheese = true;
        }
    }
}
