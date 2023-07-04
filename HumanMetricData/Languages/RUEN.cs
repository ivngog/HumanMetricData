﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Languages
{
    public class RUEN
    {
        
        string _lblAddRcrdCrsn;
        string _activeRecord;
        string _from;
        string _dateOfCristening;
        string _birthday;
        string _firstname;
        string _lastname;
        string _patronymic;
        string _placeOfReg;
        string _snbc;
        string _parents;
        string _motherinitials;
        string _fatherinitials;
        string _passportm;
        string _passportf;
        string _faddress;
        string _maddress;
        string _recipients;
        string _firstrecipinest;
        string _secondrecipinest;
        string _pasportR1;
        string _pasportR2;
        string _r1Bdate;
        string _r2Bdate;
        string _r1Address;
        string _r2Address;
        string _baptizer;
        string _baptizerinitials;
        string _notes;
        string _addrecordtowedding;
        string _gettingMaried;
        string _gettingMariedMan;
        string _gettingMariedWoman;
        string _gettingMariedBirthDateMan;
        string _gettingMariedBirthDateWoman;
        string _passportgmman;
        string _passportgmwoman;
        string _gmaddressman;
        string _gmaddresswoman;
        string _witnesses;
        string _witnessFirst;
        string _witnessSecond;
        string _w1Bdate;
        string _w2Bdate;
        string _passportW1;
        string _passportW2;
        string _w1Address;
        string _w2Address;
        string _crowning;
        string _crowningInitials;

        public string LabelAddRecordCristening
        {
            get { return _lblAddRcrdCrsn; }
            set 
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _lblAddRcrdCrsn = "ДОБАВИТЬ НОВУЮ ЗАПИСЬ В ЖУРНАЛ \"КРЕЩЕНИЕ\"";
                }
                else if(value == "EN" || value == "en" || value == "En")
                    _lblAddRcrdCrsn = "ADD NEW RECORD TO CRISTENING JOURNAL";

            }
            
        }

        public string ActiveRecord
        {
            get { return _activeRecord; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _activeRecord = "А/З:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _activeRecord = "A/R:";
            }
        }
        public string From
        {
            get { return _from; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _from = "от:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _from = "of date:";
            }
        }
        public string DateOfCristening
        {
            get { return _dateOfCristening; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _dateOfCristening = "Дата крещения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _dateOfCristening = "Date of cristening:";
            }
        }
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _birthday = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _birthday = "Date of birth:";
            }
        }
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _firstname = "Имя:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _firstname = "First Name:";
            }
        }
        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _lastname = "Фамилия:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _lastname = "Last Name:";
            }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _patronymic = "Отчество:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _patronymic = "Patronymic:";
            }
        }
        public string PlaceOfReg
        {
            get { return _placeOfReg; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _placeOfReg = "Место рег:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _placeOfReg = "Place of reg:";
            }
        }
        public string SNBC
        {
            get { return _snbc; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _snbc = "Серия и № свидетельства о рождении:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _snbc = "Series and number of birth sertificate:";
            }
        }
        public string Parents
        {
            get { return _parents; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _parents = "Родители";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _parents = "Parents:";
            }
        }
        public string Motherinitials
        {
            get { return _motherinitials; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _motherinitials = "Инициалы матери:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _motherinitials = "Mother's initials:";
            }
        }
        public string Fatherinitials
        {
            get { return _fatherinitials; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _fatherinitials = "Инициалы отца:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _fatherinitials = "Father's initials:";
            }
        }
        public string PassportM
        {
            get { return _passportm; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportm = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportm = "Passport series and number:";
            }
        }
        public string PassportF
        {
            get { return _passportf; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportf = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportf = "Passport series and number:";
            }
        }
        public string FAddress
        {
            get { return _faddress; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _faddress = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _faddress = "Address:";
            }
        }
        public string MAddress
        {
            get { return _maddress; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _maddress = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _maddress = "Address:";
            }
        }
        public string Recipients
        {
            get { return _recipients; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _recipients = "Восприемники";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _recipients = "Recipients";
            }
        }
        public string FirstRecipinest
        {
            get { return _firstrecipinest; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _firstrecipinest = "ФИО восприемника:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _firstrecipinest = "Recipient's initials:";
            }
        }
        public string SecondRecipinest
        {
            get { return _secondrecipinest; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _secondrecipinest = "ФИО восприемника:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _secondrecipinest = "Recipient's initials:";
            }
        }
        public string PassportR1
        {
            get { return _pasportR1; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _pasportR1 = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _pasportR1 = "Passport series and number:";
            }
        }
        public string PassportR2
        {
            get { return _pasportR2; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _pasportR2 = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _pasportR2 = "Passport series and number:";
            }
        }
        public string R1Bdate
        {
            get { return _r1Bdate; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _r1Bdate = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _r1Bdate = "Date of birth:";
            }
        }
        public string R2Bdate
        {
            get { return _r2Bdate; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _r2Bdate = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _r2Bdate = "Date of birth:";
            }
        }
        public string R1Address
        {
            get { return _r1Address; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _r1Address = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _r1Address = "Address:";
            }
        }
        public string R2Address
        {
            get { return _r2Address; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _r2Address = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _r2Address = "Address:";
            }
        }
        public string Baptizer
        {
            get { return _baptizer; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _baptizer = "Совершивший таинство";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _baptizer = "Baptizer:";
            }
        }
        public string BaptizerInitials
        {
            get { return _baptizerinitials; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _baptizerinitials = "ФИО Священника:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _baptizerinitials = "Baptizer's initials:";
            }
        }
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _notes = "Заметки:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _notes = "Notes:";
            }
        }

        public string AddWeddingRecord
        {
            get { return _addrecordtowedding; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _addrecordtowedding = "Добавление новой записи в журнал \"Венчание\"";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _addrecordtowedding = "Add new record to Wedding journal";
            }
        }
        public string GettingMaried
        {
            get { return _gettingMaried; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gettingMaried = "Венчающиеся";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gettingMaried = "Getting maried";
            }
        }

        public string GettingMariedMan
        {
            get { return _gettingMariedMan; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gettingMariedMan = "Венчающийся:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gettingMariedMan = "Getting maried:";
            }
        }

        public string GettingMariedWoman
        {
            get { return _gettingMariedWoman; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gettingMariedWoman = "Венчающаяся:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gettingMariedWoman = "Getting maried:";
            }
        }

        public string GettingMariedBirthDateMan
        {
            get { return _gettingMariedBirthDateMan; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gettingMariedBirthDateMan = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gettingMariedBirthDateMan = "Date of birth:";
            }
        }

        public string GettingMariedBirthDateWoman
        {
            get { return _gettingMariedBirthDateWoman;  }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gettingMariedBirthDateWoman = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gettingMariedBirthDateWoman = "Date of birth:";
            }
        }

        public string PassportGMMan
        {
            get { return _passportgmman; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportgmman = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportgmman = "Passport series and number:";
            }
        }

        public string PassportGMWoman
        {
            get { return _passportgmwoman; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportgmwoman = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportgmwoman = "Passport series and number:";
            }
        }

        public string GMAddressMan
        {
            get { return _gmaddressman; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gmaddressman = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gmaddressman = "Address:";
            }
        }

        public string GMAddressWoman
        {
            get { return _gmaddresswoman; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _gmaddresswoman = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _gmaddresswoman = "Address:";
            }
        }

        public string Witnesses
        {
            get { return _witnesses; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _witnesses = "Свидетели";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _witnesses = "Witnesses";
            }
        }

        public string WitnessFirst
        {
            get { return _witnessFirst; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _witnessFirst = "Инициалы свидетеля:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _witnessFirst = "Witness's initials:";
            }
        }
        public string WitnessSecond
        {
            get { return _witnessSecond; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _witnessSecond = "Инициалы свидетеля:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _witnessSecond = "Witness's initials:";
            }
        }

        public string W1Bdate
        {
            get { return _w1Bdate; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _w1Bdate = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _w1Bdate = "Date of birth:";
            }
        }

        public string W2Bdate
        {
            get { return _w2Bdate; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _w2Bdate = "Дата рождения:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _w2Bdate = "Date of birth:";
            }
        }

        public string PassportW1
        {
            get { return _passportW1; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportW1 = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportW1 = "Passport series and number:";
            }
        }

        public string PassportW2
        {
            get { return _passportW2; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _passportW2 = "Серия и номер паспорта:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _passportW2 = "Passport series and number:";
            }
        }

        public string W1Address
        {
            get { return _w1Address; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _w1Address = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _w1Address = "Address:";
            }
        }

        public string W2Address
        {
            get { return _w2Address; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _w2Address = "Адрес:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _w2Address = "Address:";
            }
        }

        public string Crowning
        {
            get { return _crowning; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _crowning = "Венчающий";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _crowning = "Crowning";
            }
        }

        public string CrowningInitials
        {
            get { return _crowningInitials; }
            set
            {
                if (value == "RU" || value == "ru" || value == "Ru")
                {
                    _crowningInitials = "ФИО венчающего:";
                }
                else if (value == "EN" || value == "en" || value == "En")
                    _crowningInitials = "Crowning's initials:";
            }
        }

        public void ChengeLanguage(string lang)
        {
            LabelAddRecordCristening = lang;
            ActiveRecord = lang;
            From = lang;
            DateOfCristening = lang;
            Birthday = lang;
            FirstName = lang;
            LastName = lang;
            Patronymic = lang;
            PlaceOfReg = lang;
            SNBC = lang;
            Parents = lang;
            Motherinitials = lang;
            Fatherinitials = lang;
            PassportM = lang;
            PassportF = lang;
            FAddress = lang;
            MAddress = lang;
            Recipients = lang;
            FirstRecipinest = lang;
            SecondRecipinest = lang;
            PassportR1 = lang;
            PassportR2 = lang;
            R1Bdate = lang;
            R2Bdate = lang;
            R1Address = lang;
            R2Address = lang;
            Baptizer = lang;
            BaptizerInitials = lang;
            Notes = lang;

            AddWeddingRecord = lang;
            GettingMaried = lang;
            GettingMariedMan = lang;
            GettingMariedWoman = lang;
            GettingMariedBirthDateMan = lang;
            GettingMariedBirthDateWoman = lang;
            PassportGMMan = lang;
            PassportGMWoman = lang;
            GMAddressMan = lang;
            GMAddressWoman = lang;
            Witnesses = lang;
            WitnessFirst = lang;
            WitnessSecond = lang;
            W1Bdate = lang;
            W2Bdate = lang;
            PassportW1 = lang;
            PassportW2 = lang;
            W1Address = lang;
            W2Address = lang;
            Crowning = lang;
            CrowningInitials = lang;
        }
    }
}