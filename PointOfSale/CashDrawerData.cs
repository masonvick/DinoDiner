using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundRegister;
using DinoDiner.Data;

namespace DinoDiner.PointOfSale
{
    public class CashDrawerData : INotifyPropertyChanged
    {




        public event PropertyChangedEventHandler? PropertyChanged;

        //add variable for amount due from customer (amount due -> red box on GUI)


        private decimal _amountDue;
        public decimal AmountDue
        {
            get => _amountDue;
            set
            {
                _amountDue = value;
            }
        }

        private decimal _changeOwed;

        public decimal ChangedOwed
        {
            get => _changeOwed;
            set
            {
                _changeOwed = value;
            }
        } 
        //var for total amount to give as change (green box on GUI)
        //method to calculate the amount of change to give them

        //total for amount of money customer gave (from the order, dont need to make in here)

        //invokes in properties for customer money thats given to me






        //----------------REGISTER----------------------
        //coins in drawer
        public uint DrawerPennies { get => CashDrawer.Pennies; }

        public uint DrawerNickels { get => CashDrawer.Nickles; }

        public uint DrawerDimes { get => CashDrawer.Dimes; }

        public uint DrawerQuarters { get => CashDrawer.Quarters; }

        public uint DrawerHalfDollarCoins { get => CashDrawer.HalfDollarCoins; }

        public uint DrawerDollarCoins { get => CashDrawer.DollarCoins; }

//bills in drawer
        public uint DrawerOnes { get => CashDrawer.Ones; }

        public uint DrawerTwos { get => CashDrawer.Twos; }

        public uint DrawerFives { get => CashDrawer.Fives; }

        public uint DrawerTens { get => CashDrawer.Tens; }

        public uint DrawerTwenties { get => CashDrawer.Twenties; }

        public uint DrawerFifties { get => CashDrawer.Fifties; }

        public uint DrawerHundreds { get => CashDrawer.Hundreds; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private uint _customerPennies;

        public uint CustomerPennies
        {
            get { return _customerPennies; }
            set
            {
                _customerPennies = value;
                OnPropertyChanged(nameof(CustomerPennies));
                OnPropertyChanged(nameof(DrawerPennies));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerNickels;

        public uint CustomerNickels
        {
            get { return _customerNickels; }
            set
            {
                _customerNickels = value;
                OnPropertyChanged(nameof(CustomerNickels));
                OnPropertyChanged(nameof(DrawerNickels));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerDimes;

        public uint CustomerDimes
        {
            get { return _customerDimes; }
            set
            {
                _customerDimes = value;
                OnPropertyChanged(nameof(CustomerDimes));
                OnPropertyChanged(nameof(DrawerDimes));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerQuarters;

        public uint CustomerQuarters
        {
            get { return _customerQuarters; }
            set
            {
                _customerQuarters = value;
                OnPropertyChanged(nameof(CustomerQuarters));
                OnPropertyChanged(nameof(DrawerQuarters));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerHalfDollarCoins;

        public uint CustomerHalfDollarCoins
        {
            get { return _customerHalfDollarCoins; }
            set
            {
                _customerHalfDollarCoins = value;
                OnPropertyChanged(nameof(CustomerHalfDollarCoins));
                OnPropertyChanged(nameof(DrawerHalfDollarCoins));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerDollarCoins;

        public uint CustomerDollarCoins
        {
            get { return _customerDollarCoins; }
            set
            {
                _customerDollarCoins = value;
                OnPropertyChanged(nameof(CustomerDollarCoins));
                OnPropertyChanged(nameof(DrawerDollarCoins));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerOnes;

        public uint CustomerOnes
        {
            get => _customerOnes;
            set
            {
                _customerOnes = value;
                OnPropertyChanged(nameof(CustomerOnes));
                OnPropertyChanged(nameof(DrawerOnes));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerTwos;

        public uint CustomerTwos
        {
            get => _customerTwos;
            set
            {
                _customerTwos = value;
                OnPropertyChanged(nameof(CustomerTwos));
                OnPropertyChanged(nameof(DrawerTwos));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerFives;

        public uint CustomerFives
        {
            get => _customerFives;
            set
            {
                _customerFives = value;
                OnPropertyChanged(nameof(CustomerFives));
                OnPropertyChanged(nameof(DrawerFives));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerTens;

        public uint CustomerTens
        {
            get => _customerTens;
            set
            {
                _customerTens = value;
                OnPropertyChanged(nameof(CustomerTens));
                OnPropertyChanged(nameof(DrawerTens));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerTwenties;

        public uint CustomerTwenties
        {
            get => _customerTwenties;
            set
            {
                _customerTwenties = value;
                OnPropertyChanged(nameof(CustomerTwenties));
                OnPropertyChanged(nameof(DrawerTwenties));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerFifties;

        public uint CustomerFifties
        {
            get => _customerFifties;
            set
            {
                _customerFifties = value;
                OnPropertyChanged(nameof(CustomerFifties));
                OnPropertyChanged(nameof(DrawerFifties));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

        private uint _customerHundreds;

        public uint CustomerHundreds
        {
            get => _customerHundreds;
            set
            {
                _customerHundreds = value;
                OnPropertyChanged(nameof(CustomerHundreds));
                OnPropertyChanged(nameof(DrawerHundreds));
                OnPropertyChanged(nameof(AmountDue));
                OnPropertyChanged(nameof(ChangedOwed));
            }
        }

    }
}
