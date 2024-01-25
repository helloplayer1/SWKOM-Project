using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities
{
    public class BLSearchException:BLException
    {
        public BLSearchException() : base() { }
        public BLSearchException(string message) : base(message) { }

    }
}
