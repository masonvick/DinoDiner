using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace DinoDiner.Data
{
    /// <summary>
    /// Class for an order of food, sides, and drinks.
    /// </summary>
    public class Order : ObservableCollection<MenuItem>
    {

        /// <summary>
        /// Decimal for the sales tax rate (default to 0.09)
        /// </summary>
        public decimal SalesTaxRate { get; set; } = 0.09m;

        /// <summary>
        /// Subtotal of all items in the order list.
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal total = 0;
                for(int i = 0; i < this.Count; i++)
                {
                    total += this[i].Price;
                }
                return total;
            }
        }


        /// <summary>
        /// Amount of tax, according to SalesTaxRate (defaulted to 0.09)
        /// </summary>
        public decimal Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// Total price of the order.
        /// </summary>
        public decimal Total { get => Subtotal + Tax; }

        /// <summary>
        /// Calories constructor that adds calories of all items in the order list.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                for (int i = 0; i <  this.Count; i++)
                {
                    calories += this[i].Calories;
                }
                return calories;
            }
            
        }

        /// <summary>
        /// private backing field for DateTime.
        /// </summary>
        private DateTime _dateTime = DateTime.Now;

        /// <summary>
        /// The time that the order was placed.
        /// </summary>
        public DateTime PlacedAt { get { return _dateTime; } }

        /// <summary>
        /// The order number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Integer to keep track of what the next order number is.
        /// </summary>
        private static int _nextOrderNumber = 1;
        
        /// <summary>
        /// Constructor for the order class.
        /// </summary>
        public Order()
        {
            CollectionChanged += CollectionChangedListener;
            Number = _nextOrderNumber;
            _nextOrderNumber++;
        }

        public void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));
            }
        }

        /// <summary>
        /// Listener for events that change the collection.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        public void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
   
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Subtotal)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if(e.NewItems != null)
                    {
                        foreach(MenuItem item in e.NewItems)
                        {
                            item.PropertyChanged += CollectionItemChangedListener;
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if(e.NewItems != null)
                    {
                        foreach(MenuItem item in e.OldItems)
                        {
                            item.PropertyChanged -= CollectionItemChangedListener;
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not available!"); 
            }
        }

    }
}
