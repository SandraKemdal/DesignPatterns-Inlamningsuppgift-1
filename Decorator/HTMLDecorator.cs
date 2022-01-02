using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class HTMLDecorator : IHTML
    {
        public IHTML HTML { get; set; }
        public string Tag;

        public HTMLDecorator(IHTML html)
        {
            HTML = html;
        }

        public string GetHTMLString()
        {
            return $"<{Tag}>{HTML.GetHTMLString()}</{Tag}>";
        }
    }
}
