﻿using System.Collections.Generic;
using System.Net;

namespace Core.Exceptions
{
    public class MethodNotImplementedException : CustomException
    {
        public MethodNotImplementedException(string message, List<string> errors = default, HttpStatusCode statusCode = default)
            : base(message, errors, statusCode)
        {
        }
    }
}
