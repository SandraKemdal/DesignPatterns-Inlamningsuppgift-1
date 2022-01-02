using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.HTMLDecorators;
using System;

namespace Design_Patterns_Assignment.Decorator
{
    public class HTMLGenerator
    {
        public static string TagProcessor(string tagSelection, string textInput)
        {
            IHTML html = new PlainHTML(textInput);
            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');

            foreach (var tag in taglist)
            {
                if (tag == "bold")
                {
                    html = new Bold(html);
                }
                if (tag == "deleted")
                {
                    html = new Deleted(html);
                }
                if (tag == "emphasized")
                {
                    html = new Emphasize(html);
                }
                if (tag == "important")
                {
                    html = new Important(html);
                }
                if (tag == "inserted")
                {
                    html = new Inserted(html);
                }
                if (tag == "italic")
                {
                    html = new Italic(html);
                }
                if (tag == "marked")
                {
                    html = new Marked(html);
                }
                if (tag == "smaller")
                {
                    html = new Smaller(html);
                }
                if (tag == "subscript")
                {
                    html = new Subscript(html);
                }
                if (tag == "superscript")
                {
                    html = new Superscript(html);
                }
            }
            return html.GetHTMLString();
        }
    }
}