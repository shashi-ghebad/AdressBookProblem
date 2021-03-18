using System;
using System.Collections.Generic;
using System.Text;

namespace UC10_Exception
{
    class UCException : Exception
    {
        public enum ExceptionTypes
        {
            Invalid_UserName,
            Invalid_lastName,
            Invalid_Email,
            Invalid_MobileNumber,
            Invalid_Password,


        }
        private readonly ExceptionTypes type;
        public UCException(ExceptionTypes Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
