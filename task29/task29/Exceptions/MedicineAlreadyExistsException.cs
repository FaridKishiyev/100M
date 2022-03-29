using System;
using System.Collections.Generic;
using System.Text;

namespace task29.Exceptions
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message):base(message)
        {

        }
    }
}
