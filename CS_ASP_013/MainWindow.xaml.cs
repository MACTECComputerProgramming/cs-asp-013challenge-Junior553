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

namespace CS_ASP_013
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            labelAnswer.Content = "  ";
            labelCost.Content = "   ";
            //choices
            string subsize = "";
            string meat = "";
            string bread = "";
            string american = "";
            string swiss = "";
            string pepperjack = "";
            string cucumber = "";
            string greenpepper = "";
            string lettuce = "";
            string redonion = "";
            string allveggies = "";

            //cost
            double cost = 0;
            double greenpeppercost = 0;
            double lettucecost = 0;
            double redonioncost = 0;

            //subsize
            if (radioButtonSix.IsChecked == true)
            {
                subsize = "Six Inch Sub, ";
                cost = cost + 3.50;
            }
            else if (radioButtonFoot.IsChecked == true)
            {
                subsize = "Foot Long Sub, ";
                cost = cost + 5.00;
            }

            //bread
            if (radioButtonWheat.IsChecked == true)
            {
                bread = "Wheat, ";
            }
            else if (radioButtonItalian.IsChecked == true)
            {
                bread = "Italian, ";
            }
            else if (radioButtonFlat.IsChecked == true)
            {
                bread = "Flatbread, ";
                cost = cost + .5;
            }

            //meat
            if (radioButtonHam.IsChecked == true)
            {
                meat = "Ham, ";
            }
            else if (radioButtonChicken.IsChecked == true)
            {
                meat = "Roasted Chicken, ";
            }
            else if (radioButtonMeatball.IsChecked == true)
            {
                meat = "Meatball, ";
                cost = cost + 1.00;
            }
            else if (radioButtonSteak.IsChecked == true)
            {
                meat = "Steak, ";
                cost = cost + 1.50;
            }

            //cheese
            if (checkBoxAmerican.IsChecked == true)
            {
                american = "American, ";
                cost = cost + .25;
            }
            if (checkBoxSwiss.IsChecked == true)
            {
                swiss = "Swiss, ";
                cost = cost + .30;
            }
            if (checkBoxPJ.IsChecked == true)
            {
                pepperjack = "Pepperjack, ";
                cost = cost + .75;
            }

            //veggies
            if (checkBoxCucumber.IsChecked == true)
            {
                cucumber = "Cucumber, ";
            }
            if (checkBoxGP.IsChecked == true)
            {
                greenpepper = "Green Pepper, ";
                greenpeppercost = .25;
            }
            if (checkBoxLettuce.IsChecked == true)
            {
                lettuce = "Lettuce, ";
                lettucecost = .15;
            }
            if (checkBoxRO.IsChecked == true)
            {
                redonion = "Red Onion, ";
                redonioncost = .10;
            }
            if (checkBoxAV.IsChecked == true)
            {
                allveggies = "All Veggies, ";
                cost = cost + .25 - greenpeppercost - lettucecost - redonioncost;
            }

            if ((radioButtonFoot.IsChecked == true) && (radioButtonWheat.IsChecked == true) && (radioButtonMeatball.IsChecked == true) && (checkBoxAmerican.IsChecked == true))
            {
                cost = cost - 2.00;
            }

            cost = cost + greenpeppercost + lettucecost + redonioncost;
            labelAnswer.Content = subsize + bread + meat + american + swiss + pepperjack + cucumber + greenpepper + lettuce + redonion + allveggies;
            labelCost.Content = "$" + cost;
        }
    }
}
