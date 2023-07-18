using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HumanMetricData.Model.Base;

namespace HumanMetricData.SQLOperations
{
    public interface IDataSIUD
    {
        DataView Select(string nameOfJournal, string firstName, string lastName, string patronymic, string placeOfReg, string numberOfDoc, string activeRec, DateTime someDate);
        void Select(int id);
        void InsertHuman(string firstname, string lastname, string patronymic, string address, DateTime birthdate);
        void InsertDocuments(string certificateOfBirth, string certificateOfDeath, string certificateOfWedding, int humanid, string passportNumber);
        void InsertBase(string activeRecord, DateTime arDate, DateTime dateOf, int humanId, string placeOf, string performedSacrament, string notes, string nameOfJournal, string initialFirst, string initialSecond, string initialThird, string initialFour, string passportFirst, string passportSecond, string passportThird, string passportFour, DateTime birthFirst, DateTime birthSecond, DateTime birthThird, DateTime birthFour, string addressFirst, string addressSecond, string addressThird, string addressFour);
        void InsertImages(byte[] image_bytes, int humanId);
        
        
        void Update(int humanId, string firstName, string lastName, string patronymic, string address, DateTime birthDay, string activeRecord, DateTime arDate, DateTime dateOf, string placeOf, string performedSacrament, string notes, string nameOfJournal, string initialFirst, string initialSecond, string initialThird, string initialFour, string passportFirst, string passportSecond, string passportThird, string passportFour, DateTime birthFirst, DateTime birthSecond, DateTime birthThird, DateTime birthFour, string addressFirst, string addressSecond, string addressThird, string addressFour, string certificateOfBirth, string certificateOfDeath, string certificateOfWedding, string passportNumber, byte[] image_bytes);
        void Delete();
        int GetId();
        int GetId(int id);

    }
}
