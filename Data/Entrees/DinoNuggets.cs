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
    /// Dino Nuggets
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
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
                return _instructions; 
            }
        }
        /// <summary>
        /// String for the name of the wings, as well as the amount (of wings).
        /// </summary>
        public override string Name
        {
            get 
            { 
                if(Count == 1)
                {
                    return $"{Count} Dino Nugget";
                }
                else
                {
                    return $"{Count} Dino Nuggets";
                }
                 
            }
        }

        /// <summary>
        /// Initializes the count to six.
        /// </summary>
        public uint _count = 6;

        /// <summary>
        /// Uint to hold the amount of wings for the entree.
        /// </summary>
        public uint Count 
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Decimal for price of individual wing.
        /// </summary>
        public override decimal Price 
        {
            get 
            {return 0.25m * Count; }
        }

        /// <summary>
        /// Uint for amount of calories in each individual wing.
        /// </summary>
        public override uint Calories 
        {
            get { return 61 * Count; }
        }
    }
}
