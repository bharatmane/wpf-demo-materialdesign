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

namespace MyWPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _firstName;

        private string _lastNamechange;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {

                return _lastNamechange;
            }
            set
            {
                _lastNamechange = value;
            }
        }

        public string FullName
        {
            get
            {
                return _firstName + " " + _lastNamechange;
            }
        }
        
         public string FullName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public MainWindow()
        {
            this.DataContext = this;
            FirstName = "Bharat";
            LastName = "Mane";
            InitializeComponent();
        }
    }
}
