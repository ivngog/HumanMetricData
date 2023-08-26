using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HumanMetricData.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainAppWindow.xaml
    /// </summary>
    public partial class MainAppWindow : Window
    {
        CristeningWin crist;
        WeddingWin weddingWind;
        FuneralWin funeralWin;
        string language;
        public MainAppWindow()
        {
            InitializeComponent();
            
            Eng.Checked += btnEng_Click;
        }

        private void btnRu_Click(object sender, RoutedEventArgs e)
        {
            language = "Ru";
        }
        private void btnEng_Click(object sender, RoutedEventArgs e)
        {
            language = "En";
        }

        private void OpenCristening_Click(object sender, RoutedEventArgs e )
        {
            
            crist = new CristeningWin("Cristening", language);
            MainContent.Content = crist.Content;
        }
        private void OpenWedding_Click(object sender, RoutedEventArgs e)
        {
           
            weddingWind = new WeddingWin("Wedding", language);
            MainContent.Content = weddingWind.Content;
        }
        private void OpenFuneral_Click(object sender, RoutedEventArgs e)
        {
            
            funeralWin = new FuneralWin("Funeral", language);
            MainContent.Content = funeralWin.Content;
        }

        
    }
}
