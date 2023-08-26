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
using System.Drawing;
using System.Windows.Shapes;
using HumanMetricData.Windows.AddNewWindows;
using HumanMetricData.Windows.EditWindows;
using HumanMetricData.SQLOperations;
using HumanMetricData.Languages;
using System.Data;
using HumanMetricData.Model.Base;
using HumanMetricData.Images;
using HumanMetricData.Reports;
using System.Threading.Tasks;

namespace HumanMetricData.Windows
{
    /// <summary>
    /// Логика взаимодействия для CristeningWin.xaml
    /// </summary>
    public partial class CristeningWin : Window
    {
        AddNewCristening addCristening;
        readonly RUEN changeLang;
        readonly Sql sql;
        string language;
        public CristeningWin(string nameOfJournal, string language)
        {
            InitializeComponent();
            
            changeLang = new RUEN();
            sql = new Sql();
            sql.NameOfJournal = nameOfJournal;
            this.language = language;
            ChangeLanguageCristening("en");
            ChangeLanguageCristening(this.language);
        }

        public void ChangeLanguageCristening(string lang)
        {
            changeLang.ChengeLanguage(lang);
            NameOfJournal.Text = changeLang.CristeningJournal;
            txtCertificateNumber.Content = changeLang.MainCertificateOfBirth;
            lbl_PlaceOfReg.Content = changeLang.PlaceOfCristening;
            lbl_Date.Content = changeLang.ByDate;
            lbl_Baptized.Content = changeLang.Baptized;
            lbl_AR.Content = changeLang.ActiveRecordNumber;
            lbl_FirstName.Content = changeLang.FirstName;
            lbl_LastName.Content = changeLang.LastName;
            lbl_Patronymic.Content = changeLang.Patronymic;
            lbl_dateFrom.Content = changeLang.DateFrom;
            lbl_toDate.Content = changeLang.ToDate;

        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            addCristening = new AddNewCristening(language);
            addCristening.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (CristeningTable.SelectedItem != null)
                {

                    DataRowView row = CristeningTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        EditCristening editCristening = new EditCristening((int)row.Row.ItemArray[0], sql.NameOfJournal, language);
                        //sql.Select((int)row.Row.ItemArray[0]);
                        editCristening.Show();
                    }

                }
                else
                {
                    //MessageBox.Show("Select the row!!!");
                }
            }

            catch { }
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (arDate.SelectedDate == null || date_DateFrom.SelectedDate == null || date_ToDate == null)
                {
                    arDate.SelectedDate = DateTime.Now;
                    date_DateFrom.SelectedDate = DateTime.Now;
                    date_ToDate.SelectedDate = DateTime.Now;
                }

                CristeningTable.ItemsSource = sql.Select(sql.NameOfJournal, firstName.Text.Trim(), lastName.Text.Trim(), patronymic.Text.Trim(), placeOfReg.Text.Trim(), documentNumber.Text.Trim(), activeRecord.Text.Trim(), (DateTime)arDate.SelectedDate, (DateTime)date_DateFrom.SelectedDate, (DateTime)date_ToDate.SelectedDate); ;
               
            }
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }

        }

        private void btnSendToWord_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (CristeningTable.SelectedItem != null)
                {

                    DataRowView row = CristeningTable.SelectedItem as DataRowView;
                    if (row != null)
                    {
                        SendReport sendReport = new SendReport();
                        sendReport.SendToWord(NameOfJournal.Text, row.Row.ItemArray[1], row.Row.ItemArray[2], row.Row.ItemArray[3], row.Row.ItemArray[4], Convert.ToDateTime(row.Row.ItemArray[5]), row.Row.ItemArray[6], Convert.ToDateTime(row.Row.ItemArray[7]), row.Row.ItemArray[8], Convert.ToDateTime(row.Row.ItemArray[32]), row.Row.ItemArray[9],  row.Row.ItemArray[10], row.Row.ItemArray[11], Convert.ToDateTime(row.Row.ItemArray[12]), row.Row.ItemArray[13], row.Row.ItemArray[14], row.Row.ItemArray[15], Convert.ToDateTime(row.Row.ItemArray[16]), row.Row.ItemArray[17], row.Row.ItemArray[18], row.Row.ItemArray[19], Convert.ToDateTime(row.Row.ItemArray[20]), row.Row.ItemArray[21], row.Row.ItemArray[22], row.Row.ItemArray[23], Convert.ToDateTime(row.Row.ItemArray[24]), row.Row.ItemArray[25], row.Row.ItemArray[26], row.Row.ItemArray[27], row.Row.ItemArray[28], row.Row.ItemArray[29], row.Row.ItemArray[30], (byte[])row.Row.ItemArray[31]);
                        
                    }

                }
                else
                {

                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        

        private void rowSelected_Selected(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {

                if (CristeningTable.SelectedItem != null)
                {

                    DataRowView row = CristeningTable.SelectedItem as DataRowView;
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

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (CristeningTable.SelectedItem != null)
                {

                    DataRowView row = CristeningTable.SelectedItem as DataRowView;
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
