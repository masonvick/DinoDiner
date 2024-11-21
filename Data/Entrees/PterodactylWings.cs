using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;
using System.Collections.Specialized;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Class for the Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree, INotifyPropertyChanged
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
                return _specialInstructions;
            }
        }

        /// <summary>
        /// String to hold the name of the entree.
        /// Uses Sauce to specify.
        /// </summary>
        public override string Name 
        { 
            get 
            {
                if (Sauce == WingSauce.HoneyGlaze) return "Honey Glaze Pterodactyl Wings";
                else return $"{Sauce} Pterodactyl Wings"; 
            }
        
        }

        /// <summary>
        /// Initializes the sauce to be buffalo
        /// </summary>
        public WingSauce _sauce = WingSauce.Buffalo;

        /// <summary>
        /// WingSauce property to hold sauce type.
        /// Defaulted to buffalo sauce.
        /// </summary>
        public WingSauce Sauce
        {
            get => _sauce;
            set
            {
                _sauce = value;
                OnPropertyChanged(nameof(Sauce));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Decimal to hold the price of the entree.
        /// Defaulted to $8.95.
        /// </summary>
        public override decimal Price { get; } = 8.95m;

        /// <summary>
        /// Uint that holds the calorie count for the entree.
        /// Varies depending on type of sauce.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(Sauce == WingSauce.Buffalo)
                {
                    return 360;
                }
                else if(Sauce == WingSauce.Teriyaki)
                {
                    return 342;
                }
                else if(Sauce == WingSauce.HoneyGlaze)
                {
                    return 359;
                }
                return 0;
            }
        }
    }
}
