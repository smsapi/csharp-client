﻿
namespace SMSApi.Api
{
    class Exception : System.Exception 
    { 
        public Exception(string message) : base(message) { }
        public Exception(string message, System.Exception inner) : base(message, inner) { }
    }
}
