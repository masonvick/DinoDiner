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
    /// Class for Mezzorella Sticks side.
    /// </summary>
    public class MezzorellaSticks : Side, INotifyPropertyChanged
    {

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
        /// String that holds the name of this side.
        /// Uses size property to specify the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return $"{Size} Mezzorella Sticks";
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
        /// decimal property to hold the price of the side.
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
        /// Uint to hold the calorie count for the side.
        /// Varies depending on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 530;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 620;
                }
                else if (Size == ServingSize.Large)
                {
                    return 730;
                }
                return 0;
            }
        }
    }
}
