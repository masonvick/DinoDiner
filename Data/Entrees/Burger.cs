using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DinoDiner.Data;
using System.Collections;
using System.Collections.Specialized;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// Class representing the base of a burger at DinoDiner.
    /// </summary>
    public abstract class Burger : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// String for the name of the burger.
        /// </summary>
        public override string Name { get { return "baseBurger"; } }

        /// <summary>
        /// Decimal for the price of the burger.
        /// Varies with toppings and # of patties.
        /// </summary>
        public override decimal Price 
        {
            get
            {
                decimal p = 1.5m * Patties;
                if (Ketchup) p += .2m;
                if (Mustard) p += .2m;
                if (Pickle) p += .2m;
                if (BBQ) p += .1m;
                if (Onion) p += .4m;
                if (Tomato) p += .4m;
                if (Lettuce) p += .3m;
                if (AmericanCheese) p += .25m;
                if (SwissCheese) p += .25m;
                if (Bacon) p += .5m;
                if (Mushrooms) p += .4m;

                return p;
            }
        }

        /// <summary>
        /// uint for calories of a burger.
        /// Calculates based on toppings and # of patties.
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = 204 * Patties;
                if (Ketchup) cal += 19;
                if (Mustard) cal += 3;
                if (Pickle) cal += 7;
                if (BBQ) cal += 94;
                if (Onion) cal += 29;
                if (Tomato) cal += 44;
                if (Lettuce) cal += 22;
                if (AmericanCheese) cal += 104;
                if (SwissCheese) cal += 106;
                if (Bacon) cal += 43;
                if (Mushrooms) cal += 4;

                return cal;
            }
        }

        /// <summary>
        /// Uint representing # of patties on a burger.
        /// </summary>
        public abstract uint Patties { get; set; }

        /// <summary>
        /// Initializes Ketchup to false;
        /// </summary>
        public bool _ketchup = false;

        /// <summary>
        /// Bool represents whether or not the burger has Ketchup.
        /// </summary>
        public bool Ketchup
        {
            get => _ketchup;
            set
            {
                _ketchup = value;
                OnPropertyChanged(nameof(Ketchup));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            } 
        }

        /// <summary>
        /// Initializes mustard to false.
        /// </summary>
        public bool _mustard = false;

        /// <summary>
        /// Bool represents whether or not the burger has Mustard.
        /// </summary>
        public bool Mustard
        {
            get => _mustard;
            set
            {
                _mustard = value;
                OnPropertyChanged(nameof(Mustard));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes pickle to false.
        /// </summary>
        public bool _pickle = false;

        /// <summary>
        /// Bool represents whether or not the burger has Pickle.
        /// </summary>
        public bool Pickle
        {
            get => _pickle;
            set
            {
                _pickle = value;
                OnPropertyChanged(nameof(Pickle));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes mayo to false.
        /// </summary>
        public bool _mayo = false;

        /// <summary>
        /// Bool represents whether or not the burger has Mayo.
        /// </summary>
        public bool Mayo
        {
            get => _mayo;
            set
            {
                _mayo = value;
                OnPropertyChanged(nameof(Mayo));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes BBQ to false.
        /// </summary>
        public bool _bbq = false;
        
        /// <summary>
        /// Bool represents whether or not the burger has BBQ.
        /// </summary>
        public bool BBQ
        {
            get => _bbq; 
            set
            {
                _bbq = value;
                OnPropertyChanged(nameof(BBQ));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes onion to false.
        /// </summary>
        public bool _onion = false;

        /// <summary>
        /// Bool represents whether or not the burger has Onion.
        /// </summary>
        public bool Onion
        {
            get => _onion;
            set
            {
                _onion = value;
                OnPropertyChanged(nameof(Onion));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes tomato to false.
        /// </summary>
        public bool _tomato = false;

        /// <summary>
        /// Bool represents whether or not the burger has Tomato.
        /// </summary>
        public bool Tomato
        {
            get => _tomato; 
            set
            {
                _tomato = value;
                OnPropertyChanged(nameof(Tomato));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes lettuce to false.
        /// </summary>
        public bool _lettuce = false;

        /// <summary>
        /// Bool represents whether or not the burger has Lettuce.
        /// </summary>
        public bool Lettuce
        {
            get => _lettuce;
            set
            {
                _lettuce = value;
                OnPropertyChanged(nameof(Lettuce));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes AmericanCheese to false.
        /// </summary>
        public bool _americancheese = false;

        /// <summary>
        /// Bool represents whether or not the burger has American Cheese.
        /// </summary>
        public bool AmericanCheese
        {
            get => _americancheese;
            set
            {
                _americancheese = value;
                OnPropertyChanged(nameof(AmericanCheese));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes SwissCheese to false.
        /// </summary>
        public bool _swisscheese = false;

        /// <summary>
        /// Bool represents whether or not the burger has Swiss Cheese.
        /// </summary>
        public bool SwissCheese
        {
            get => _swisscheese;
            set
            {
                _swisscheese = value;
                OnPropertyChanged(nameof(SwissCheese));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes bacon to false.
        /// </summary>
        public bool _bacon = false;
        
        /// <summary>
        /// Bool represents whether or not the burger has Bacon.
        /// </summary>
        public bool Bacon
        {
            get => _bacon;
            set
            {
                _bacon = value;
                OnPropertyChanged(nameof(Bacon));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

        /// <summary>
        /// Initializes mushrooms to false.
        /// </summary>
        public bool _mushrooms = false;

        /// <summary>
        /// Bool represents whether or not the burger has Mushrooms.
        /// </summary>
        public bool Mushrooms
        {
            get => _mushrooms;
            set
            {
                _mushrooms = value;
                OnPropertyChanged(nameof(Mushrooms));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Calories));
                OnPropertyChanged(nameof(SpecialInstructions));
            }
        }

    }
}
