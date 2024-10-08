﻿using System.Text;
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

        private void roodImage_Click(object sender, MouseButtonEventArgs e)
        {
            kleurShow.Text = "- Rood #FF0000";
            infoShow.Text = "Rood is de kleur van warmte";
        }

        private void geelImage_Click(object sender, MouseButtonEventArgs e)
        {
            kleurShow.Text = "- Geel #FFFF00";
            infoShow.Text = "Geel is de kleur van levenslust";
        }

        private void blauwImage_Click(object sender, MouseButtonEventArgs e)
        {
            kleurShow.Text = "- Blauw: #0000FF";
            infoShow.Text = "Blauw is de kleur van intelligentie";
        }

        private void groenImage_Click(object sender, MouseButtonEventArgs e)
        {
            kleurShow.Text = "- Groen: #008000";
            infoShow.Text = "Groen is de kleur van genezing";
        }
    }

}