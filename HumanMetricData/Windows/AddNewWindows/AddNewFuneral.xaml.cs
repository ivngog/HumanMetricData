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
using HumanMetricData.Languages;

namespace HumanMetricData.Windows.AddNewWindows
{
    /// <summary>
    /// Логика взаимодействия для AddNewFuneral.xaml
    /// </summary>
    public partial class AddNewFuneral : Window
    {
        public AddNewFuneral()
        {
            InitializeComponent();
            ChangeLanguage("en");
        }

        public void ChangeLanguage(string lang)
        {
            RUEN ruen = new RUEN();
            ruen.ChengeLanguage(lang);
            AddNewFuneralRecord.Content = ruen.AddNewFuneralRecord;
            ActiveRecord.Content = ruen.ActiveRecord;
            from.Content = ruen.From;
            DateOfFuneral.Content = ruen.DateOfFuneral;
            dateOfDeath.Content = ruen.DateOfDeath;
            Birtday.Content = ruen.Birthday;
            FirstName.Content = ruen.FirstName;
            LastName.Content = ruen.LastName;
            Patronymic.Content = ruen.Patronymic;
            PlaceOfFuneral.Content = ruen.PlaceOfFuneral;
            SNCD.Content = ruen.SNCD;
            Notes.Content = ruen.Notes;
            FuneralService.Content = ruen.FuneralService;
            FuneralDirector.Content = ruen.FuneralDirector;
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                Uri uri = new Uri(filename);
                ImageSource imgSource = new BitmapImage(uri);
                IMG.ImageSource = imgSource;
            }
        }
    }
}
