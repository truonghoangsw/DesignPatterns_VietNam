using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterns
{
    public class HtmlElement
    {
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2; 
        public string Text { get; set; }
        public string Name { get; set; }

        public HtmlElement()
        {
            
        }

        public HtmlElement(string text, string name)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        private string ToStringImp(int indent)
        {
            var sb = new StringBuilder();
            var strIndent = new string(' ', indentSize * indent);
            sb.Append($"{strIndent}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var element in Elements)
            {
                sb.AppendLine(element.ToStringImp(indent + 1));
            }
            sb.Append($"{strIndent}</{Name}>");
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImp(0);
        }
    }

    public class HtmlBuilder
    {
        private HtmlElement _root = new HtmlElement();
        private string _nameRoot;

        public HtmlBuilder(string nameRoot)
        {
            _nameRoot = nameRoot;
            _root.Name = _nameRoot;
        }

        public void AddChild(string text, string name)
        {
            _root.Elements.Add(new HtmlElement(text, name));
        }
      

        public override string ToString()
        {
            return _root.ToString();
        }
    }
    class Builder_1
    {
        static void Main_2(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());

        }
    }
}
