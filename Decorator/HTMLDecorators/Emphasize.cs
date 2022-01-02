using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.HTMLDecorators
{
    class Emphasize : HTMLDecorator, IHTML
    {
        public Emphasize(IHTML html) : base(html)
        {
            Tag = "em";
        }
    }
}
