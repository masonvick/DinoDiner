using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;
using System.IO;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// Class representing the Plilosoda class.
    /// Comes in 3 sizes and various flavors.
    /// </summary>
    public class Plilosoda : Drink
    {

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
        /// Initializes flavor to first enum (cola)
        /// </summary>
        public SodaFlavor _flavor;

        /// <summary>
        /// Represents the Flavor of the soda.
        /// </summary>
        public SodaFlavor Flavor
        {
            get => _flavor;
            set
            {
                _flavor = value;
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(Flavor));
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Initalizes size to first in enum (small)
        /// </summary>
        public ServingSize _size;

        /// <summary>
        /// Represents the size of the soda.
        /// S, M, or L
        /// </summary>
        public override ServingSize Size
        {
            get => _size;
            set
            {
                _size = value;
                OnPropertyChanged(nameof(Size));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Calories));
            }
        }

        /// <summary>
        /// Represents the price of the soda.
        /// Changes depending on size.
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal p = 0m;
                if (Size == ServingSize.Small) { p = 1.00m; }
                if (Size == ServingSize.Medium) { p = 1.75m; }
                if (Size == ServingSize.Large) { p = 2.5m; }
                return p;
            }
        }

        /// <summary>
        /// Represents the calories in the soda.
        /// Changes according to size and flavor.
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = 0;
                if(Size == ServingSize.Small)
                {
                    if(Flavor == SodaFlavor.Cola) { cal = 180;  }
                    if(Flavor == SodaFlavor.CherryCola) { cal = 100; }
                    if (Flavor == SodaFlavor.DoctorDino) { cal = 120; }
                    if (Flavor == SodaFlavor.LemonLime) { cal = 41; }
                    if (Flavor == SodaFlavor.DinoDew) { cal = 141; }
                }
                else if(Size == ServingSize.Medium)
                {
                    if (Flavor == SodaFlavor.Cola) { cal = 288; }
                    if (Flavor == SodaFlavor.CherryCola) { cal = 160; }
                    if (Flavor == SodaFlavor.DoctorDino) { cal = 192; }
                    if (Flavor == SodaFlavor.LemonLime) { cal = 66; }
                    if (Flavor == SodaFlavor.DinoDew) { cal = 256; }
                }
                else if (Size == ServingSize.Large)
                {
                    if (Flavor == SodaFlavor.Cola) { cal = 432; }
                    if (Flavor == SodaFlavor.CherryCola) { cal = 240; }
                    if (Flavor == SodaFlavor.DoctorDino) { cal = 288; }
                    if (Flavor == SodaFlavor.LemonLime) { cal = 98; }
                    if (Flavor == SodaFlavor.DinoDew) { cal = 338; }
                }
                return cal;
            }
        }

        /// <summary>
        /// Represents the name of the soda.
        /// Includes size and flavor.
        /// </summary>
        public override string Name
        {
            get
            {
                string n = "{0} {1} Plilosoda";
                if (Flavor == SodaFlavor.Cola) return string.Format(n, Size, "Cola");
                if (Flavor == SodaFlavor.CherryCola) return string.Format(n, Size, "Cherry Cola");
                if (Flavor == SodaFlavor.DoctorDino) return string.Format(n, Size, "Doctor Dino");
                if (Flavor == SodaFlavor.LemonLime) return string.Format(n, Size, "Lemon-Lime");
                if (Flavor == SodaFlavor.DinoDew) return string.Format(n, Size, "Dino Dew");
                return string.Format("water Soda");
            }
        }
    }
}
