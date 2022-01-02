using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Inserted : HTMLDecorator, IHTML
    {
        public Inserted(IHTML html) : base(html)
        {
            Tag = "ins";
        }
    }
}
