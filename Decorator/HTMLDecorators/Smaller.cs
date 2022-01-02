using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Smaller : HTMLDecorator, IHTML
    {
        public Smaller(IHTML html) : base(html)
        {
            Tag = "small";
        }
    }
}
