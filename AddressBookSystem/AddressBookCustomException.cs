using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookCustomException:Exception
    {
        private readonly ExceptionType type;

        public enum ExceptionType
        {
            WrongCityName,
            WrongStateName
        }

        public AddressBookCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
