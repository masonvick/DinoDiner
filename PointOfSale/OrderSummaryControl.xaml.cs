using DinoDiner.Data;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {

        /// <summary>
        /// Default control window
        /// </summary>
        private MainWindow ControlWindow => Application.Current.MainWindow as MainWindow;

        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        public void EditClick(object sender, RoutedEventArgs e)
        {

        }
        void RemoveClick(object sender, RoutedEventArgs e)
        {
            /*if (DataContext is Order order && sender is Button button && button.DataContext is MenuItem item)
            {
                var usercontrol = (UserControl)ControlWindow.MenuItemBorder.Child = new MenuItemSelectionControl();
            }*/
        }

    }
}
