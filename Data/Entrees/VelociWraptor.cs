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
    /// Class for the Veloci-Wraptor entree item.
    /// Comes with dressing and cheese.
    /// </summary>
    public class VelociWraptor : Entree, INotifyPropertyChanged
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
                if (Dressing == false) { _specialInstructions.Add("Hold Dressing"); }
                if (Cheese == false) { _specialInstructions.Add("Hold Cheese"); }
                return _specialInstructions;
            }
        }

        /// <summary>
        /// String to hold the name of the wrap.
        /// </summary>
        public override string Name { get; } = "Veloci-Wraptor";

        /// <summary>
        /// Decimal to hold the price of the entree.
        /// Defaulted to $6.25.
        /// </summary>
        public override decimal Price { get; } = 6.25m;

        /// <summary>
        /// Uint that holds the calorie count for the wrap.
        /// Changes based on bools of dressing and cheese.
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint x = 732;
                if(Dressing == false)
                {
                    x -= 94;
                }
                if(Cheese == false)
                {
                    x -= 22;
                }
                return x;
            }
        }

        /// <summary>
        /// Initializes dressing to true
        /// </summary>
        public bool _dressing = true;

        /// <summary>
        /// Boolean for whether or not the entree has dressing.
        /// </summary>
        public bool Dressing
        {
            get => _dressing;
            set
            {
                _dressing = value;
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(Dressing));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initalizes cheese to true
        /// </summary>
        public bool _cheese = true;

        /// <summary>
        /// Boolean for whether or not the entree has cheese.
        /// </summary>
        public bool Cheese
        {
            get => _cheese;
            set
            {
                _cheese = value;
                OnPropertyChanged(nameof(Cheese));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }
    }
}
