using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EySpy.Exceptions
{
    public class LogNotFoundException : Exception
    {
        public LogNotFoundException()
        {
        }

        public LogNotFoundException(string message)
            : base(message)
        {
        }

        public LogNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
