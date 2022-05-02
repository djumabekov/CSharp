using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_06
{
  /*
    Problem 02
    Напишите программу, демонстрирующую возникновение и перехват ряда стандартных исключений: 
    ArgumentException
    ArgumentNullException
    ArgumentOutOfRangeException
    InvalidOperationException
    NotSupportedException
    DivideByZeroException
    OverflowException
     */
  internal class Problem_02 {

    static void DemoArgumentException(string user) {
      try {
        if (user.Length < 1)
          throw new ArgumentException("ArgumentException. Имя пользователя не может быть пустым!");
        WriteLine(user);
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoArgumentNullException(string user) {
      try {
        if (user == null)
          throw new ArgumentNullException("ArgumentNullException. Имя пользователя не может быть null!");
        WriteLine(user);
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoArgumentOutOfRangeException(int[] arr) {
      try {
        foreach (var item in arr)
          if (item < 0) throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException. Аргумент не соответствует допустимому диапазону значений!");
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoInvalidOperationException(FileStream logFile) {
      try {
        if (logFile == null)
          throw new InvalidOperationException("InvalidOperationException. Отсутствует Лог-файл. Операция не может быть выполнена!");
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoNotSupportedException(string user) {
      try {
        if (!int.TryParse(user, out int result))
          throw new NotSupportedException("NotSupportedException. Ошибка конвертации string в int!");
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoDivideByZeroException(int div) {
      try {
        if (div == 0)
          throw new NotSupportedException("DivideByZeroException. Ошибка попытки деления на ноль!");
        int num = div / div;
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    static void DemoOverflowException(string value) {
      try {
        if (long.Parse(value) > int.MaxValue)
          throw new OverflowException("OverflowException. Ошибка переполнения!");
        int number = int.Parse(value);
      } 
      catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

    public static void DemoExeptions() {
      DemoArgumentException("");

      DemoArgumentNullException(null);

      int[] arr = {1, 2, -3 };
      DemoArgumentOutOfRangeException(arr);

      DemoInvalidOperationException(null);

      DemoNotSupportedException("user");

      DemoDivideByZeroException(0);

      DemoOverflowException("5000000000");
    }

    }
}
