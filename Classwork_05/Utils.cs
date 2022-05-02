using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UtilsNS {
  public static class Utils {
    public static void PrintArray<T>(T[] arr, int width = 8, int decimals = 0) {
      string format = "{0," + width.ToString() + ":N" + decimals.ToString() + "}, ";
      int size = arr.Length;
      if (size <= 8) {
        for (int i = 0; i < size; i++) {
          Write(format, arr[i]);
        }
      } else {
        for (int i = 0; i < 4; i++) {
          Write(format, arr[i]);
        }
        Write(" . . . .");  
        for (int i = size -4; i < size; i++) {
          Write(format, arr[i]);
        }
      }
      WriteLine();
    }
  }
}
