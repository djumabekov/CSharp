using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    /*
     Problem 01
    Изучите и продемонстрируйте работу методов класса string, перечисленных в
    public static void StringMethods()
    проекта Demo данного занятия.
     */
    internal class Problem_01
    {
        public static void StringMethods()
        {
            string s;

            //ОБЯЗАТЕЛЬНЫЕ:
            //public String(char[] value);
            char[] value = "Hello".ToCharArray();
            s = new String(value);
            WriteLine($"s = {s}");

            //public int Length { get; }
            WriteLine($"s.Length = {s.Length}");

            //public static int Compare(String strA, String strB, bool ignoreCase);
            string s2 = "World" ;
            WriteLine($"Compare '{s}' and '{s2}' => { String.Compare(s, s2, true)}");

            //public static String Concat(String str0, String str1);
            WriteLine($"Concat '{s}' and '{s2}' => { String.Concat(s, s2)}");

            //public static String Copy(String str);
            string s3 = String.Copy(s2);
            WriteLine($"Copy 's2' to 's3' => { s3 }");

            //public static bool Equals(String a, String b);
            WriteLine($"Equals '{s}' and '{s2}' => { String.Equals(s, s2)}");

            //public static bool IsNullOrEmpty(String value);
            WriteLine($"IsNullOrEmpty '{s}' => { String.IsNullOrEmpty(s)}");

            //public static bool IsNullOrWhiteSpace(String value);
            WriteLine($"IsNullOrWhiteSpace '{s}' => { String.IsNullOrWhiteSpace(s)}");

            //public bool Contains(String value);
            WriteLine($"Contains 'l' in {s} => { s.Contains('l')}");

            //public bool EndsWith(String value);
            WriteLine($"EndsWith 'o' in {s} => { s.EndsWith('o')}");

            //public bool Equals(String value);
            WriteLine($"Equals '{s}' and '{s2} => { s.Equals(s2)}");

            //public int IndexOf(String value);
            WriteLine($"IndexOf 'l' in {s} => { s.IndexOf('l')}");

            //public int IndexOf(String value, int startIndex);
            WriteLine($"IndexOf 'l' in {s} => { s.IndexOf('l', 3)}");

            //public int IndexOf(String value, int startIndex, int count);
            WriteLine($"IndexOf 'l' in {s} => { s.IndexOf('l', 1, 3)}");

            //public String Insert(int startIndex, String value);
            WriteLine($"Insert 'World' after {s} => { s.Insert(5, " World")}");

            //public int LastIndexOf(String value);
            WriteLine($"LastIndexOf 'l' in {s} => { s.LastIndexOf('l')}");

            //public String PadLeft(int totalWidth, char paddingChar);
            s3 = s.PadLeft(10, '*');
            WriteLine($"PadLeft '*' in {s} => { s3 }");

            //public String PadRight(int totalWidth);
            s3 = s.PadRight(10);
            WriteLine($"PadRight spaces in {s} => '{ s3 }'");

            //public String Remove(int startIndex);
            WriteLine($"Remove 'lo' in {s} => '{ s.Remove(3) }'");

            //public String Remove(int startIndex, int count);
            WriteLine($"Remove 'l' in {s} => '{ s.Remove(3, 1) }'");

            //public String Replace(String oldValue, String newValue);
            WriteLine($"Replace 'llo' to 'LLO' in {s} => '{ s.Replace("llo", "LLO") }");

            //public String Replace(char oldChar, char newChar);
            WriteLine($"Replace 'l' to 'L' in {s} => '{ s.Replace('l', 'L') }");

            //public String[] Split(params char[] separator);
            s = "Hello World!";
            string[] subs = s.Split(' ');
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");

            //public String[] Split(char[] separator, StringSplitOptions options);
            s = "Hello                World!";
            subs = s.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");

            //public String[] Split(String[] separator, StringSplitOptions options);
            s = "HelloSplitterWorld!";
            subs = s.Split("Splitter", StringSplitOptions.RemoveEmptyEntries);
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");

            //public bool StartsWith(String value);
            s = "Hello";
            WriteLine($"\nStartsWith 'H' in {s} => { s.StartsWith('H')}");

            //public String Substring(int startIndex, int length);
            WriteLine($"\nSubstring 'Hel' in {s} => { s.Substring(0, 3)}");

            //public String Substring(int startIndex);
            WriteLine($"\nSubstring 'lo' in {s} => { s.Substring(3)}");

            //public String ToLower();
            WriteLine($"\nToLower {s} => { s.ToLower()}");

            //public String ToUpper();
            WriteLine($"\nToUpper {s} => { s.ToUpper()}");

            //public String Trim();
            s = "   Hello World!   ";
            WriteLine($"\nTrim {s} => { s.Trim()}");

            //public String TrimEnd(params char[] trimChars);
            s = "***Hello World!***";
            WriteLine($"\nTrimEnd {s} => { s.TrimEnd('*')}");

            //public String TrimStart(params char[] trimChars);
            WriteLine($"\nTrimStart {s} => { s.TrimStart('*')}");

            //public static bool operator ==(String a, String b);
            s = "Hello";
            WriteLine($"\noperator == '{s}' == '{s2}' => { s == s2}");

            //public static bool operator !=(String a, String b);
            WriteLine($"\noperator != '{s}' != '{s2}' => { s != s2}");


            //ДОПОЛНИТЕЛЬНЫЕ (необязательные):
            WriteLine($"Equals '{s}' and '{s2}' => { String.Equals(s, s2, StringComparison.CurrentCulture)}");

            //public static String Format(String format, object arg0);
            WriteLine($"Format ' My World ' added after '{s}' => {  String.Format(s + "{0} {1}", " My", "World")}");

            //public static String Join(String separator, IEnumerable<String> values);
            s = "Hello World!";
            subs = s.Split(' ');
            WriteLine($"Join '{subs[0]}' and '{subs[1]}' => { String.Join(' ', subs)}");

            //public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
            char[] ch = { 'W', 'o', 'r', 'l', 'd', ' '};
            s.CopyTo(0, ch, 5, 1);
            WriteLine($"CopyTo 'H' to 5th index of ch");
            foreach (var item in ch) Write($"{item}, ");

            //public String[] Split(char[] separator, int count);
            s = "Hello World!";
            subs = s.Split(' ', 2);
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");

            //public String[] Split(char[] separator, int count, StringSplitOptions options);
            s = "Hello                World!";
            subs = s.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");

            //public String[] Split(String[] separator, int count, StringSplitOptions options);
            s = "HelloSplitterWorld!";
            subs = s.Split("Splitter", 2, StringSplitOptions.RemoveEmptyEntries);
            Write($"\nSplit: "); foreach (var sub in subs) Console.Write($"{sub}, ");
        }
    }
}
