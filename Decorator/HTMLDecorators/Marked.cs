using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Marked : HTMLDecorator, IHTML
    {
        public Marked(IHTML html) : base(html)
        {
            Tag = "mark";
        }
    }
}
