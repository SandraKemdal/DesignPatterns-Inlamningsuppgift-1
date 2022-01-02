using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class PlainHTML : IHTML
    {
        public string Text { get; set; }

        public PlainHTML(string textInput)
        {
            Text = textInput;
        }

        public string GetHTMLString()
        {
            return Text;
        }
    }
}
