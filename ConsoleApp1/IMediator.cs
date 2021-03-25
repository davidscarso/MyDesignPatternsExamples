using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IMediator
    {
        public void Send(string message, IColleague colleague);
    }
}
