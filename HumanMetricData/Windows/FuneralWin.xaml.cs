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
using HumanMetricData.Languages;
using HumanMetricData.SQLOperations;
using System.Data;
using HumanMetricData.Images;
using HumanMetricData.Reports;

namespace HumanMetricData.Windows
{
    /// <summary>
    /// Логика взаимодействия для FuneralWin.xaml
    /// </summary>
    public partial class FuneralWin : Window
    {
        EditFuneral editFuneral;
        AddNewFuneral addFuneral;
        readonly RUEN changeLang;
        readonly Sql sql;
        string language;
        public FuneralWin(string nameOfJournal, string language)
        {
            InitializeComponent();
            changeLang = new RUEN();
            sql = new Sql();
            sql.NameOfJournal = nameOfJournal;
            ChangeLanguageFuneral("En");
            this.language = language;
            ChangeLanguageFuneral(this.language);
        }

        public void ChangeLanguageFuneral(string lang)
        {
            changeLang.ChengeLanguage(lang);
            txt_NameOfJournal.Text = changeLang.FuneralJournal;
            lbl_Certificate.Content = changeLang.MainCertificateOfDeath;
            lbl_Date.Content = changeLang.ByDate;
            lbl_placeOfReg.Content = changeLang.PlaceOfFuneral;
            lbl_AR.Content = changeLang.ActiveRecordNumber;
            lbl_baptized.Content = changeLang.Baptized;
            lbl_firstName.Content = changeLang.FirstName;
            lbl_lastName.Content = changeLang.LastName;
            lbl_patronymic.Content = changeLang.Patronymic;
            lbl_dateFrom.Content = changeLang.DateFrom;
            lbl_toDate.Content = changeLang.ToDate;
        }
       

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addFuneral = new AddNewFuneral(this.language) ;
            addFuneral.Show();
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                if (tbl_FuneralTable.SelectedItem != null)
                {

                    DataRowView row = tbl_FuneralTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        editFuneral = new EditFuneral((int)row.Row.ItemArray[0], sql.NameOfJournal, this.language);
                       
                        editFuneral.Show();
                    }

                }
                else
                {
                    //MessageBox.Show("Select the row!!!");
                }
            }

            catch { }

             
        }

        private void btn_SearchClick(object sender, RoutedEventArgs e)
        {
            try
            {

                if (arDate.SelectedDate == null || date_DateFrom.SelectedDate == null || date_ToDate == null)
                {
                    arDate.SelectedDate = DateTime.Now;
                    date_DateFrom.SelectedDate = DateTime.Now;
                    date_ToDate.SelectedDate = DateTime.Now;
                }

                tbl_FuneralTable.ItemsSource = sql.Select(sql.NameOfJournal, txt_FirstName.Text.Trim(), txt_LastName.Text.Trim(), txt_Patronymic.Text.Trim(), txt_PlaceOf.Text.Trim(), txt_DeathCertificate.Text.Trim(), activeRecord.Text.Trim(), (DateTime)arDate.SelectedDate, (DateTime)date_DateFrom.SelectedDate, (DateTime)date_ToDate.SelectedDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbl_RowSelected(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {

                if (tbl_FuneralTable.SelectedItem != null)
                {

                    DataRowView row = tbl_FuneralTable.SelectedItem as DataRowView;
                    if (row != null)
                    {

                        sql.Select((int)row.Row.ItemArray[0]);
                        Photo.Source = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                    }

                }
                else
                {
                    //MessageBox.Show("Select the row!!!");
                }
            }

            catch { }
        }

       

        private void btnSendToWord_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (tbl_FuneralTable.SelectedItem != null)
                {

                    DataRowView row = tbl_FuneralTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        SendReport sendReport = new SendReport();
                        sendReport.SendToWord(txt_NameOfJournal.Text, row.Row.ItemArray[1], row.Row.ItemArray[2], row.Row.ItemArray[3], Convert.ToDateTime(row.Row.ItemArray[4]), Convert.ToDateTime(row.Row.ItemArray[5]), row.Row.ItemArray[6], Convert.ToDateTime(row.Row.ItemArray[7]), Convert.ToDateTime(row.Row.ItemArray[8]), row.Row.ItemArray[9], row.Row.ItemArray[10], row.Row.ItemArray[11], row.Row.ItemArray[12], (byte[])row.Row.ItemArray[13]);

                    }
                }
                else
                {

                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (tbl_FuneralTable.SelectedItem != null)
                {

                    DataRowView row = tbl_FuneralTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        sql.Delete((int)row.Row.ItemArray[0]);
                    }

                }
                else
                {

                }
            }

            catch { }
            finally
            {
                MessageBox.Show("The record was successfully deleted from database!");
            }
        }
    }
}
