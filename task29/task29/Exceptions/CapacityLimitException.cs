using System;
using System.Collections.Generic;
using System.Text;

namespace task29.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
