namespace CSharp14Playground.ExtensionMembers;

public static class StringExtensions
{
    extension(string str)
    {
        public int CountWords()
        {
            if (str is null or "")
                return 0;

            // Check if the string is empty after trimming whitespace from the beginning and end.
            str = str.Trim();
            if (str is "")
                return 0;

            int wordCount = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]) || str[i] == '-' || str[i] == ',' || str[i]=='.')
                {
                    wordCount++;
                    while (i < str.Length && char.IsWhiteSpace(str[i]))
                        i++;
                }
            }

            return wordCount;
        }
    }
}
