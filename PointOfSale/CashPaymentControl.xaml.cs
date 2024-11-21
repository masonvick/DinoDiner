using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {

        /// <summary>
        /// dependency property representing the coin this control represents.
        /// </summary>
        public static DependencyProperty ChangeDenominationProperty = DependencyProperty.Register("ChangeOwed", typeof(uint), typeof(CashDrawerData));

        /// <summary>
        /// The change to give back
        /// </summary>
        public uint ChangeOwed
        {
            get { return (uint)GetValue(ChangeDenominationProperty); }
            set { SetValue(ChangeDenominationProperty, value); }
        }

        public static DependencyProperty CustomerDenominationProperty = DependencyProperty.Register("CustomerPayment", typeof(uint), typeof(CashDrawerData));

        /// <summary>
        /// The customer payment
        /// </summary>
        public uint CustomerPayment
        {
            get { return (uint)GetValue(CustomerDenominationProperty); }
            set { SetValue(CustomerDenominationProperty, value); }
        }

        public static DependencyProperty RegisterDenominationProperty = DependencyProperty.Register("RegisterAmount", typeof(uint), typeof(CashDrawerData));

        /// <summary>
        /// The money in the register
        /// </summary>
        public uint RegisterAmount
        {
            get { return (uint)GetValue(RegisterDenominationProperty); }
            set { SetValue(RegisterDenominationProperty, value); }
        }

        public CashPaymentControl()
        {
            InitializeComponent();
        }
    }
}
