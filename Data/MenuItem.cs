using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Data
{
    /// <summary>
    /// interface to represent a MenuItem
    /// </summary>
    public abstract class MenuItem : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Name of the menu item. This instance should never be used.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// PRice of the menu item. This instance should never be used.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Calories of the menu item. This instance should never be used.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        public string FoodType { get; }

        /// <summary>
        /// Used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">Name of the property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
