using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using HumanMetricData.Images;
using System.Windows;

namespace HumanMetricData.Reports
{

    /*
     * Word.Application application = new Word.Application();
    Object missing = Type.Missing;
    application.Documents.Add(ref missing, ref missing, ref missing, ref missing);
    Clipboard.SetImage(pictureBox1.Image);
    application.ActiveDocument.Paragraphs[1].Range.Paste();
    application.Visible = true;
     */
    public class SendReport
    {
        
        readonly string templateFileName = @"" + Properties.Settings.Default.template + "\\" + "Cristening.docx";
        readonly string templateFileName2 = @"" + Properties.Settings.Default.template + "\\" + "Wedding.docx";
        readonly string templateFileName3 = @"" + Properties.Settings.Default.template + "\\" + "Funeral.docx";
        public void SendToWord(object nameOfJournal, object firstName, object lastName, object patronymic, object address, DateTime birthDay, object recordNumber, DateTime date, object place, DateTime committingDate, object initials, object notes, object initials1, DateTime date1, object passport1, object address1, object initials2, DateTime date2, object passport2, object address2, object initials3, DateTime date3, object passport3, object address3, object initials4, DateTime date4, object passport4, object address4, object document1, object document2, object document3, object document4, byte[] img)
        {

            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDocument = wordApp.Documents.Open(templateFileName);
                

                wordDocument.Bookmarks["image"].Range.InlineShapes.AddPicture(OpenAndReadImage.ByteToImage(img, Properties.Settings.Default.template));

                ReplaceWordStub("[nameOfJournal]", nameOfJournal.ToString(), wordDocument);
                ReplaceWordStub("[firstName]", firstName.ToString(), wordDocument);
                ReplaceWordStub("[lastName]", lastName.ToString(), wordDocument);
                ReplaceWordStub("[patronymic]", patronymic.ToString(), wordDocument);
                ReplaceWordStub("[address]", address.ToString(), wordDocument);
                ReplaceWordStub("[birthday]", birthDay.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[recordNumaber]", recordNumber.ToString(), wordDocument);
                ReplaceWordStub("[date]", date.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[place]", place.ToString(), wordDocument);
                ReplaceWordStub("[dateOfCommitting]", committingDate.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[initials]", initials.ToString(), wordDocument);
                ReplaceWordStub("[notes]", notes.ToString(), wordDocument);
                ReplaceWordStub("[firstName]", firstName.ToString(), wordDocument);
                ReplaceWordStub("[initials1]", initials1.ToString(), wordDocument);
                ReplaceWordStub("[date1]", date1.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[passport1]", passport1.ToString(), wordDocument);
                ReplaceWordStub("[address1]", address1.ToString(), wordDocument);
                ReplaceWordStub("[initials2]", initials2.ToString(), wordDocument);
                ReplaceWordStub("[date2]", date2.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[passport2]", passport2.ToString(), wordDocument);
                ReplaceWordStub("[address2]", address2.ToString(), wordDocument);
                ReplaceWordStub("[initials3]", initials3.ToString(), wordDocument);
                ReplaceWordStub("[date3]", date3.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[passport3]", passport3.ToString(), wordDocument);
                ReplaceWordStub("[address3]", address3.ToString(), wordDocument);
                ReplaceWordStub("[initials4]", initials4.ToString(), wordDocument);
                ReplaceWordStub("[date4]", date4.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[passport4]", passport4.ToString(), wordDocument);
                ReplaceWordStub("[address4]", address4.ToString(), wordDocument);
                ReplaceWordStub("[document1]", document1.ToString(), wordDocument);
                ReplaceWordStub("[document2]", document2.ToString(), wordDocument);
                ReplaceWordStub("[document3]", document3.ToString(), wordDocument);
                ReplaceWordStub("[document4]", document4.ToString(), wordDocument);
                wordDocument.SaveAs(@"Wedding.docx");
                
            
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);

            }
            finally { wordApp.Visible = true; }
        }
        public void SendToWord(object nameOfJournal, object firstName, object lastName, object patronymic, DateTime birthDay, object passport, object address, byte[] img1, object secondFirstName, object secondLastName, object secondPatronymic, DateTime secondBirthDay, object secondPassport, object secondAddress, byte[] img2, object recordNumber, DateTime date, DateTime committingDate, object place, object certificate, object initials1, DateTime date1, object passport1, object address1, object initials2, DateTime date2, object passport2, object address2, object performedSacrament, object notes) 
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDocument = wordApp.Documents.Open(templateFileName2);
                wordDocument.Bookmarks["image1"].Range.InlineShapes.AddPicture(OpenAndReadImage.ByteToImage(img1, Properties.Settings.Default.template));
                wordDocument.Bookmarks["image2"].Range.InlineShapes.AddPicture(OpenAndReadImage.ByteToImage(img2, Properties.Settings.Default.template));
                ReplaceWordStub("[nameOfJournal]", nameOfJournal.ToString(), wordDocument);
                ReplaceWordStub("[FirstName]", firstName.ToString(), wordDocument);
                ReplaceWordStub("[LastName]", lastName.ToString(), wordDocument);
                ReplaceWordStub("[Patronymic]", patronymic.ToString(), wordDocument);
                ReplaceWordStub("[Birthday]", birthDay.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[Passport]", passport.ToString(), wordDocument);
                ReplaceWordStub("[Address]", address.ToString(), wordDocument);

                ReplaceWordStub("[FirstName2]", secondFirstName.ToString(), wordDocument);
                ReplaceWordStub("[LastName2]", secondLastName.ToString(), wordDocument);
                ReplaceWordStub("[patronymic2]", secondPatronymic.ToString(), wordDocument);
                ReplaceWordStub("[Birthday2]", secondBirthDay.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[Passport2]", secondPassport.ToString(), wordDocument);
                ReplaceWordStub("[Address2]", secondAddress.ToString(), wordDocument);

                ReplaceWordStub("[RecordNumber]", recordNumber.ToString(), wordDocument);
                ReplaceWordStub("[DateOf]", date.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[CommitedDay]", committingDate.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[PlaceOf]",place.ToString(), wordDocument);
                ReplaceWordStub("[Certificate]", certificate.ToString(), wordDocument);

                ReplaceWordStub("[Witness1]", initials1.ToString(), wordDocument);
                ReplaceWordStub("[BirthDay3]", date1.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[Passport3]", passport1.ToString(), wordDocument);
                ReplaceWordStub("[Address3]", address1.ToString(), wordDocument);

                ReplaceWordStub("[Witness2]", initials2.ToString(), wordDocument);
                ReplaceWordStub("[BirthDay4]", date2.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[Passport4]", passport2.ToString(), wordDocument);
                ReplaceWordStub("[Address4]", address2.ToString(), wordDocument);
                ReplaceWordStub("[performedSacrament]", performedSacrament.ToString(), wordDocument);
                ReplaceWordStub("[Notes]", notes.ToString(), wordDocument);
                wordDocument.SaveAs(@"Wedding.docx");
                

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);

            }
            finally
            {
                wordApp.Visible = true;
            }
        }

        public void SendToWord(object nameOfJournal, object firstName, object lastName, object patronymic, DateTime birthDay, DateTime dateOfDeath, object recordNumber, DateTime date, DateTime committiedDate, object place, object performedSacrament, object notes, object certificate, byte[] img)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDocument = wordApp.Documents.Open(templateFileName3);
                wordDocument.Bookmarks["image"].Range.InlineShapes.AddPicture(OpenAndReadImage.ByteToImage(img, Properties.Settings.Default.template));
                
                ReplaceWordStub("[nameOfJournal]", nameOfJournal.ToString(), wordDocument);
                ReplaceWordStub("[firstName]", firstName.ToString(), wordDocument);
                ReplaceWordStub("[lastName]", lastName.ToString(), wordDocument);
                ReplaceWordStub("[patronymic]", patronymic.ToString(), wordDocument);
                ReplaceWordStub("[birthday]", birthDay.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[dateOfDeath]", dateOfDeath.ToString("dd.MM.yyyy"), wordDocument);

                ReplaceWordStub("[recordNumber]", recordNumber.ToString(), wordDocument);
                ReplaceWordStub("[dateOf]", date.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[commitedDay]", committiedDate.ToString("dd.MM.yyyy"), wordDocument);
                ReplaceWordStub("[placeOf]", place.ToString(), wordDocument);
                ReplaceWordStub("[deathCertificate]", certificate.ToString(), wordDocument);

                ReplaceWordStub("[performedSacrament]", performedSacrament.ToString(), wordDocument);
                ReplaceWordStub("[notes]", notes.ToString(), wordDocument);
                wordDocument.SaveAs(@"Funeral.docx");
                

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            finally
            {
                wordApp.Visible = true;
            }
        }
        private void ReplaceWordStub(string stubReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubReplace, ReplaceWith: text);

        }
    }
}
