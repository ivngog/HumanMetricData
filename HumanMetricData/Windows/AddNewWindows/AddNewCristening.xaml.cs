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
        readonly RUEN ruen;
        byte[] image_bytes;
        public AddNewCristening(string language)
        {
            InitializeComponent();
            ruen = new RUEN();
            ChangeLanguage("en");
            ChangeLanguage(language);
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenAndReadImage openImg = new OpenAndReadImage();
                IMG.ImageSource = openImg.OpenImg();
                image_bytes = openImg.readBytes();

            }
            catch { }
            
            
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
            address.Content = ruen.Address;
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
                Sql sql = new Sql();
                sql.InsertHuman(CrFirstName.Text, CrLastName.Text, CrPatronymic.Text, Address.Text, (DateTime)CrDateOfBirth.SelectedDate, DateTime.MinValue);
                sql.InsertBase(AddActiveRecord.Text, Convert.ToDateTime(AROfDate.SelectedDate), Convert.ToDateTime(CrDateOfCristening.SelectedDate), sql.GetId(), CrPlaceOfCr.Text, NameOfPerformed.Text, CrNotes.Text, "Cristening", txt_FIinitials.Text, txt_MIinitials.Text, txt_R1initials.Text, txt_R2Iinitials.Text, txt_PassportFirsh.Text,
                txt_PassportSecond.Text, txt_PassportThird.Text, txt_PassportFour.Text, Convert.ToDateTime(BDateFirst.SelectedDate), Convert.ToDateTime(BDateSecond.SelectedDate), Convert.ToDateTime(BDateThird.SelectedDate), Convert.ToDateTime(BDateFour.SelectedDate), txt_AddressFirsh.Text, txt_AddressSecond.Text,
                txt_AddressThird.Text, txt_AddressFour.Text);
                sql.InsertDocuments(BirthCertNumber.Text, "", "", sql.GetId(), "");
                sql.InsertImages(image_bytes, sql.GetId());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { MessageBox.Show(ruen.SuccessfullyInserted); this.Close(); }
            
        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
