using System;

public class StringExampleBase
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        string s1 = "hello";
        string s2 = "hello";
        string s3 = "csharp";
        string s4 = "mello";

        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s3, s4));
    }
    public static void main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        string s1 = "Hello ";
        string s2 = string.Copy(s1);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}