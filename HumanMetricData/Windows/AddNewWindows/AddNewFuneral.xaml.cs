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
using HumanMetricData.SQLOperations;
using HumanMetricData.Images;

namespace HumanMetricData.Windows.AddNewWindows
{
    /// <summary>
    /// Логика взаимодействия для AddNewFuneral.xaml
    /// </summary>
    public partial class AddNewFuneral : Window
    {
        readonly RUEN ruen;
        byte[] image_bytes;
        public AddNewFuneral(string language)
        {
            InitializeComponent();
            ruen = new RUEN();
            ChangeLanguage("en");
            ChangeLanguage(language);
        }

        public void ChangeLanguage(string lang)
        {
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
            try
            {
                OpenAndReadImage openImg = new OpenAndReadImage();
                IMG.ImageSource = openImg.OpenImg();
                image_bytes = openImg.readBytes();

            }
            catch { }
        }

        private void btn_SaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.InsertHuman(txt_FirstName.Text, txt_LastName.Text, txt_Patronymic.Text, "", (DateTime)date_BirthDay.SelectedDate, (DateTime)date_DateOfDeath.SelectedDate);
                sql.InsertBase(txt_ActiveRecord.Text, Convert.ToDateTime(date_ArDate.SelectedDate), Convert.ToDateTime(date_DateOfFuneral.SelectedDate), sql.GetId(), txt_PlaceOf.Text, txt_PerformedSacrament.Text, txt_Notes.Text, "Funeral", "", "", "", "", "", "", "", "", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, "", "", "", "");
                sql.InsertDocuments("", txt_CertificateOfDeath.Text, "", sql.GetId(), "");
                sql.InsertImages(image_bytes, sql.GetId());
            }
            finally { MessageBox.Show(ruen.SuccessfullyInserted); this.Close(); }
        }

        private void btn_CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
