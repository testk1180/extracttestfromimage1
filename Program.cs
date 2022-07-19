using OpenCvSharp;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace extractTextfromImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hardcoded for testing.
            string imagePath = @"C:\Users\Kirti.Bodekar\Downloads\Capture.png";
            Mat img = Cv2.ImRead(imagePath);
            // Hardcoded for testing. 
            string tessDataPath = @"D:\ICAP\cap-workbench-1.3.12\cap-workbench-1.3.12\bin\Debug\1tessdata";
            string result = "";
            OpenCvSharp.Rect[] textLocations = null;
            string[] componentTexts = null;
            float[] confidences = null;

            using (var engine = OpenCvSharp.Text.OCRTesseract.Create(tessDataPath, "eng"))
            {
                engine.Run(img, out result, out textLocations, out componentTexts, out confidences, OpenCvSharp.Text.ComponentLevels.TextLine);
            }



            Console.WriteLine(result);
            Console.WriteLine("Hello World!");

        }
    }
}
