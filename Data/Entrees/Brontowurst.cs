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
    /// Brontowurst (a brautwurst with fried peppers and onions
    /// served in a bun). 
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged
    {


        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> _specialInstructions = new();
                if (Onions == false) { _specialInstructions.Add("Hold Ketchup"); }
                if (Peppers == false) { _specialInstructions.Add("Hold Mustard"); }

                return _specialInstructions;
            }
        }

        /// <summary>
        /// A string that holds the name of the item.
        /// </summary>
        public override string Name { get; } = "Brontowurst";

        /// <summary>
        /// A decimal that holds the price of the item.
        /// </summary>
        public override decimal Price { get; } = 5.86m;

        /// <summary>
        /// a uint that holds the amount of calories in the item.
        /// </summary>
        public override uint Calories { get; } = 512;

        /// <summary>
        /// Initiliazes Onions to true.
        /// </summary>
        public bool _onions = true;

        /// <summary>
        /// Boolean that is T/F for whether or not there are onions on the item.
        /// </summary>
        public bool Onions
        {
            get => _onions;
            set
            {
                _onions = value;
                OnPropertyChanged(nameof(Onions));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes Peppers to true.
        /// </summary>
        public bool _peppers = true;

        /// <summary>
        /// Boolean that is T/F for whether or not there are peppers on the item.
        /// </summary>
        public bool Peppers
        {
            get => _peppers;
            set
            {
                _peppers = value;
                OnPropertyChanged(nameof(Peppers));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }
    }
}
