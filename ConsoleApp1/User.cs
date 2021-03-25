using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User : IColleague
    {
        public User(IMediator mediador) : base(mediador)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un usuario recibe: " + message);
        }
    }
}
