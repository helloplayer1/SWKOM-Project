using ImageMagick;
using PaperlessREST.ServiceAgents.Interfaces;
using System.Text;
using Tesseract;
using IronOcr;

namespace PaperlessREST.ServiceAgents
{
    public class IronOCRService : IOCRService
    {
        public string PerformORC(Stream pdfStream)
        {
            IronTesseract ocr = new()
            {
                Language = OcrLanguage.GermanBest
            };
            OcrInput ocrInput = new();

            ocrInput.AddPdf(pdfStream);

            OcrResult result = ocr.Read(ocrInput);
            return result.Text;
        }
    }
}
