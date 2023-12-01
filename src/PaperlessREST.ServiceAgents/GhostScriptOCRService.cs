using ImageMagick;
using PaperlessREST.ServiceAgents.Interfaces;
using System.Text;
using Tesseract;

namespace PaperlessREST.ServiceAgents
{
    public class GhostScriptOCRService : IOCRService
    {
        private OCROptions _options;

        public GhostScriptOCRService(OCROptions options)
        {
            _options = options;
        }

        public string PerformORC(Stream pdfStream)
        {
            StringBuilder sb = new();

            using var magicImageCollection = new MagickImageCollection();
            magicImageCollection.Read(pdfStream);

            using var tesseractEngine = new TesseractEngine(_options.TessDataPath, _options.Language, EngineMode.Default);
            foreach (var image in magicImageCollection)
            {
                // Set the resolution and format of the image (adjust as needed)
                image.Density = new Density(300, 300);
                image.Format = MagickFormat.Png;

                // Perform OCR on the image
                using var page = tesseractEngine.Process(Pix.LoadFromMemory(image.ToByteArray()));
                var extractedText = page.GetText();
                sb.Append(extractedText);
            }
            return sb.ToString();
        }
    }
}
