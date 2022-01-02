using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Important : HTMLDecorator, IHTML
    {
        public Important(IHTML html) : base(html)
        {
            Tag = "strong";
        }
    }
}
