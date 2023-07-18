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

namespace HumanMetricData.Windows
{
    /// <summary>
    /// Логика взаимодействия для CristeningWin.xaml
    /// </summary>
    public partial class CristeningWin : Window
    {
        
        RUEN changeLang;
        Sql sql;
        public CristeningWin(string nameOfJournal)
        {
            InitializeComponent();
            sql = new Sql();
            changeLang = new RUEN();
            sql.NameOfJournal = nameOfJournal;
            SelectJournal("En");
        }

        public void ChangeLanguageCristening(string lang)
        {
            changeLang.ChengeLanguage(lang);
            NameOfJournal.Text = changeLang.CristeningJournal;
        }
        public void ChangeLanguageFuneral(string lang)
        {
            changeLang.ChengeLanguage(lang);
            NameOfJournal.Text = changeLang.FuneralJournal;
        }
        public void ChangeLanguageWedding(string lang)
        {
            changeLang.ChengeLanguage(lang);
            NameOfJournal.Text = changeLang.WeddingJournal;
        }


        void SelectJournal(string lang)
        {
            switch (sql.NameOfJournal)
            {
                case "Cristening": ChangeLanguageCristening(lang); 
                    break;
                case "Funeral":
                    ChangeLanguageFuneral(lang);
                    break;
                case "Wedding":
                    ChangeLanguageWedding(lang);
                    break;
            }
            
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            AddNewCristening addCristening = new AddNewCristening();
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
                        EditCristening editCristening = new EditCristening((int)row.Row.ItemArray[0], sql.NameOfJournal);
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
           
                if (arDate.SelectedDate == null)
                {
                    arDate.SelectedDate = DateTime.Now;
                }
                CristeningTable.ItemsSource = sql.Select(sql.NameOfJournal, firstName.Text.Trim(), lastName.Text.Trim(), patronymic.Text.Trim(), placeOfReg.Text.Trim(), documentNumber.Text.Trim(), activeRecord.Text.Trim(), (DateTime)arDate.SelectedDate);
                
               
                
            }
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }

        }

        private void btnSendToWord_Click(object sender, RoutedEventArgs e)
        {
            
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
    }
}
