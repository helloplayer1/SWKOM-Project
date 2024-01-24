using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.DataAccess.Entities
{
    public class DALException:Exception
    {
        public DALException() : base() { }
        public DALException(string message) : base(message) { }
    }
}
