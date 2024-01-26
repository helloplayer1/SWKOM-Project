using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities
{
    public class BLException : Exception
    {
        public BLException() : base() { }
        public BLException(string message) : base(message) { }
    }
}
