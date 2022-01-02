using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer
{
    internal class Email : ISubject
    {

        public List<IObserver> Observers { get; set; }
        public string EmailContent { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            if(Observers.Count > 0)
            {
                foreach(var observer in Observers)
                {
                    observer.Update(EmailContent);
                }
            }
        }

        public void UpdateEmail()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute == 0)
            {
                EmailContent = "this is the email, sent during an even minute\n";
            }
            else
            {
                EmailContent = "this is the email, sent during an uneven minute\n";
            }

            NotifyObserver();
        }
    }
}