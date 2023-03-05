
namespace StringOperations;
public class StringManipulations
{
    public string SimpleReverseSentence(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        string output = string.Empty;
        string[] words = input.Split(' ');
        Array.Reverse(words);
        output = string.Join(" ", words);

        return output;
    }

    //Where are you? I am here.
    public string ReverseSentenceWithSpecialCharacters(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        string output = string.Empty;

        string[] words = input.Split(' ');
        Array.Reverse(words);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].EndsWith('.') || words[i].EndsWith('?') || words[i].EndsWith('!'))
            {
                words[i] = words[i].Substring(words[i].Length - 1) + words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, (words[i].Length - 2)).ToLower();
            }
            else
            {
                words[i]  = words[i] == "I" ? "I" : words[i].ToLower();
            }
        }
        output = string.Join(" ", words);
        return output.Trim();
    }
}

