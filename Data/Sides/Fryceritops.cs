using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// Class for fryceritops. 
    /// Comes with salt and sauce, can be removed.
    /// </summary>
    public class Fryceritops : Side, INotifyPropertyChanged
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
            get
            {
                if (Sauce == false) { _specialInstructions.Add("Hold Sauce"); }
                if (Salt == false) { _specialInstructions.Add("Hold Salt"); }
                return _specialInstructions;
            }
        }

        /// <summary>
        /// String that holds the name of the side.
        /// Includes size property in the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return $"{Size} Fryceritops";
            }
        }

        /// <summary>
        /// Initializes salt to true.
        /// </summary>
        public bool _salt = true;

        /// <summary>
        /// Boolean to indicate if salt is included.
        /// T: yes, F: no.
        /// </summary>
        public bool Salt
        {
            get => _salt;
            set
            {
                _salt = value;
                OnPropertyChanged(nameof(Salt));
            }
        }

        /// <summary>
        /// Initializes sauce to false
        /// </summary>
        public bool _sauce = false;

        /// <summary>
        /// Boolean to indicate if sauce is included.
        /// T: yes, F: no.
        /// </summary>
        public bool Sauce
        {
            get => _sauce;
            set
            {
                _sauce = value;
                OnPropertyChanged(nameof(Sauce));
                OnPropertyChanged(nameof(Calories));
            }
        }

        /// <summary>
        /// Initalizes the size to medium
        /// </summary>
        public ServingSize _size = ServingSize.Medium;

        /// <summary>
        /// ServingSize property to hold the size of the side.
        /// Defaulted to medium.
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
        /// Decimal to hold price of the side. 
        /// Price varies depending on size.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if(Size == ServingSize.Small)
                {
                    return 3.50m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 4.00m;
                }
                else if (Size == ServingSize.Large)
                {
                    return 5.00m;
                }
                return 0m;
            }
        }

        /// <summary>
        /// Uint to hold the calorie count for the side.
        /// Varies depending on size and sauce.
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint x = 0;
                if (Size == ServingSize.Small)
                {
                    x += 365;
                }
                else if (Size == ServingSize.Medium)
                {
                    x += 465;
                }
                else if (Size == ServingSize.Large)
                {
                    x += 510;
                }
                
                if(Sauce == true)
                {
                    x += 80;
                }

                return x;
            }
        }


    }
}
