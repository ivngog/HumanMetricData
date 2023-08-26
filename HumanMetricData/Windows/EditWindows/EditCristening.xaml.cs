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
using HumanMetricData.Languages;
using HumanMetricData.SQLOperations;
using HumanMetricData.Images;
using System.IO;

namespace HumanMetricData.Windows.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditCristening.xaml
    /// </summary>
    public partial class EditCristening : Window
    {
        byte[] image_bytes;
        byte[] img_bytes;
        readonly RUEN ruen;
        readonly Sql sql;
        
        public EditCristening(int id, string journalName, string language)
        {
            InitializeComponent();
            ruen = new RUEN();
            sql = new Sql();
            sql.Id = id;
            sql.NameOfJournal = journalName;
            ChangeLanguage("en");
            ChangeLanguage(language);
            DataToTextBox(sql.Id);
        }

        void DataToTextBox(int id)
        {
            try
            {
                sql.Select(id);
                txt_ActiveRecord.Text = sql.ActiveRecord;
                date_RecordNumber.SelectedDate = sql.DateOfRecordNumber;
                date_Committing.SelectedDate = sql.DateOfСommiting;
                date_Birth.SelectedDate = sql.DateOfBirth;
                txt_FirstName.Text = sql.FirstName;
                txt_LastName.Text = sql.LastName;
                txt_Patronymic.Text = sql.Patronymic;
                txt_PlaceOfReg.Text = sql.PlaceOfRegistration;
                Address.Text = sql.Address;
                txt_BirthCertificate.Text = sql.BirthCertificate;
                txt_FIinitials.Text = sql.FirstInitials;
                txt_FatherPassport.Text = sql.FirstPassport;
                txt_AddressFather.Text = sql.FirstAddress;
                date_Father.SelectedDate = sql.FirstBirthday;
                txt_MIinitials.Text = sql.SecondInitials;
                txt_MotherPassport.Text = sql.SecondPassport;
                txt_MotherAddress.Text = sql.SecondAddress;
                date_Mother.SelectedDate = sql.SecondBirthday;
                txt_R1initials.Text = sql.ThirdInitials;
                txt_R1Address.Text = sql.ThirdAddress;
                txt_R1Passport.Text = sql.ThirdPassport;
                date_R1Birth.SelectedDate = sql.ThirdBirthday;
                txt_R2Iinitials.Text = sql.FourInitials;
                txt_R2Address.Text = sql.FourAddress;
                txt_R2Passport.Text = sql.FourPassport;
                date_R2Birth.SelectedDate = sql.FourBirthday;
                txt_performedSacrament.Text = sql.PerformedSacrament;
                txt_Notes.Text = sql.Notes;
                IMG.ImageSource = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                img_bytes = (byte[])sql.IMG;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }
        public void ChangeLanguage(string lang)
        {
            
            ruen.ChengeLanguage(lang);
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
            EditCristeningRecord.Content = ruen.EditCristening;
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            OpenAndReadImage openAndReadImg = new OpenAndReadImage();
            IMG.ImageSource = openAndReadImg.OpenImg();
            image_bytes = openAndReadImg.readBytes();
            
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(image_bytes == null)
            {
                image_bytes = img_bytes;
               
            }
             sql.Update(sql.Id, txt_FirstName.Text, txt_LastName.Text, txt_Patronymic.Text, Address.Text, (DateTime)date_Birth.SelectedDate, DateTime.MinValue, txt_ActiveRecord.Text, (DateTime)date_RecordNumber.SelectedDate, (DateTime)date_Committing.SelectedDate, txt_PlaceOfReg.Text, txt_performedSacrament.Text, txt_Notes.Text, sql.NameOfJournal, txt_FIinitials.Text, txt_MIinitials.Text, txt_R1initials.Text, txt_R2Iinitials.Text, txt_FatherPassport.Text, txt_MotherPassport.Text, txt_R1Passport.Text, txt_R2Passport.Text, (DateTime)date_Father.SelectedDate, (DateTime)date_Mother.SelectedDate, (DateTime)date_R1Birth.SelectedDate, (DateTime)date_R2Birth.SelectedDate, txt_AddressFather.Text, txt_MotherAddress.Text, txt_R1Address.Text, txt_R2Address.Text, txt_BirthCertificate.Text, "", "", "", image_bytes);
     

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
