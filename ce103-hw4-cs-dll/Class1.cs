using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ce103_hw4_cs_dll
{
    internal class Class1
    {
    }
}


namespace CSharpFibonacciDizilimi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int a, b = 1, result = 0;
            // We create int type variables named a, b and result.
            // We set the variable b to 1.
            // set the result variable to 0.  


            for (int i = 0; i < 10; i++)
            {
                // We create a loop.
                // Create an int variable named i.
                // Our loop will repeat until i equals 10.
                // Increment the variable i by one.
                // In this way we have the day returned 10 times.  


                a = b;
                // We assign the value of variable b to variable a. 

                b = result;
                // We assign the value of the result variable to variable b.  

                result = a + b;
                // We add the a and b values ​​and assign them to the result variable. 

                Console.WriteLine(result);
                // sWe print the oc value to the console.  

            }
        }
    }
}





namespace strlen { 
}
public class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        string value = "Hello";
        Console.WriteLine("number of characters : {0}", value.Length);

        string value2 = "";
        Console.WriteLine("number of characters : {0}", value2.Length);

        Console.WriteLine("number of characters : {0}", "Hello".Length);
        _ = value.Length;

        Console.ReadLine();
        Console.WriteLine("number of characters : {0}", value.Length);
    }
}


namespace strrev
{

}

public static class Test
{
    private static IEnumerable<string> GraphemeClusters(this string s)
    {
        var enumerator = StringInfo.GetTextElementEnumerator(s);
        while (enumerator.MoveNext())
        {
            yield return (string)enumerator.Current;
        }
    }
    private static string ReverseGraphemeClusters(this string s)
    {
        return string.Join("", s.GraphemeClusters().Reverse().ToArray());
    }

    public static void Main()
    {
        var s = "Les Mise\u0301rables";
        var r = s.ReverseGraphemeClusters();
        Console.WriteLine(r);
    }
}


namespace Strcat

{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string value1 = "Merhaba1";
            string value2 = "Merhaba2";
            string result = string.Concat(value1, value2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

namespace strcmp
{

}
    public class StringExample
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
}

    namespace hex2bin
    {

    }
    public class Util
    {
        /*
         * Function: hex2bin
         */
        public static char hex2bin(char c)
        {
            if ('0' <= c && '9' >= c)
            {
                return (char)(c - '0');
            }
            else if ('a' <= c && 'f' >= c)
            {
                return (char)(c - 'a' + 10);
            }
            else if ('A' <= c && 'F' >= c)
            {
                return (char)(c - 'A' + 10);
            }

            return (char)0;
        }

    }
 namespace bin2hex { }
   
public class CryptoUtility
{
}

namespace strcpy { }

// C# program to demonstrate the 
// use of Copy() method

class Class1
{

    static void Cpymethod()
    {
        string str1 = "GeeksforGeeks";
        string str2 = "GFG";
        Console.WriteLine("Original Strings are str1 = "
            + "'{0}' and str2='{1}'", str1, str2);

        Console.WriteLine("");

        Console.WriteLine("After Copy method");
        Console.WriteLine("");

        // using the Copy method
        // to copy the value of str1 
        // into str2
        str2 = String.Copy(str1);

        Console.WriteLine("Strings are str1 = "
        + "'{0}' and str2='{1}'", str1, str2);

        // check the objects reference equal or not
        Console.WriteLine("ReferenceEquals: {0}",
            Object.ReferenceEquals(str1, str2));

        // check the objects are equal or not
        Console.WriteLine("Equals: {0}", Object.Equals(str1, str2));
        Console.WriteLine("");

        Console.WriteLine("After Assignment");
        Console.WriteLine("");

        // to str1 object reference assign to str2
        str2 = str1;

        Console.WriteLine("Strings are str1 = '{0}' "
                    + "and str2 = '{1}'", str1, str2);

        // check the objects reference equal or not
        Console.WriteLine("ReferenceEquals: {0}",
            Object.ReferenceEquals(str1, str2));

        // check the objects are equal or not
        Console.WriteLine("Equals: {0}", Object.Equals(str1, str2));

    }

    // Main Method
    public static void Main()
    {

        // calling method
        Cpymethod();
    }
}