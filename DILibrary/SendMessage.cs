﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DILibrary
{
    public class SendMessage : ISendMessage
    {
        public void Send(IPerson person, string message)
        {
            Console.WriteLine($"Send a message: { message } to { person.Email }");
        }
    }
}
