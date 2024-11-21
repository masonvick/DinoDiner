using System.ComponentModel;
using System.Collections.Specialized;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// Used to indicate when a change from the normal way 
        /// of preparing the menu item has been asked for.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> _specialInstructions = new();
                if (PeanutButter == false) { _specialInstructions.Add("Hold Peanut Butter"); }
                if(Jelly == false) { _specialInstructions.Add("Hold Jelly"); }
                if(Toasted == false) { _specialInstructions.Add("Hold Toasted"); }
                return _specialInstructions;
            }
        }

        /// <summary>
        /// get method for the Name
        /// </summary>
        public override string Name { get; } = "Prehistoric PBJ";

        /// <summary>
        /// Initializes peanut butter to true
        /// </summary>
        public bool _peanutbutter = true;

        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        public bool PeanutButter
        {
            get => _peanutbutter;
            set
            {
                _peanutbutter = value;
                OnPropertyChanged(nameof(PeanutButter));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes jelly to true
        /// </summary>
        public bool _jelly = true;

        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Jelly
        {
            get => _jelly;
            set
            {
                _jelly = value;
                OnPropertyChanged(nameof(Jelly));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes toasted to true
        /// </summary>
        public bool _toasted = true;

        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        public bool Toasted
        {
            get => _toasted;
            set
            {
                _toasted = value;
                OnPropertyChanged(nameof(Toasted));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// The price of the PBJ
        /// </summary>
        public override decimal Price { get; } = 3.75m;

        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }
    }
}