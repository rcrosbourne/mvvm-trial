using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserViewModel userViewModel = new UserViewModel();
        public MainWindow()
        {
            InitializeComponent();
            //Set data context to set up bindings
            this.Loaded += (s, e) => { this.DataContext = userViewModel; };
        }
    }
}
