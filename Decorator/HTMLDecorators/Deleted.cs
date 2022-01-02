using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Deleted : HTMLDecorator, IHTML
    {
        public Deleted(IHTML html) : base(html)
        {
            Tag = "del";
        }
    }
}
