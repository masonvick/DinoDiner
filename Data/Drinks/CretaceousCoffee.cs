using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// Class for the Cretaceous Coffee, a drink at 
    /// </summary>
    public class CretaceousCoffee : Drink
    {

        /// <summary>
        /// Private backing field for the special instructions string list.
        /// </summary>
        private List<string> _instructions = new();

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                if (Cream) { _instructions.Add("Add Cream"); }
                return _instructions;
            }
        }

        /// <summary>
        /// Initializes the size
        /// </summary>
        public ServingSize _size;


        /// <summary>
        /// A ServingSize from Enums that represents the size of the drink.
        /// </summary>
        public override ServingSize Size
        {
            get => _size;
            set
            {
                _size = value;
                OnPropertyChanged(nameof(Size));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Price));
            }
        }
        
        /// <summary>
        /// String for the name of the drink. Includes the side.
        /// </summary>
        public override string Name { get { return $"{Size} Cretaceous Coffee"; } }
    
        /// <summary>
        /// Decimal that represents the Price of the coffee
        /// Varies based on the Size.
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal p = 0m;
                if(Size == ServingSize.Small) { p = 0.75m; }
                if(Size == ServingSize.Medium) { p = 1.25m; }
                if(Size == ServingSize.Large) { p = 2.00m; }
                return p;
            }
        }
        
        /// <summary>
        /// Uint that represents Calories.
        /// Varies depending on Cream.
        /// </summary>
        public override uint Calories 
        { 
            get 
            { 
                if (Cream)
                    return 64;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Initializes cream to be false
        /// </summary>
        public bool _cream = false;

        /// <summary>
        /// Bool to represent whether or not the coffee has Cream.
        /// Defaulted to True (with Cream).
        /// </summary>
        public bool Cream
        {
            get => _cream;
            set
            {
                _cream = value;
                OnPropertyChanged(nameof(Cream));
                OnPropertyChanged(nameof(Calories));
            }
        }
    
        
    }
}
