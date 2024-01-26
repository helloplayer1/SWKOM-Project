using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.DataAccess.Entities
{
    public class DALConnectionException:DALException
    {
        public DALConnectionException() : base() { }
        public DALConnectionException(string message) : base(message) { }
    }
}
