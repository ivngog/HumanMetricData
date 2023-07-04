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
    /// Логика взаимодействия для FuneralWin.xaml
    /// </summary>
    public partial class FuneralWin : Window
    {
        public FuneralWin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNewFuneral addFuneral = new AddNewFuneral();
            addFuneral.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditFuneral editFuneral = new EditFuneral();
            editFuneral.Show();
        }
    }
}
