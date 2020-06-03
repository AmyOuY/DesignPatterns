using DILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IAccount CreateAccount()
        {
            return new Account(CreateLogger(), CreateSendMessage());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static ISendMessage CreateSendMessage()
        {
            //return new SendMessage();
            return new SendTestingMessage();
        }
    }
}
