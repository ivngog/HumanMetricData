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
using HumanMetricData.Windows.AddNewWindows;
using HumanMetricData.Windows.EditWindows;

namespace HumanMetricData.Windows
{
    /// <summary>
    /// Логика взаимодействия для CristeningWin.xaml
    /// </summary>
    public partial class CristeningWin : Window
    {
        public CristeningWin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNewCristening addCristening = new AddNewCristening();
            addCristening.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditCristening editCristening = new EditCristening();
            editCristening.Show();
        }
    }
}
