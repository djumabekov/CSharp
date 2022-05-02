using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
   Problem 01
  Написать extention method для класса string HelloTo().
  Например:
  WriteLine("Pooh".HelloTo());
  WriteLine(studentName.HelloTo());
  WriteLine("Пятачок".HelloTo());
   */
  public static class Problem_01 {
    public static string HelloTo(this string s) {
      if (string.IsNullOrEmpty(s))
        return String.Empty;
      return s + ", Hello!";
    }
  }
}
