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

namespace dodaj_pracownika
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

        private void generatePassword(object sender, RoutedEventArgs e)
        {
            StringBuilder password = new StringBuilder();

            int num_of_characters = int.Parse(characters_num.Text);

            bool letters = (bool)big_and_small_letters.IsChecked;

            bool digits = (bool)has_integers.IsChecked;

            bool special_char = (bool)has_special_letters.IsChecked;

            List<bool> true_list = new List<bool>();

            if (letters)
            {
                true_list.Append(letters);
            }else if (digits)
            {
                true_list.Append(digits);
            }else if (special_char)
            {
                true_list.Append(special_char);
            }



            for(int i = 0; i < num_of_characters; i++)
            {
                Random random = new Random();

                random.Next();
            }


        }
    }
}
