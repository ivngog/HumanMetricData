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

namespace HumanMetricData.Windows.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditCristening.xaml
    /// </summary>
    public partial class EditCristening : Window
    {
        
        
        public EditCristening()
        {
            InitializeComponent();
            ChangeLanguage("ru");
        }


        public void ChangeLanguage(string lang)
        {
            RUEN ruen = new RUEN();
            ruen.ChengeLanguage(lang);
            AddNewRecord.Content = ruen.LabelAddRecordCristening;
            ActiveRecord.Content = ruen.ActiveRecord;
            from.Content = ruen.From;
            dateOfCristening.Content = ruen.DateOfCristening;
            Birtday.Content = ruen.Birthday;
            FirstName.Content = ruen.FirstName;
            LastName.Content = ruen.LastName;
            Patronymic.Content = ruen.Patronymic;
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
        }
    }
}
