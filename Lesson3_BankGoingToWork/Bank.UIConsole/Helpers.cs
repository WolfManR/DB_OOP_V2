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

    // And how remake for task
    public void SearchMail(ref string s, Action<string>? saveEmailAction)
    {
        if(saveEmailAction is null) return;

        const char separator = '&';
        // use buffer and not whole string
        ReadOnlySpan<char> toParsePart = s;

        while (true)
        {
            int index = toParsePart.IndexOf(separator);
            if (index == -1) break;
            char nextSymbol;
            do
            {
                nextSymbol = toParsePart[++index];

            } while (char.IsWhiteSpace(nextSymbol));

            toParsePart = toParsePart[index..];
            int endIndex = toParsePart.IndexOf(' ');

            if (endIndex == -1)
            {
                saveEmailAction.Invoke(toParsePart[..toParsePart.Length].ToString());
                break;
            }
            saveEmailAction.Invoke(toParsePart[..endIndex].ToString());
            toParsePart = toParsePart[endIndex..];
        }
    }
}