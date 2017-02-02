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

namespace pizzas
{
    /// <summary>
    /// Interaction logic for pizza.xaml
    /// </summary>
    public partial class pizza : Window
    {
        public pizza()
        {
            InitializeComponent();
        }

        private void extradikkekorst_Click(object sender, RoutedEventArgs e)
        {

        }

        private void extrakaas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ham_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ananas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void salami_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                      
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            int aantalpizza = int.Parse((string)hoeveelheid.Content);

            if (aantalpizza > 1)
            {
                aantalpizza = aantalpizza - 1;
                hoeveelheid.Content = aantalpizza.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {

            int aantalpizza = int.Parse((string)hoeveelheid.Content);

            if (aantalpizza < 10)
            {
                aantalpizza = aantalpizza + 1;
                hoeveelheid.Content = aantalpizza.ToString();
            }
        }

        private void bestellen_Checked(object sender, RoutedEventArgs e)
        {
            string smallmediumlarge = "", metham = "", mettomaat = " tomaat, ", metkaas = " kaas, ", metananas = "", metsalami = "", metextradikkekorst = "", metextrakaas = "";

            if (ham.IsChecked == true)
                metham = " ham, ";

            if (ananas.IsChecked == true)
                metananas = " ananas, ";

            if (salami.IsChecked == true)
                metsalami = "salami, ";

            if (extradikkekorst.IsChecked == true)
                metextradikkekorst = " met extra dikke korst, ";

            if (extrakaas.IsChecked == true)
                metextrakaas = " met extra kaas, ";

            if (extradikkekorst.IsChecked == true)
                metextradikkekorst = " met extra dikke korst, ";

            if (extrakaas.IsChecked == true)
                metextrakaas = " met extra kaas, ";

            if (small.IsChecked == true)
            { smallmediumlarge = "small"; }
            else if (medium.IsChecked == true)
            { smallmediumlarge = "medium"; }
            else { smallmediumlarge = "large"; }

            bestelling.Content = new TextBlock() { TextWrapping = TextWrapping.Wrap, Text = "U heeft " + hoeveelheid.Content + " " + smallmediumlarge + " pizza('s) besteld met :" + mettomaat + metkaas + metham + metsalami + "overstrooid " + metextradikkekorst + metextrakaas };
        }

        private void bestellen_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
