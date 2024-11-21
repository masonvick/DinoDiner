using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;
using static System.Net.WebRequestMethods;
using System.Collections.Specialized;
using System.IO;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// Base Class for a Drink.
    /// </summary>
    public abstract class Drink : MenuItem, INotifyPropertyChanged
    {

        //public override event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Represents the Name of the drink.
        /// </summary>
        public override string Name { get => "Base Drink"; }

        /// <summary>
        /// Represents the Price of the drink.
        /// </summary>
        public override decimal Price { get; }

        /// <summary>
        /// Represents the Calories of the drink.
        /// </summary>
        public override uint Calories { get; }

        /// <summary>
        /// Represents the Size of the drink.
        /// </summary>
        public abstract ServingSize Size { get; set; }

    }
}
