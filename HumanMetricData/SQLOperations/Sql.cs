using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using HumanMetricData.Model.Base;
using HumanMetricData.Languages;

namespace HumanMetricData.SQLOperations
{
    public class Sql : Human, IDisposable, IDataSIUD
    {
        public SqlDataAdapter adapter;
        private readonly string _connectionString;
        public SqlConnection _sqlConnection = null;
        bool _disposed = false;
        readonly RUEN ruen;


        public Sql() : this(@"" + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.ConnectionString + "")
        {
            ruen = new RUEN();
        }

        public Sql(string connectionString) => _connectionString = connectionString;



        public void OpenConnection()
        {
            _sqlConnection = new SqlConnection
            {
                ConnectionString = _connectionString
            };
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _sqlConnection.Dispose();
            }
            _disposed = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void InsertHuman(string firstname, string lastname, string patronymic, string? address, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Patronymic = patronymic;
            Address = address;
            DateOfBirth = birthdate;
            //MessageBox.Show(firstname + " " + lastname + " "+ patronymic + " " + address + " " + birthdate);
            string query = @"insert into Human (FirstName, LastName, Patronymic, Adres, BirthDate) values(N'" + FirstName + "',N'" + LastName + "',N'" + Patronymic + "', N'" + Address + "',N'" + DateOfBirth + "')";
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    CloseConnection();
                    //MessageBox.Show("Congratulation!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertDocuments(string? certificateOfBirth, string? certificateOfDeath, string? certificateOfWedding, int humanid, string? passportNumber)
        {

            BirthCertificate = certificateOfBirth;
            DeathCertificate = certificateOfDeath;
            WeddingCertificate = certificateOfWedding;
            HumanId = humanid;
            PassportNumber = passportNumber;

            string query = @"insert into Documents (CertificateOfBirth, CertificateOfDeath, CertificateOfWedding, HumanId, PassportId) values(N'" + BirthCertificate + "', N'" + DeathCertificate + "', N'" + WeddingCertificate + "', N" + HumanId + ",N'" + PassportNumber + "')";
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    CloseConnection();
                    //MessageBox.Show("Congratulation!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertImages(byte[] image_bytes, int humanId)
        {

            string query = @"insert into Images(Img, HumanId) values(@ImageData, " + humanId + ")";
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {

                    command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);
                    command.Parameters["@ImageData"].Value = image_bytes;// скалярной переменной ImageData присвоем массив байтов

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    CloseConnection();
                    //MessageBox.Show("Congratulation!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertBase(string activeRecord, DateTime arDate, DateTime dateOf, int humanId, string placeOf, string performedSacrament, string notes, string nameOfJournal, string initialFirst, string initialSecond, string initialThird, string initialFour, string passportFirst, string passportSecond, string passportThird, string passportFour, DateTime birthFirst, DateTime birthSecond, DateTime birthThird, DateTime birthFour, string addressFirst, string addressSecond, string addressThird, string addressFour)
        {
            ActiveRecord = activeRecord;
            DateOfRecordNumber = arDate;
            DateOfСommiting = dateOf;
            HumanId = HumanId;
            PlaceOfRegistration = placeOf;
            PerformedSacrament = performedSacrament;
            Notes = notes;
            NameOfJournal = nameOfJournal;
            FirstInitials = initialFirst;
            SecondInitials = initialSecond;
            ThirdInitials = initialThird;
            FourInitials = initialFour;
            FirstPassport = passportFirst;
            SecondPassport = passportSecond;
            ThirdPassport = passportSecond;
            FourPassport = passportSecond;
            FirstBirthday = birthFirst;
            SecondBirthday = birthSecond;
            ThirdBirthday = birthSecond;
            FourBirthday = birthFour;
            FirstAddress = addressFirst;
            SecondAddress = addressSecond;
            ThirdAddress = addressThird;
            FourAddress = addressFour;


            string query = @"insert into Base (ActiveRecord, ARDate, DateOf, HumanId, 
PlaceOf, PerformedSacrament, Notes, NameOfJournal, initialsFirst, initialsSecond, 
initialsThird, initialsFour, PassportFirst, PassportSecond, PassportThird, PassportFour, 
BirthFirst, BirthSecond, BirthThird, BirthFour, AddressFirst, AddressSecond, AddressThird, 
AddressFour) 
values(N'" + ActiveRecord + "','" + DateOfRecordNumber + "','" + DateOfСommiting + "', " + HumanId + ", N'" + PlaceOfRegistration + "',N'" + PerformedSacrament + "',N'" + Notes + "',N'" + NameOfJournal + "',N'" + FirstInitials + "',N'" + SecondInitials + "',N'" + ThirdInitials + "',N'" + FourInitials + "',N'" + FirstPassport + "',N'" + SecondPassport + "',N'" + ThirdPassport + "',N'" + FourPassport + "','" + FirstBirthday + "', '" + SecondBirthday + "', '" + ThirdBirthday + "', '" + FourBirthday + "',N'" + FirstAddress + "',N'" + SecondAddress + "',N'" + ThirdAddress + "',N'" + FourAddress + "')";

            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    CloseConnection();
                    //MessageBox.Show("Congratulation!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public DataView Select(string nameOfJournal, string firstName, string lastName, string patronymic, string placeOfReg, string numberOfDoc, string activeRec, DateTime someDate)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter;
            try
            {
                ruen.ChengeLanguage("En");
                string query = @"select Human.Id, Human.FirstName as '"+ruen.FirstName+"', Human.LastName as '" + ruen.LastName+"', Human.Patronymic as '"+ruen.Patronymic+"', Human.Adres as '"+ruen.Address+"', Human.BirthDate as '"+ruen.Birthday+
                    "',  Base.ActiveRecord as '" + ruen.ActiveRecord + "', Base.DateOf as '" + ruen.From + "', Base.PlaceOf as '" + ruen.PlaceOfReg + "', Base.PerformedSacrament as '" + ruen.Baptizer + "', Base.Notes as '" + ruen.Notes + "', Base.InitialsFirst as '" + ruen.Initials + "', Base.BirthFirst as '" + ruen.Birthday + "', Base.PassportFirst as '" + ruen.Passport + "', Base.AddressFirst as '" + ruen.Address +
                    "',  Base.InitialsSecond as '" + ruen.Initials + "', Base.BirthSecond as '" + ruen.Birthday + "', Base.PassportSecond as '" + ruen.Passport + "', Base.AddressFirst as '" + ruen.Address+
                    "',  Base.InitialsThird as '" + ruen.Initials + "', Base.BirthThird as '" + ruen.Birthday + "', Base.PassportThird as '" + ruen.Passport + "', Base.AddressThird as '" + ruen.Address +
                    "',  Base.InitialsFour as '" + ruen.Initials + "', Base.BirthFour as '" + ruen.Birthday + "', Base.PassportFour as '" + ruen.Passport + "', Base.AddressFour as '" + ruen.Address +
                    "', Documents.CertificateOfBirth as '"+ruen.CertificateOfBirth+ "', Documents.CertificateOfDeath as '" + ruen.CertificateOfDeath + "', Documents.CertificateOfWedding as '" + ruen.CertificateOfWedding + "', Documents.PassportId as '"+ruen.Passport+ "',Images.IMG from Human,Base,Documents,Images where Documents.HumanId=Human.Id and Base.HumanId=Human.Id and Images.HumanId=Human.Id and Base.NameOfJournal in (select distinct NameOfJournal from base where NameOfJournal = ltrim('" + nameOfJournal +
                "')) and (Human.FirstName = ltrim('" + firstName + "') or Human.LastName = ltrim('"+lastName+"') or Human.Patronymic = ltrim('"+patronymic+"') or Human.BirthDate = ltrim('"+ Convert.ToDateTime(someDate.ToString("M/dd/yyyy")) +
                "') or Base.ArDate = ltrim('" + Convert.ToDateTime(someDate.ToString("M/dd/yyyy")) +
                "') or Base.DateOf = ltrim('" + Convert.ToDateTime(someDate.ToString("M/dd/yyyy")) +
                "') or Base.PlaceOf = ltrim('" +placeOfReg+"') or (Documents.CertificateOfBirth = ltrim('"+numberOfDoc+
                "') and Documents.CertificateOfBirth is not null) or (Documents.CertificateOfDeath = ltrim('" + numberOfDoc +
                "') and Documents.CertificateOfDeath is not null) or (Documents.CertificateOfWedding = ltrim('" + numberOfDoc +
                "') and Documents.CertificateOfWedding is not null) or (Documents.PassportId = ltrim('" + numberOfDoc + "') and Documents.PassportId is not null) or (Base.ActiveRecord = ltrim('" + activeRec + "') and Base.ActiveRecord is not null)) Order by Human.Id";
             
                OpenConnection();
                using SqlCommand command = new SqlCommand(query, _sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                CloseConnection();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return dt.DefaultView;
        }

        public void Select(int id)
        {
            Id = id;
            string query = @"select distinct Human.*, Base.*, Documents.*, Images.IMG from Human,Base,Documents,Images where Human.Id ="+Id+" and Base.HumanId = "+Id+" and Documents.HumanId = "+Id+" and Images.HumanId = "+Id+"";
            try
            {
                OpenConnection();
                using SqlCommand command = new SqlCommand(query, _sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    FirstName = dataReader["FirstName"].ToString();
                    LastName = dataReader["LastName"].ToString();
                    Patronymic = dataReader["Patronymic"].ToString();
                    Address = dataReader["Adres"].ToString();
                    DateOfBirth = Convert.ToDateTime(dataReader["BirthDate"]);
                    ActiveRecord = dataReader["ActiveRecord"].ToString();
                    DateOfRecordNumber = Convert.ToDateTime(dataReader["ARDate"]);
                    DateOfСommiting = Convert.ToDateTime(dataReader["DateOf"]);
                    PlaceOfRegistration = dataReader["PlaceOf"].ToString();
                    PerformedSacrament = dataReader["PerformedSacrament"].ToString();
                    Notes = dataReader["Notes"].ToString();
                    NameOfJournal = dataReader["NameOfJournal"].ToString();
                    FirstInitials = dataReader["InitialsFirst"].ToString();
                    SecondInitials = dataReader["InitialsSecond"].ToString();
                    ThirdInitials = dataReader["InitialsThird"].ToString();
                    FourInitials = dataReader["InitialsFour"].ToString();
                    FirstPassport = dataReader["PassportFirst"].ToString();
                    SecondPassport = dataReader["PassportSecond"].ToString();
                    ThirdPassport = dataReader["PassportSecond"].ToString();
                    FourPassport = dataReader["PassportFour"].ToString();
                    FirstBirthday = Convert.ToDateTime(dataReader["BirthFirst"]);
                    SecondBirthday = Convert.ToDateTime(dataReader["BirthSecond"]);
                    ThirdBirthday = Convert.ToDateTime(dataReader["BirthThird"]);
                    FourBirthday = Convert.ToDateTime(dataReader["BirthFour"]);
                    FirstAddress = dataReader["AddressFirst"].ToString();
                    SecondAddress = dataReader["AddressSecond"].ToString();
                    ThirdAddress = dataReader["AddressThird"].ToString();
                    FourAddress = dataReader["AddressFour"].ToString();
                    BirthCertificate = dataReader["CertificateOfBirth"].ToString();
                    DeathCertificate = dataReader["CertificateOfDeath"].ToString();
                    WeddingCertificate = dataReader["CertificateOfWedding"].ToString();
                    PassportNumber = dataReader["PassportId"].ToString();
                    IMG = (byte[])dataReader["Img"];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        public void Update(int humanId, string firstName, string lastName, string patronymic, string? address, DateTime birthDay, string activeRecord, DateTime arDate, DateTime dateOf, string placeOf, string performedSacrament, string? notes, string nameOfJournal, string initialFirst, string initialSecond, string initialThird, string initialFour, string passportFirst, string passportSecond, string passportThird, string passportFour, DateTime birthFirst, DateTime birthSecond, DateTime birthThird, DateTime birthFour, string addressFirst, string addressSecond, string addressThird, string addressFour, string? certificateOfBirth, string? certificateOfDeath, string? certificateOfWedding, string? passportNumber, byte[] image_bytes) 
        {
            string query = "UpdateTables";
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = humanId;
                    command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
                    command.Parameters.Add("@patronymic", SqlDbType.NVarChar).Value = patronymic;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                    command.Parameters.Add("@birthDay", SqlDbType.Date).Value = birthDay;
                    command.Parameters.Add("@activeRecord", SqlDbType.NVarChar).Value = activeRecord;
                    command.Parameters.Add("@arDate", SqlDbType.Date).Value = arDate;
                    command.Parameters.Add("@dateOf", SqlDbType.Date).Value = dateOf;
                    command.Parameters.Add("@placeOf", SqlDbType.NVarChar).Value = placeOf;
                    command.Parameters.Add("@performedSacrament", SqlDbType.NVarChar).Value = performedSacrament;
                    command.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes;
                    command.Parameters.Add("@nameOfJournal", SqlDbType.NVarChar).Value = nameOfJournal;
                    command.Parameters.Add("@initialsFirst", SqlDbType.NVarChar).Value = initialFirst;
                    command.Parameters.Add("@initialsSecond", SqlDbType.NVarChar).Value = initialSecond;
                    command.Parameters.Add("@initialsThird", SqlDbType.NVarChar).Value = initialThird;
                    command.Parameters.Add("@initialsFour", SqlDbType.NVarChar).Value = initialFour;
                    command.Parameters.Add("@passportFirst", SqlDbType.NVarChar).Value = passportFirst;
                    command.Parameters.Add("@passportSecond", SqlDbType.NVarChar).Value = passportSecond;
                    command.Parameters.Add("@passportThird", SqlDbType.NVarChar).Value = passportThird;
                    command.Parameters.Add("@passportFour", SqlDbType.NVarChar).Value = passportFour;
                    command.Parameters.Add("@birthFirst", SqlDbType.Date).Value = birthFirst;
                    command.Parameters.Add("@birthSecond", SqlDbType.Date).Value = birthSecond;
                    command.Parameters.Add("@birthThird", SqlDbType.Date).Value = birthThird;
                    command.Parameters.Add("@birthFour", SqlDbType.Date).Value = birthFour;

                    command.Parameters.Add("@addressFirst", SqlDbType.NVarChar).Value = addressFirst;
                    command.Parameters.Add("@addressSecond", SqlDbType.NVarChar).Value = addressSecond;
                    command.Parameters.Add("@addressThird", SqlDbType.NVarChar).Value = addressThird;
                    command.Parameters.Add("@addressFour", SqlDbType.NVarChar).Value = addressFour;
                    command.Parameters.Add("@certificateOfBirth", SqlDbType.NVarChar).Value = certificateOfBirth;
                    command.Parameters.Add("@certificateOfDeath", SqlDbType.NVarChar).Value = certificateOfDeath;
                    command.Parameters.Add("@certificateOfWedding", SqlDbType.NVarChar).Value = certificateOfWedding;
                    command.Parameters.Add("@passportId", SqlDbType.NVarChar).Value = passportNumber;
                    command.Parameters.Add("@img", SqlDbType.VarBinary).Value = image_bytes;
                    command.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Updated");
                }
            }
            catch(SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void Delete() { }
        public int GetId()
        {

            string query = @"select id from Human where id = (select max(id) from human)";
            try
            {
                OpenConnection();
                using SqlCommand command = new SqlCommand(query, _sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (dataReader.Read())
                {
                    HumanId = Convert.ToInt32(dataReader["Id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return HumanId;
        }
        public int GetId(int id) { return Id; }

        public void LoadMainData()
        {
            
            
        }

        
            
           
        

    }
}
