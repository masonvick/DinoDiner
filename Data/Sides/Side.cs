using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// Represents the base outline of a side.
    /// </summary>
    public abstract class Side : MenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        //public override event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Private backing field for the special instructions string list.
        /// </summary>
        private List<string> _specialInstructions = new();

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get { return _specialInstructions; }
        }

        /// <summary>
        /// Represents the Name of the side
        /// </summary>
        public override string Name { get; }

        /// <summary>
        /// Represents the Price of the side.
        /// </summary>
        public override decimal Price { get; }

        /// <summary>
        /// Represents the Calories of the side.
        /// </summary>
        public override uint Calories { get; }

        /// <summary>
        /// Represents the Size of the side.
        /// </summary>
        public abstract ServingSize Size { get; set; }

    }
}
