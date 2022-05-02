using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_7 {
  /*
  Problem 07
  Реализуйте следующие extention методы для класса String:
  DeleteSpaces() - удалить пробелы, переводы строк и символы табуляции 
  GetChar(int n) - символ в позиции n
  DeleteChars(char ch) - удалить все символы ch
  IsInt() - является ли строка представлением int (можно ли конвертировать?)
  IsDouble() - является ли строка представлением double (можно ли конвертировать?) 
  ToInt() - конвертация в int
  ToDouble() - конвертация в double

  Приведите пример использования fluent - способа вызова метода DeleteSpaces() вместе с другими библиотечными или собственными методами.

   */
  public static class Problem_07 {

    public static string DeleteSpaces(this string s) {
      if (string.IsNullOrEmpty(s))
        return String.Empty;
      s = s.Replace(" ", "");
      s = s.Replace("\t", "");
      s = s.Replace("\n", "");
      return s;
    }

    public static char GetChar(this string s, int n) {
      if (string.IsNullOrEmpty(s))
        return ' ';
      return s[n];
    }
    public static string DeleteChars(this string s, char ch) {
      if (string.IsNullOrEmpty(s))
        return String.Empty;
      return s.Replace(ch.ToString(), "");
    }
    public static bool IsInt(this string s) {
      if (string.IsNullOrEmpty(s))
        return false;
      return int.TryParse(s, out int number);
    }
    public static bool IsDouble(this string s) {
      if (string.IsNullOrEmpty(s))
        return false;
      return double.TryParse(s, out double number);
    }

    public static int ToInt(this string s) {
      int number = 0;
      try 
        {

        if (string.IsNullOrEmpty(s))
          throw new ArgumentException("ArgumentException. Строка пустая!");
        if (!int.TryParse(s.Trim(), out number))
          throw new NotSupportedException("NotSupportedException. Ошибка конвертации string в int!");
      } 
      catch (Exception ex) 
      {
        WriteLine(ex.Message);
      }
      return number;
    }

    public static double ToDouble(this string s) {
      double number = 0;
      try {

        if (string.IsNullOrEmpty(s))
          throw new ArgumentException("ArgumentException. Строка пустая!");
        if (!double.TryParse(s.Trim(), out number))
          throw new NotSupportedException("NotSupportedException. Ошибка конвертации string в double!");
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      return number;
    }
    public static void DemoExtentions() {
      string pooh = "pooh";
      Write("DeleteSpaces(' p    o   oh   '): "); WriteLine("       p o \n   oh \n      ".DeleteSpaces());
      Write("GetChar('h' from pooh): "); WriteLine(pooh.GetChar(3));
      Write("DeleteChars('o from pooh'): "); WriteLine("pooh".DeleteChars('o'));
      Write("IsInt('abc'): "); WriteLine("abc".IsInt()); 
      Write("IsInt('123'): "); WriteLine("123".IsInt());
      Write("IsDouble('abc,abc'): "); WriteLine("abc,abc".IsDouble());
      Write("IsDouble('123,123'): "); WriteLine("123,123".IsDouble());
      Write("ToInt('123'): "); WriteLine("123".ToInt());
      Write("ToDouble('123,123'): "); WriteLine("123,123".ToDouble());

      /*  
       Приведите пример использования fluent - способа вызова метода DeleteSpaces() вместе с другими библиотечными или собственными методами.
      */
      string str = "     Lorem \t     Ipsum \n Dolor Dit Amet     123    ";
      int newNumber = str.ToLower().DeleteChars('o').DeleteSpaces().Substring(19, 3).ToInt();
      WriteLine($"fluent - способ вызова метода DeleteSpaces(). NewNumber = {newNumber}" );
    }



  }
}
