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
        CristeningWin crist = new CristeningWin();
        WeddingWin weddingWind = new WeddingWin();
        FuneralWin funeralWin = new FuneralWin();
        public MainAppWindow()
        {
            InitializeComponent();
            
        }

        private void OpenCristening_Click(object sender, RoutedEventArgs e )
        {
            MainContent.Content = crist.Content;
        }
        private void OpenWedding_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = weddingWind.Content;
        }
        private void OpenFuneral_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = funeralWin.Content;
        }
    }
}
