using System.Text;

namespace CSharp14Playground;

public static class OldSyntaxExtensionMethods
{
    public static string Multiply(this string str, int count)
    {
        if (string.IsNullOrEmpty(str) || count <= 0)
            return string.Empty;
        
        StringBuilder sb = new();
        for (int i = 0; i < count; i++)
        {
            sb.Append(str);
        }
        
        return sb.ToString();
    }
}
