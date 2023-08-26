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
    /// Логика взаимодействия для EditFuneral.xaml
    /// </summary>
    public partial class EditFuneral : Window
    {
        readonly RUEN ruen;
        byte[] image_bytes;
        byte[] img_bytes;
        readonly Sql sql;
        public EditFuneral(int id, string journalName, string language)
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
                date_DateOfDeath.SelectedDate = sql.DateOfDeath;
                txt_FirstName.Text = sql.FirstName;
                txt_LastName.Text = sql.LastName;
                txt_Patronymic.Text = sql.Patronymic;
                txt_PlaceOfReg.Text = sql.PlaceOfRegistration;
                txt_DeathCertificate.Text = sql.DeathCertificate;
                txt_performedSacrament.Text = sql.PerformedSacrament;
                txt_Notes.Text = sql.Notes;
                IMG.ImageSource = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                img_bytes = (byte[])sql.IMG;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void ChangeLanguage(string lang)
        {
            
            ruen.ChengeLanguage(lang);
            EditFuneralRecord.Content = ruen.EditFuneral;
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

                OpenAndReadImage openAndReadImg = new OpenAndReadImage();
                IMG.ImageSource = openAndReadImg.OpenImg();
                image_bytes = openAndReadImg.readBytes();
            }

        private void btn_SaveClick(object sender, RoutedEventArgs e)
        {
            try
            {

                if (image_bytes == null)
                {
                    image_bytes = img_bytes;

                }
                sql.Update(sql.Id, txt_FirstName.Text, txt_LastName.Text, txt_Patronymic.Text, "", (DateTime)date_Birth.SelectedDate, (DateTime)date_DateOfDeath.SelectedDate, txt_ActiveRecord.Text, (DateTime)date_RecordNumber.SelectedDate, (DateTime)date_Committing.SelectedDate, txt_PlaceOfReg.Text, txt_performedSacrament.Text, txt_Notes.Text, sql.NameOfJournal, "", "", "", "", "", "", "", "", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, "", "", "", "", "", txt_DeathCertificate.Text, "", "", image_bytes);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
