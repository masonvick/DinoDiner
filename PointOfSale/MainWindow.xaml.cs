using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using DinoDiner.PointOfSale;
using DinoDiner.Data;


namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Order
        /// </summary>
        public Order? _order;

        public MainWindow()
        {
            InitializeComponent();
            _order = new();
            DataContext = _order;   
        }

        /// <summary>
        /// Hides the CustomizationControl and show the ItemCustomizationControl when this button is pressed
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void OnAddMoreItemsClick(object sender, RoutedEventArgs e)
        {
            var list = new MenuItemSelectionControl();
            ContainerBorder.Child = list;
        }

        /// <summary>
        /// Hides the customization control and shows the item selection control. Will cancel current order eventually.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            var list = new MenuItemSelectionControl();
            ContainerBorder.Child = list;
        }

        /// <summary>
        /// Hides the customization Control and shows the item selection control.Eventually will complete the order.
        /// </summary>
        /// <param name="sender">ovject being sent</param>
        /// <param name="e">event argument</param>
        void OnCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            var list = new MenuItemSelectionControl();
            ContainerBorder.Child = list;
        }
    }
}
