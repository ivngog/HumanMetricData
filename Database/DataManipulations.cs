using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows;
using HumanMetricData.Model.Base;
using HumanMetricData.SQLOperations;

namespace HumanMetricData.Model
{
    
    public class DataManipulations : Sql
    {    
        public DataManipulations(int id)
        {
            Id = id;
        }
        public DataManipulations() { }

        public override void InsertHuman(string firstname, string lastname, string patronymic, string address, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Patronymic = patronymic;
            Address = address;
            DateOfBirth = birthdate;
            //MessageBox.Show(firstname + " " + lastname + " "+ patronymic + " " + address + " " + birthdate);
            string query = @"insert into Human (FirstName, LastName, Patronymic, Address, BirthDate) values(N'"+ FirstName + "',N'" + LastName + "',N'" + Patronymic + "', N'" + Address + "',N'" + DateOfBirth + "')";
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
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public override void InsertDocuments(string certificateOfBirth, string certificateOfDeath, string certificateOfWedding, int humanid, string passportNumber)
        {

            BirthCertificate = certificateOfBirth;
            DeathCertificate = certificateOfDeath;
            WeddingCertificate = certificateOfWedding;
            HumanId = humanid;
            PassportNumber = passportNumber;

            string query = @"insert into Documents (CertificateOfBirth, CertificateOfDeath, CertificateOfWedding, HumanId, PassportId) values(N'"+BirthCertificate+"', N'"+DeathCertificate+"', N'"+WeddingCertificate+"', N"+HumanId+",N'"+PassportNumber+"')";
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
        public override void InsertImages(byte[] image_bytes, int humanId)
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

        public override void InsertBase(string activeRecord, DateTime arDate, DateTime dateOf, int humanId, string placeOf, string performedSacrament, string notes, string nameOfJournal, string initialFirst, string initialSecond, string initialThird, string initialFour, string passportFirst, string passportSecond, string passportThird, string passportFour, DateTime birthFirst, DateTime birthSecond, DateTime birthThird, DateTime birthFour, string addressFirst, string addressSecond, string addressThird, string addressFour)
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
values(N'"+ActiveRecord+"','"+DateOfRecordNumber+"','"+DateOfСommiting+"', "+HumanId+", N'"+PlaceOfRegistration+"',N'"+PerformedSacrament+"',N'"+Notes+"',N'"+NameOfJournal+"',N'"+FirstInitials+"',N'"+SecondInitials+"',N'"+ThirdInitials+"',N'"+FourInitials+"',N'"+FirstPassport+"',N'"+SecondPassport+"',N'"+ThirdPassport+"',N'"+FourPassport+"','"+FirstBirthday+"', '"+SecondBirthday+"', '"+ThirdBirthday+"', '"+FourBirthday+"',N'"+FirstAddress+"',N'"+SecondAddress+"',N'"+ThirdAddress+"',N'"+FourAddress+"')";

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


        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override int GetId()
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
        public override int GetId(int id)
        {
            
            string query = @"select id from human where id = " + id + "";
            
            return id;
        }
        

    }
}
