using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.ServiceAgents
{
    public class OCROptions
    {
        public string Language { get; set; } = "eng";
        public string TessDataPath { get; set; } = "./eng.tessdata";
    }
}
