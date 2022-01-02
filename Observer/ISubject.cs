using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void NotifyObserver();
        void UpdateEmail();

    }
}
