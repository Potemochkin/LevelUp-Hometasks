using System.Text.RegularExpressions;

namespace Lesson5
{
    public static class StringExtensions
    {
        public static string ClearString(this string str)
        {
            str = Regex.Replace(str, "\n|\r|\t|\a|\b|\v|\f|[^a-zA-Z0-9 -]", "");
            str = Regex.Replace(str, "\\s+", " ");
            return str.Trim();
        }
    }
}