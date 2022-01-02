using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Italic : HTMLDecorator, IHTML
    {
        public Italic(IHTML html) : base(html)
        {
            Tag = "i";
        }
    }
}
