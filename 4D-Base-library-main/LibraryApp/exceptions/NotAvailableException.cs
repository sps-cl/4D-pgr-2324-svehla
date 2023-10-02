﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.exceptions
{
    internal class NotAvailableException : Exception

    {
        public NotAvailableException(string message = "kniha není dostupná"): base(message) { }
    }
}
