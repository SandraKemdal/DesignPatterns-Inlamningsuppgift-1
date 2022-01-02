using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Bold : HTMLDecorator, IHTML
    {
        public Bold(IHTML html) : base(html)
        {
            Tag = "b";
        }
    }
}
