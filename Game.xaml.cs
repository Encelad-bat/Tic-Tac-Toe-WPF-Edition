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

namespace Tic_Tac_Toe_WPF_Edition_
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        string symbol = "X";
        public Game()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).Content == null)
            {
                (sender as Button).Content = this.symbol;
            }

            if(zero_id_Button.Content == one_id_Button.Content && one_id_Button.Content == two_id_Button.Content && zero_id_Button.Content != null)
            {
                MessageBox.Show($"Player {zero_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(zero_id_Button.Content == four_id_Button.Content && four_id_Button.Content == eight_id_Button.Content && zero_id_Button.Content != null)
            {
                MessageBox.Show($"Player {zero_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(zero_id_Button.Content == three_id_Button.Content && three_id_Button.Content == six_id_Button.Content && zero_id_Button.Content != null)
            {
                MessageBox.Show($"Player {zero_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(one_id_Button.Content == four_id_Button.Content && four_id_Button.Content == seven_id_Button.Content && one_id_Button.Content != null)
            {
                MessageBox.Show($"Player {one_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(two_id_Button.Content == five_id_Button.Content && five_id_Button.Content == eight_id_Button.Content && two_id_Button.Content != null)
            {
                MessageBox.Show($"Player {two_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(three_id_Button.Content == four_id_Button.Content && four_id_Button.Content == five_id_Button.Content && three_id_Button.Content != null)
            {
                MessageBox.Show($"Player {three_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(six_id_Button.Content == seven_id_Button.Content && seven_id_Button.Content == eight_id_Button.Content && six_id_Button.Content != null)
            {
                MessageBox.Show($"Player {six_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }
            else if(six_id_Button.Content == four_id_Button.Content && four_id_Button.Content == two_id_Button.Content && six_id_Button.Content != null)
            {
                MessageBox.Show($"Player {six_id_Button.Content}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Current.Shutdown();
            }

            if (this.symbol == "X")
            {
                this.symbol = "O";
            }
            else
            {
                this.symbol = "X";
            }
        }
    }
}
