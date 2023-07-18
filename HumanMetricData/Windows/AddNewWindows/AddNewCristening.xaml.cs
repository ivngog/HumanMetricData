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
using System.Drawing;
using System.IO;
using HumanMetricData.SQLOperations;
using HumanMetricData.Images;

namespace HumanMetricData.Windows.AddNewWindows
{
    /// <summary>
    /// Логика взаимодействия для AddNewCristening.xaml
    /// </summary>
    public partial class AddNewCristening : Window
    {
        RUEN ruen;
        byte[] image_bytes;
        public AddNewCristening()
        {
            InitializeComponent();
            ruen = new RUEN();
            ChangeLanguage("En");
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
                image_bytes = File.ReadAllBytes(dlg.FileName);
                // Open document 
                string filename = dlg.FileName;

                Uri uri = new Uri(filename);
                ImageSource imgSource = new BitmapImage(uri);

                IMG.ImageSource = imgSource;
            }
        }

        public void ChangeLanguage(string lang)
        {
            ruen.ChengeLanguage(lang);
            AddNewRecord.Content = ruen.LabelAddRecordCristening;
            ActiveRecord.Content = ruen.ActiveRecord;
            from.Content = ruen.From;
            dateOfCristening.Content = ruen.DateOfCristening;
            Birtday.Content = ruen.Birthday;
            FirstName.Content = ruen.FirstName;
            LastName.Content = ruen.LastName;
            Patronymic.Content = ruen.Patronymic;
            PlaceOfregistration.Content = ruen.PlaceOfReg;
            SNBS.Content = ruen.SNBC;
            Parents.Content = ruen.Parents;
            FathersInitials.Content = ruen.Fatherinitials;
            MothersInitials.Content = ruen.Motherinitials;
            PassportM.Content = ruen.PassportM;
            PassportF.Content = ruen.PassportF;
            FatherBdate.Content = ruen.Birthday;
            MotherBdate.Content = ruen.Birthday;
            FAddress.Content = ruen.FAddress;
            MAddress.Content = ruen.MAddress;
            Recipients.Content = ruen.Recipients;
            Recipients1Init.Content = ruen.FirstRecipinest;
            Recipients2Init.Content = ruen.SecondRecipinest;
            PassportR1.Content = ruen.PassportR1;
            PassportR2.Content = ruen.PassportR2;
            R1Bdate.Content = ruen.R1Bdate;
            R2Bdate.Content = ruen.R2Bdate;
            R1Address.Content = ruen.R1Address;
            R2Address.Content = ruen.R2Address;
            Baptizer.Content = ruen.Baptizer;
            BaptizerInitizls.Content = ruen.BaptizerInitials;
            Notes.Content = ruen.Notes;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sql dataManipulation = new Sql();
                dataManipulation.InsertHuman(CrFirstName.Text, CrLastName.Text, CrPatronymic.Text, "", Convert.ToDateTime(CrDateOfBirth.SelectedDate));
                dataManipulation.InsertBase(AddActiveRecord.Text, Convert.ToDateTime(AROfDate.SelectedDate), Convert.ToDateTime(CrDateOfCristening.SelectedDate), dataManipulation.GetId(), CrPlaceOfCr.Text, NameOfPerformed.Text, CrNotes.Text, "Cristening", txt_FIinitials.Text, txt_MIinitials.Text, txt_R1initials.Text, txt_R2Iinitials.Text, txt_PassportFirsh.Text,
                txt_PassportSecond.Text, txt_PassportThird.Text, txt_PassportFour.Text, Convert.ToDateTime(BDateFirst.SelectedDate), Convert.ToDateTime(BDateSecond.SelectedDate), Convert.ToDateTime(BDateThird.SelectedDate), Convert.ToDateTime(BDateFour.SelectedDate), txt_AddressFirsh.Text, txt_AddressSecond.Text,
                txt_AddressThird.Text, txt_AddressFour.Text);
                dataManipulation.InsertDocuments(BirthCertNumber.Text, "", "", dataManipulation.GetId(), "");
                dataManipulation.InsertImages(image_bytes, dataManipulation.GetId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MessageBox.Show(ruen.SuccessfullyInserted); }
            /*  AddActiveRecord.Text;
              AROfDate.SelectedDate;
              CrFirstName.Text;
              CrLastName.Text;
              CrPatronymic.Text;
              CrDateOfBirth.SelectedDate;
              CrDateOfCristening.SelectedDate;
              CrPlaceOfCr.Text;
              BirthCertNumber.Text;
              txt_FIinitials.Text;
              txt_MIinitials.Text;
              txt_R1initials.Text;
              txt_R2Iinitials.Text;
              txt_PassportFirsh;
              txt_PassportSecond;
              txt_PassportThird;
              txt_PassportFour;
              txt_AddressFirsh;
              txt_AddressSecond;
              txt_AddressThird;
              txt_AddressFour;
              BDateFirst.SelectedDate;
              BDateSecond.SelectedDate;
              BDateThird.SelectedDate;
              BDateFour.SelectedDate;
              NameOfPerformed.Text;
              CrNotes.Text; */

        }
    }
}
