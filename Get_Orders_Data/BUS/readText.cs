using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Orders_Data.BUS
{
    public class readText
    {
        string pdfInputPath;
        IronTesseract ocr = new IronTesseract();
        public readText(string input)
        {
            this.pdfInputPath = input;
        }
        public string Ocr()
        {
            ocr.Language = OcrLanguage.Vietnamese;
            var result = ocr.Read(pdfInputPath);
            return result.Text;
        }
    }
}
