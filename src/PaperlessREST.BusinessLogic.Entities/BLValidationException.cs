using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities
{
    public class BLValidationException : BLException
    {   
        public BLValidationException():base() { }
        public BLValidationException(string message) : base(message) { }
    }
}
