using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
class Program
{
    public Program()
    {
        AddStrings();
        AddIntegers();
        AddWithPlusOperator();
        AddWithConcatString();
        AddWithJoinString();
        StringBuilder();
        StringBuilderUsingLoop();
        AddStringInterpolation();
        AddUsingStringFormat();
        ToUpper();
        ToUpperExample();
        ToTitleCase();
    }
    static void Main(string[] args)
    {
        new Program();
    }
    void AddStrings()
    {
        string a = "An old";
        string b = " Hawk";
        string c = a + b;
        Console.WriteLine(c);
        Console.WriteLine(".............................");
    }
    void AddIntegers()
    {
        int i = 25;
        int j = 50;
        int output = i + j;
        Console.WriteLine("The sum of i and j is :" + output);
        Console.WriteLine(".............................");
    }
    void AddWithPlusOperator()
    {
        string msg = "Learning coding";
        msg += " and doing practice";
        msg += " makes one good coder";
        Console.WriteLine(msg);
        Console.WriteLine(".............................");
    }
    void AddWithConcatString()
    {
        string a = "Cooperation is ";
        string b = " important in the teamwork.";
        string c = string.Concat(a, b);
        Console.WriteLine(c);
        Console.WriteLine(".............................");
    }
    void AddWithJoinString()
    {
        List<string> words = new List<string> { "there", "are", "two", "ways", "to", "learn", "coding" };
        string output = string.Join(" ", words);
        Console.WriteLine(output);
        Console.WriteLine(".............................");
    }
    void StringBuilder()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("{");
        sb.Append("HAPPY");
        sb.Append("CODING");
        sb.Append("}");
        string result = sb.ToString();
        Console.WriteLine(result);
        Console.WriteLine(".............................");
    }
    void StringBuilderUsingLoop()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            sb.Append("Number");
            sb.Append(i);
            sb.Append("\n");
            string result = sb.ToString();
            Console.WriteLine(result);
            Console.WriteLine(".............................");
        }
    }
    void AddStringInterpolation()
    {
        string name = "James";
        string surname = "cooper";
        string output = $"Our sports coach{name}{surname}is very supportive";
        Console.WriteLine(output);
        Console.WriteLine(".............................");
    }
    void AddUsingStringFormat()
    {
        string bird1 = "owl";
        string bird2 = "crow";
        string output = string.Format("There are {0} and {1} sitting on the tree", bird1, bird2);
        Console.WriteLine(output);
        Console.WriteLine(".............................");
    }
    void ToUpper()
    {
        string original = "Hello, World!";
        string upperCase = original.ToUpper();
        Console.WriteLine(upperCase);
        Console.WriteLine(".............................");
    }
    void ToUpperExample()
    {
        string name = "Brandy";
        string surname = " mclaen";
        string output = name + surname;
        string upperCase = output.ToUpper();
        Console.WriteLine(upperCase);
    }
    void ToTitleCase()
    {
        string name = "the inner peace is obtained by meditation";
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string TitleCase = textInfo.ToTitleCase(name);
        Console.WriteLine(TitleCase);
    }
}
    
