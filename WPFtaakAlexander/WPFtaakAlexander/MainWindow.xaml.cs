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
using System;
using System.IO;


namespace WPFtaakAlexander

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

            private void pxlImage_MouseEnter(object sender, MouseEventArgs e)
            {
                mainWindow.Background = Brushes.Black;
            }

            private void pxlImage_MouseLeave(object sender, MouseEventArgs e)
            {
                mainWindow.Background = Brushes.White;

            }
        }
    }