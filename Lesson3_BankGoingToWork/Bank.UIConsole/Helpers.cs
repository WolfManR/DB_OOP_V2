using System.Text;

namespace Bank.UIConsole;

public class Helpers
{
    public string Reverse(string toReverse)
    {
        StringBuilder sb = new();
        for (var i = toReverse.Length - 1; i >= 0; i--)
        {
            sb.Append(toReverse[i]);
        }

        return sb.ToString();
    }
}