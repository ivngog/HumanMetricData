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
using HumanMetricData.Images;
using HumanMetricData.Languages;
using HumanMetricData.SQLOperations;
namespace HumanMetricData.Windows.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditWedding.xaml
    /// </summary>
    public partial class EditWedding : Window
    {
        byte[] image_bytes;
        byte[] image_bytes2;
        byte[] img_bytes;
        byte[] img_bytes2;
        readonly RUEN ruen;
        Sql sql;
        public EditWedding(int id1, int id2, string nameOffJournal, string language)
        {
            InitializeComponent();
            ruen = new RUEN();
            DataToTextBox(id1, id2);
            sql.Id = id1;
            sql.Id2 = id2;
            ChangeLanguage("en");
            ChangeLanguage(language);
        }


        void DataToTextBox(int id1, int id2)
        {
            try
            {
                sql = new Sql();
                sql.Select(id1);
                
                txt_ActiveRecord.Text = sql.ActiveRecord;
                date_ARDate.SelectedDate = sql.DateOfRecordNumber;
                date_WeddingDate.SelectedDate = sql.DateOfСommiting;
                txt_GMFNameFirst.Text = sql.FirstName;
                txt_GMNLNameFirst.Text = sql.LastName;
                txt_GMNPatronymicFirst.Text = sql.Patronymic;
                date_GettingMariedFirst.SelectedDate = sql.DateOfBirth;
                txt_passportGettingMariedFirst.Text = sql.PassportNumber;
                txt_GMFirstAddress.Text = sql.Address;
                txt_CertificateOfWedding.Text = sql.WeddingCertificate;
                txt_PlaceOfWedding.Text = sql.PlaceOfRegistration;
                IMG.ImageSource = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                img_bytes = (byte[])sql.IMG;

                txt_R1Name.Text = sql.FirstInitials;
                txt_R1Passport.Text = sql.FirstPassport;
                date_R1BDate.SelectedDate = sql.FirstBirthday;
                txt_R1Address.Text = sql.FirstAddress;

                txt_R2Name.Text = sql.FirstInitials;
                txt_R2Passport.Text = sql.FirstPassport;
                date_R2BDate.SelectedDate = sql.FirstBirthday;
                txt_R2Address.Text = sql.FirstAddress;
                txt_NameOfPerformed.Text = sql.PerformedSacrament;
                txt_WeddingNotes.Text = sql.Notes;
                sql.Select(id2);
                txt_GMFNameSecond.Text = sql.FirstName;
                txt_GMNLNameSecond.Text = sql.LastName;
                txt_GMNPatronymicSecond.Text = sql.Patronymic;
                date_GettingMariedSecond.SelectedDate = sql.DateOfBirth;
                txt_passportGettingMariedSecond.Text = sql.PassportNumber;
                txt_GMSecondAddress.Text = sql.Address;
                IMG2.ImageSource = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                img_bytes2 = (byte[])sql.IMG;


                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        protected void ChangeLanguage(string lang)
        {
            
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
            OpenAndReadImage openAndReadImg = new OpenAndReadImage();
            IMG.ImageSource = openAndReadImg.OpenImg();
            image_bytes = openAndReadImg.readBytes();
        }        
        
        private void btn_OpenImage2_Click(object sender, RoutedEventArgs e)
        {
            OpenAndReadImage openAndReadImg = new OpenAndReadImage();
            IMG2.ImageSource = openAndReadImg.OpenImg();
            image_bytes2 = openAndReadImg.readBytes();
        }

        private void btn_SaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (image_bytes == null && image_bytes2 == null)
            {
                image_bytes = img_bytes;
                image_bytes2 = img_bytes2;

            }
            sql.Update(sql.Id, txt_GMFNameFirst.Text, txt_GMNLNameFirst.Text, txt_GMNPatronymicFirst.Text, txt_GMFirstAddress.Text, (DateTime)date_GettingMariedFirst.SelectedDate, DateTime.MinValue, txt_ActiveRecord.Text, (DateTime)date_ARDate.SelectedDate, (DateTime)date_WeddingDate.SelectedDate, txt_PlaceOfWedding.Text, txt_NameOfPerformed.Text, txt_WeddingNotes.Text, sql.NameOfJournal, txt_R1Name.Text, txt_R2Name.Text, "", "", txt_R1Passport.Text, txt_R2Passport.Text, "", "", (DateTime)date_R1BDate.SelectedDate, (DateTime)date_R2BDate.SelectedDate, DateTime.MinValue, DateTime.MinValue, txt_R1Address.Text, txt_R2Address.Text, "", "", "", "", txt_CertificateOfWedding.Text, txt_passportGettingMariedFirst.Text, image_bytes);
            sql.Update(sql.Id2, txt_GMFNameSecond.Text, txt_GMNLNameSecond.Text, txt_GMNPatronymicSecond.Text, txt_GMSecondAddress.Text, (DateTime)date_GettingMariedSecond.SelectedDate, DateTime.MinValue, txt_ActiveRecord.Text, (DateTime)date_ARDate.SelectedDate, (DateTime)date_WeddingDate.SelectedDate, txt_PlaceOfWedding.Text, txt_NameOfPerformed.Text, txt_WeddingNotes.Text, sql.NameOfJournal, txt_R1Name.Text, txt_R2Name.Text, "", "", txt_R1Passport.Text, txt_R2Passport.Text, "", "", (DateTime)date_R1BDate.SelectedDate, (DateTime)date_R2BDate.SelectedDate, DateTime.MinValue, DateTime.MinValue, txt_R1Address.Text, txt_R2Address.Text, "", "", "", "", txt_CertificateOfWedding.Text, txt_passportGettingMariedSecond.Text, image_bytes2);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("The record has successfuly updated.");
                this.Close();
            }
            
        }

        private void btn_CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
