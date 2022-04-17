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
using Services;

namespace testing_17._04
{
    /// <summary>
    /// Логика взаимодействия для PageRaz.xaml
    /// </summary>
    public partial class PageRaz : Page
    {
        public PageRaz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = double.TryParse(TextBoxA.Text, out double result1);
            var b = double.TryParse(TextBoxB.Text, out double result2);
            if(!(a&&b))
            {
                MessageBox.Show("хуй тебе");
            }
            else
            {
                ResultLabel.Content = Rasschet.CalculateRaz(result1, result2);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
