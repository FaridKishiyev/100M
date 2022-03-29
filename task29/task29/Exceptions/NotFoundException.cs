using System;
using System.Collections.Generic;
using System.Text;

namespace task29.Exceptions
{
    class NotFoundException: Exception
    {
        public NotFoundException(string message):base(message)
        {
                
        }
    }
}
