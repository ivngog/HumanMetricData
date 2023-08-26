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
using HumanMetricData.Images;
using HumanMetricData.SQLOperations;

namespace HumanMetricData.Windows.AddNewWindows
{
    /// <summary>
    /// Логика взаимодействия для AddNewWedding.xaml
    /// </summary>
    public partial class AddNewWedding : Window
    {
        readonly RUEN ruen;
        Sql sql;
        OpenAndReadImage openImg;
        byte[] image_bytes;
        byte[] image_bytes2;
        public AddNewWedding(string language)
        {
            InitializeComponent();
            ruen = new RUEN();
            ChangeLanguage("en");
            ChangeLanguage(language);
            
        }

        


        protected void ChangeLanguage(string lang)
        {
            
            ruen.ChengeLanguage(lang);
            AddNewWeddingRecord.Content = ruen.AddWeddingRecord;
            ActiveRecord.Content = ruen.ActiveRecord;
            from.Content = ruen.From;
            dateOfWedding.Content = ruen.DateOfWedding;
            certificateOfWedding.Content = ruen.CertificateOfWedding;
            placeOfWeding.Content = ruen.PlaceOfWedding;
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
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                openImg = new OpenAndReadImage();
                IMG.ImageSource = openImg.OpenImg();
                image_bytes = openImg.readBytes();
            }
            catch { }
        }

        
        private void btn_OpenImage2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                openImg = new OpenAndReadImage();
                IMG2.ImageSource = openImg.OpenImg();
                image_bytes2 = openImg.readBytes();
            }
            catch { }
        }

        private void btn_SaveClick(object sender, RoutedEventArgs e)
        {
            try
            {


                sql = new Sql();
                sql.InsertHuman(txt_GMFNameFirst.Text, txt_GMNLNameFirst.Text, txt_GMNPatronymicFirst.Text, txt_GMFirstAddress.Text, (DateTime)date_GettongMariedFirst.SelectedDate, DateTime.MinValue);
                sql.InsertBase(txt_ActiveRecord.Text, (DateTime)date_ARDate.SelectedDate, (DateTime)date_WeddingDate.SelectedDate, sql.GetId(), txt_PlaceOfWedding.Text, txt_NameOfPerformed.Text, txt_WeddingNotes.Text, "Wedding", txt_R1Name.Text, txt_R2Name.Text, null, null, txt_R1Passport.Text, txt_R2Passport.Text, null, null, (DateTime)date_R1BDate.SelectedDate, (DateTime)date_R2BDate.SelectedDate, DateTime.MinValue, DateTime.MinValue, txt_R1Address.Text, txt_R2Address.Text, null, null);
                sql.InsertDocuments(null, null, txt_CertificateOfWedding.Text, sql.GetId(), txt_passportGettingMariedFirst.Text);
                sql.InsertImages(image_bytes, sql.GetId());

                sql.InsertHuman(txt_GMFNameSecond.Text, txt_GMNLNameSecond.Text, txt_GMNPatronymicSecond.Text, txt_GMSecondAddress.Text, (DateTime)date_GettongMariedSecond.SelectedDate, DateTime.MinValue);
                sql.InsertBase(txt_ActiveRecord.Text, (DateTime)date_ARDate.SelectedDate, (DateTime)date_WeddingDate.SelectedDate, sql.GetId(), txt_PlaceOfWedding.Text, txt_NameOfPerformed.Text, txt_WeddingNotes.Text, "Wedding", txt_R1Name.Text, txt_R2Name.Text, null, null, txt_R1Passport.Text, txt_R2Passport.Text, null, null, (DateTime)date_R1BDate.SelectedDate, (DateTime)date_R2BDate.SelectedDate, DateTime.MinValue, DateTime.MinValue, txt_R1Address.Text, txt_R2Address.Text, null, null);
                sql.InsertDocuments(null, null, txt_CertificateOfWedding.Text, sql.GetId(), txt_passportGettingMariedSecond.Text);
                sql.InsertImages(image_bytes2, sql.GetId());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                MessageBox.Show("The information successfly added.");
                this.Close();
            }
        }

        private void btn_CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
