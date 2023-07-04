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
    /// Логика взаимодействия для WeddingWin.xaml
    /// </summary>
    public partial class WeddingWin : Window
    {
        public WeddingWin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNewWedding addWedding = new AddNewWedding();
            addWedding.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWedding editWedding = new EditWedding();
            editWedding.Show();
        }
    }
}
