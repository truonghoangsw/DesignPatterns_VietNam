using System.Text;

namespace BuilderPatterns
{
    public class LifeWithoutBuilder
    {
        static void Main_1(string[] args)
        {
            var hello = "hello";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.Append($"<li>{word}</li>");
            }

            sb.Append("</ul>");
        }
    }
}