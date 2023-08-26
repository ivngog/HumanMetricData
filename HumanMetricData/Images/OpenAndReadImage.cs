using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace HumanMetricData.Images
{
    public class OpenAndReadImage 
    {
        OpenFileDialog dlg;
        ImageSource imgSource;
        byte[] image_bytes;
        public OpenAndReadImage()
        {

        }
        public ImageSource OpenImg()
        {
            
            // Create OpenFileDialog 
            dlg = new OpenFileDialog();
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                //image_bytes = File.ReadAllBytes(dlg.FileName);
                // Open document 
                string filename = dlg.FileName;

                Uri uri = new Uri(filename);
                imgSource = new BitmapImage(uri);
            }
            return imgSource;
        }

        public byte[] readBytes()
        {
            try
            {
                image_bytes = File.ReadAllBytes(dlg.FileName);
            }
            catch { }
            return image_bytes;
        }

        public static string ByteToImage(byte[] img, string src)
        {
            string puth;
            
            using (FileStream fstrm = File.Open(@"" + src + "\\photo.jpg", FileMode.OpenOrCreate))
            {
                byte[] imgData = img;
                fstrm.Write(imgData, 0, imgData.Length);
                fstrm.Position = 0;
                puth = @"" + src + "\\photo.jpg";
            }
            
            
            return puth;
            
        }
    }
}
