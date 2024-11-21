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
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        /// <summary>
        /// Default main window.
        /// </summary>
        private MainWindow mainWindow => Application.Current.MainWindow as MainWindow;

        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to display the correct customization control for the burger button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnBurgerClick(object sender, RoutedEventArgs e)
        {
            BurgerCustomize.Visibility = Visibility.Visible;
            
            if(sender is Button b)
            {

                switch (b.Name.ToString())
                {
                    case "Allosaurus":
                        AllosaurusAll_AmericanBurger allosaurus = new();
                        var listA = new BurgerCustomizationControl();
                        {
                            DataContext = allosaurus;
                        }
                        MenuItemBorder.Child = listA;
                        mainWindow._order.Add(allosaurus);
                        break;
                    case "Carnotaurus":
                        CarnotaurusCheeseburger carnotaurus = new();
                        var listC = new BurgerCustomizationControl();
                        {
                            DataContext = carnotaurus;
                        }
                        MenuItemBorder.Child = listC;
                        mainWindow._order.Add(carnotaurus);
                        break;
                    case "Deinonychus":
                        DeinonychusDouble deinonychus = new DeinonychusDouble();
                        var listD = new BurgerCustomizationControl();
                        {
                            DataContext = deinonychus;
                        }
                        MenuItemBorder.Child = listD;
                        mainWindow._order.Add(deinonychus);
                        break;
                    case "TRexTriple":
                        TRexTriple trex = new();
                        var listT = new BurgerCustomizationControl();
                        {
                            DataContext = trex;
                        }
                        MenuItemBorder.Child = listT;
                        mainWindow._order.Add(trex);
                        break;

                }
            }
        }



        /*
          
          switch (b.Name.ToString())
                {
                    case "Allosaurus":
                        AllosaurusAll_AmericanBurger allosaurus = new AllosaurusAll_AmericanBurger();
                        BurgerCustomize.DataContext = allosaurus;
                        BurgerCustomize.BurgerName.Text = allosaurus.Name;
                        mainWindow._order.Add(allosaurus);
                        break;
                    case "Carnotaurus":
                        CarnotaurusCheeseburger carnotaurus = new CarnotaurusCheeseburger();
                        BurgerCustomize.DataContext = carnotaurus;
                        BurgerCustomize.BurgerName.Text = carnotaurus.Name;
                        mainWindow._order.Add(carnotaurus);
                        break;
                    case "Deinonychus":
                        DeinonychusDouble deinonychus = new DeinonychusDouble();
                        BurgerCustomize.DataContext = deinonychus;
                        BurgerCustomize.BurgerName.Text = deinonychus.Name;
                        mainWindow._order.Add(deinonychus);
                        break;
                    case "TRexTriple":
                        TRexTriple trex = new TRexTriple();
                        BurgerCustomize.DataContext = trex;
                        BurgerCustomize.BurgerName.Text = trex.Name;
                        mainWindow._order.Add(trex);
                        break;

                }
          
          
         
          
          */



        /// <summary>
        /// Event handler to display the correct customization control for the brontowurst button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnBrontowurstClick(object sender, RoutedEventArgs e)
        {
            var wurst = new Brontowurst();
            var list = new BrontowurstCustomizationControl();
            {
                DataContext = wurst;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(wurst);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the peanut butter and jelly button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnPBJClick(object sender, RoutedEventArgs e)
        {
            var pbj = new PrehistoricPBJ();
            var list = new PrehistoricPBJCustomizationControl();
            {
                DataContext = pbj;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(pbj);
        }
        /// <summary>
        /// Event handler to display the correct customization control for the pterodactyl wings button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnWingsClick(object sender, RoutedEventArgs e)
        {
            var wings = new PterodactylWings();
            var list = new PterodactylWingsCustomizationControl();
            {
                DataContext = wings;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(wings);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the velociwraptor button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnWraptorClick(object sender, RoutedEventArgs e)
        {
            var wrap = new VelociWraptor();
            var list = new VelociWraptorCustomizationControl();
            {
                DataContext = wrap;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(wrap);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the dino nuggets button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnDinoNuggetClick(object sender, RoutedEventArgs e)
        {
            var nugs = new DinoNuggets();
            var list = new DinoNuggetsCustomizationControl();
            {
                DataContext = nugs;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(nugs);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the fryceritops button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnFryClick(object sender, RoutedEventArgs e)
        {
            var fries = new Fryceritops();
            var list = new FryceritopsCustomizationControl();
            {
                DataContext = fries;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(fries);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the meteor mac and cheese button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnMeteorMacClick(object sender, RoutedEventArgs e)
        {
            var mac = new MeteorMacAndCheese();
            var list = new MeteorMacAndCheeseCustomizationControl();
            {
                DataContext = mac;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(mac);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the mezzorella sticks button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnMezzorellaClick(object sender, RoutedEventArgs e)
        {
            var sticks = new MezzorellaSticks();
            var list = new MezzorellaSticksCustomizationControl();
            {
                DataContext = sticks;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(sticks);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the triceritots button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnTriTotsClick(object sender, RoutedEventArgs e)
        {
            var tots = new Triceritots();
            var list = new TriceritotsCustomizationControl();
            {
                DataContext = tots;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(tots);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the plilosoda button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnSodaClick(object sender, RoutedEventArgs e)
        {
            var soda = new Plilosoda();
            var list = new PlilosodaCustomizationControl();
            {
                DataContext = soda;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(soda);
        }

        /// <summary>
        /// Event handler to display the correct customization control for the cretaceous coffee button click.
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">event argument</param>
        void OnCoffeeClick(object sender, RoutedEventArgs e)
        {
            var coffee = new CretaceousCoffee();
            var list = new CretaceousCoffeeCustomizationControl();
            {
                DataContext = coffee;
            }
            MenuItemBorder.Child = list;
            mainWindow._order.Add(coffee);
        }


    }
}
