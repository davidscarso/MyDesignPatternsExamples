using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediador) : base(mediador)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un administrador recibe: " + message);
        }
    }
}
