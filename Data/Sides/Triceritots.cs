using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;
using System.Collections.Specialized;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    ///  Class for the side Triceritots
    /// </summary>
    public class Triceritots : Side, INotifyPropertyChanged
    {

        /// <summary>
        /// Private backing field for the special instructions string list.
        /// </summary>
        private List<string> _specialInstructions = new();

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get { return _specialInstructions; }
        }

        /// <summary>
        /// String that holds the name of the side.
        /// Size is used to get the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return $"{Size} Triceritots";
            }
        }

        /// <summary>
        /// Initalizes the size to first enum (small)
        /// </summary>
        public ServingSize _size;

        /// <summary>
        /// ServingSize variable to hold the size of the side.
        /// Can be small, medium, or large.
        /// </summary>
        public override ServingSize Size
        {
            get => _size;
            set
            {
                _size = value;
                OnPropertyChanged(nameof(Size));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// A decimal to hold the price of the item.
        /// Varies depending on size.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 3.50m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 4.00m;
                }
                else if (Size == ServingSize.Large)
                {
                    return 5.25m;
                }
                return 0m;
            }
        }

        /// <summary>
        /// Uint that holds carolie count for the side.
        /// Varies depending on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 351;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 409;
                }
                else if (Size == ServingSize.Large)
                {
                    return 583;
                }
                return 0;
            }
        }
    }
}
