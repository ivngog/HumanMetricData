using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HumanMetricData.Images
{
    public class ImagesConvertiting
    {

        public string ImageToByte()
        {
            using (FileStream fStream = File.Open(@"imageData.dat", FileMode.Create))
            {
                byte[] ImageData = File.ReadAllBytes(@"..\..\..\Images\Icons\btn_Close.png");

                fStream.Write(ImageData, 0, ImageData.Length);
                fStream.Position = 0;
                byte[] bytesFromFile = new byte[ImageData.Length];
                for (int i = 0; i < ImageData.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    // Console.Write(bytesFromFile[i]);
                }
                return Encoding.Default.GetString(bytesFromFile);

            }
        }

        public void ByteToImage()
        {
            using (FileStream fstrm = File.Open(@"1.jpg", FileMode.OpenOrCreate))
            {
                byte[] imgData = File.ReadAllBytes(@"D:\images\imageData.dat");
                fstrm.Write(imgData, 0, imgData.Length);
                fstrm.Position = 0;
            }
        }

        void FromPropertyToDat()
        {
           
        }
       
    }
}
