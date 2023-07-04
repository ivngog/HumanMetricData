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

namespace HumanMetricData.Windows.AddNewWindows
{
    /// <summary>
    /// Логика взаимодействия для AddNewWedding.xaml
    /// </summary>
    public partial class AddNewWedding : Window
    {
        public AddNewWedding()
        {
            InitializeComponent();
            ChangeLanguage("ru");
        }


        protected void ChangeLanguage(string lang)
        {
            RUEN ruen = new RUEN();
            ruen.ChengeLanguage(lang);
            AddNewWeddingRecord.Content = ruen.AddWeddingRecord;
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
        }
    }
}
