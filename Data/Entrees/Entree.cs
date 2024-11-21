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
    /// Class that represents the base of an entree at Dino Diner.
    /// </summary>
    public abstract class Entree : MenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        //public override event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                List<string> _specialInstructions = new();
                return _specialInstructions; 
            }
        }

        /// <summary>
        /// Represents the Name of the entree.
        /// </summary>
        public override string Name { get => "Entree"; }

        /// <summary>
        /// Represents the Price of the entree.
        /// </summary>
        public override decimal Price { get => 1234567.89m; }

        /// <summary>
        /// Represents the Calories of the entree.
        /// </summary>
        public override uint Calories { get => 9999; }

    }
}
