using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ATM_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>     
    public partial class MainWindow : Window
    {

        string input = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        public ObservableCollection<Classes.Information> Info = new ObservableCollection<Classes.Information>();//Gives access to Information.cs
        public ObservableCollection<Classes.AccountCalculations> Calculator = new ObservableCollection<Classes.AccountCalculations>();//Gives access to AccountCalcutaion.cs             

         

        private void Begin(object sender, RoutedEventArgs e)//Creates the user information
        {
            Classes.Information File = new Classes.Information();
            
            var UserOne = Classes.Information.AccountCreation("John", "Doe", "1234", "5000");
        }

        private void Tester_Click(object sender, RoutedEventArgs e)//Reads typed text in box
        {            
            Classes.Information Lock = new Classes.Information();

            var UserOne = Classes.Information.AccountCreation("John", "Doe", "1234", "5000");           

            string PIN = KeyBox.Text;
            
            if (PIN == UserOne.AccountPIN)//Checks if the PIN matches the recorded PIN
            {
                TestingBox.Text = "Correct PIN";                
            }
            else
            {
                TestingBox.Text = "Incorrect PIN, Try Again";
            }            
        }

        private void keyDown(object sender, KeyEventArgs e)//Detects input of enter key for Pin box
        {
            int i = 0;//Allows for input box to be used multiple times            
            if (e.Key == Key.Enter)
            {
                string PIN = KeyBox.Text; ///reads text in box
                Tester_Click(this, new RoutedEventArgs());
                i++;
            }           
        }


        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {                       
            TestingBox.Text = string.Format("Confirmed {0}", TestingBox.Text);                                   
        }
        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            TestingBox.Text = string.Format("Confirmed Second {0}", TestingBox.Text);
        }
        private void ThirdButton_Click(object sender, RoutedEventArgs e)
        {
            TestingBox.Text = string.Format("Confirmed Third {0}", TestingBox.Text);
        }
        private void FourthButton_Click(object sender, RoutedEventArgs e)
        {
            TestingBox.Text = string.Format("Confirmed Fourth {0}", TestingBox.Text);
        }
        private void FifthButton_Click(object sender, RoutedEventArgs e)
        {
            TestingBox.Text = string.Format("Confirmed Fifth {0}", TestingBox.Text);
        }       
    }    
}
