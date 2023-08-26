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
    /// Логика взаимодействия для WeddingWin.xaml
    /// </summary>
    public partial class WeddingWin : Window
    {
        readonly RUEN changeLang;
        readonly Sql sql;
        readonly SendReport sendReport;
        AddNewWedding addWedding;
        EditWedding editWedding;
        string language;
        public WeddingWin(string nameOfJournal, string language)
        {
            InitializeComponent();
            changeLang = new RUEN();
            sql = new Sql();
            sendReport = new SendReport();
            sql.NameOfJournal = nameOfJournal;
            this.language = language;
            ChangeLanguage("En");
            ChangeLanguage(this.language);
        }


       
        
        public void ChangeLanguage(string lang)
        {
            changeLang.ChengeLanguage(lang);
            NameOfJournal.Text = changeLang.WeddingJournal;
            lbl_AR.Content = changeLang.ActiveRecordNumber;
            lbl_Certificate.Content = changeLang.MainCertificateOfWedding;
            lbl_PlaceOfregistration.Content = changeLang.PlaceOfWedding;
            lbl_Date.Content = changeLang.ByDate;
            lbl_GettingMarried.Content = changeLang.GettingMaried;
            lbl_FirstName.Content = changeLang.FirstName;
            lbl_LastName.Content = changeLang.LastName;
            lbl_Patronymic.Content = changeLang.Patronymic;
            lbl_dateFrom.Content = changeLang.DateFrom;
            lbl_toDate.Content = changeLang.ToDate;
        }


        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addWedding = new AddNewWedding(language);
            addWedding.Show();
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

                WeddingTable.ItemsSource = sql.Select(sql.NameOfJournal, txt_firstName.Text.Trim(), txt_lastName.Text.Trim(), txt_patronymic.Text.Trim(), txt_placeOfReg.Text.Trim(), txt_documentNumber.Text.Trim(), activeRecord.Text.Trim(), (DateTime)arDate.SelectedDate, (DateTime)date_DateFrom.SelectedDate, (DateTime)date_ToDate.SelectedDate);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

       

        private void row_Selected(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {

                if (WeddingTable.SelectedItem != null)
                {

                    DataRowView row = WeddingTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        sql.Select((int)row.Row.ItemArray[0]);
                        Photo1.Source = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));

                        sql.Select((int)row.Row.ItemArray[1]);
                        Photo2.Source = ByteImage.Convert(ByteImage.GetImageFromByteArray((byte[])sql.IMG));
                    }

                }
                else
                {
                    //MessageBox.Show("Select the row!!!");
                }
            }

            catch { }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (WeddingTable.SelectedItem != null)
                {

                    DataRowView row = WeddingTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        editWedding = new EditWedding((int)row.Row.ItemArray[0], (int)row.Row.ItemArray[1], sql.NameOfJournal, language);
                        editWedding.Show();
                    }

                }
                else
                {
                    
                }
            }

            catch { }



        }

        private void btn_DeleteClick(object sender, RoutedEventArgs e)
        {
            try
            {

                if (WeddingTable.SelectedItem != null)
                {

                    DataRowView row = WeddingTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        sql.Delete((int)row.Row.ItemArray[0]);
                        sql.Delete((int)row.Row.ItemArray[1]);
                    }

                }
                else
                {

                }
            }

            catch { }
            finally { MessageBox.Show("The record was deleted!"); }
        }

        

        private void btn_SendToWord_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (WeddingTable.SelectedItem != null)
                {

                    DataRowView row = WeddingTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        sendReport.SendToWord(NameOfJournal.Text, row.Row.ItemArray[2], row.Row.ItemArray[3], row.Row.ItemArray[4], (DateTime)row.Row.ItemArray[5], row.Row.ItemArray[6], row.Row.ItemArray[7], (byte[])row.Row.ItemArray[8], row.Row.ItemArray[9], row.Row.ItemArray[10], row.Row.ItemArray[11], (DateTime)row.Row.ItemArray[12], row.Row.ItemArray[13], row.Row.ItemArray[14], (byte[])row.Row.ItemArray[15], row.Row.ItemArray[16], (DateTime)row.Row.ItemArray[17], (DateTime)row.Row.ItemArray[18], row.Row.ItemArray[19], row.Row.ItemArray[20], row.Row.ItemArray[21], (DateTime)row.Row.ItemArray[22], row.Row.ItemArray[23], row.Row.ItemArray[24], row.Row.ItemArray[25], (DateTime)row.Row.ItemArray[26], row.Row.ItemArray[27], row.Row.ItemArray[28], row.Row.ItemArray[29], row.Row.ItemArray[30]);

                    }

                }
                else
                {

                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
