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
namespace HumanMetricData.Windows.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditWedding.xaml
    /// </summary>
    public partial class EditWedding : Window
    {
        public EditWedding()
        {
            InitializeComponent();
            ChangeLanguage("en");
            OpenImage2.Click += OpenImage_Click;
        }


        protected void ChangeLanguage(string lang)
        {
            RUEN ruen = new RUEN();
            ruen.ChengeLanguage(lang);
            ActiveRecord.Content = ruen.ActiveRecord;
            from.Content = ruen.From;
            GettingMaried.Content = ruen.GettingMaried;
            GettigMariedMan.Content = ruen.GettingMariedMan;
            GettingMariedWoman.Content = ruen.GettingMariedWoman;
            GettingMariedBDateMan.Content = ruen.GettingMariedBirthDateMan;
            GettingMariedBirthDateWoman.Content = ruen.GettingMariedBirthDateWoman;
            PassportGMMan.Content = ruen.PassportGMMan;
            PassportGMWoman.Content = ruen.PassportGMWoman;
            GMAddressMan.Content = ruen.GMAddressMan;
            GMAddressWoman.Content = ruen.GMAddressWoman;
            Witnesses.Content = ruen.Witnesses;
            WitnessFirst.Content = ruen.WitnessFirst;
            W1Bdate.Content = ruen.W1Bdate;
            W1Address.Content = ruen.W1Address;
            PassportW1.Content = ruen.PassportW1;

            WitnessSecond.Content = ruen.WitnessSecond;
            W2Address.Content = ruen.W2Address;
            W2Bdate.Content = ruen.W2Bdate;
            PassportW2.Content = ruen.PassportW2;
            Crowning.Content = ruen.Crowning;
            CrowningInitials.Content = ruen.CrowningInitials;
            Notes.Content = ruen.Notes;
            EditWeddingRecord.Content = ruen.EditWedding;
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
