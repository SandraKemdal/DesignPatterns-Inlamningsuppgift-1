using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    class EmailWatcher : IObserver
    {
        public void Update(string email)
        {
            Console.WriteLine(email);
        }
    }
}
