using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
   Problem 04 - GetOddEvenArrays
  Напишите метод, возвращающий кортеж из массивов нечетных и четных чисел, извлекаемых из переданного массива целых чисел:
  public static (int[] oddArr, int[] evenArr) GetOddEvenArrays(int[] arr).
  Для создания массива используйте Utils.GetIntArray, для распечатки - Utils.PrintArray(arrOdd); Utils.PrintArray(arrEven);
  Выполните проверку:
  WriteLine($"oddArr.Length + evenArr.Length == arr.Length: {oddArr.Length + evenArr.Length == arr.Length}");

   */
  internal class Problem_04 {

    public static (List<int> oddArr, List<int> evenArr) GetOddEvenArrays(List<int> arr) {
      List<int> evenArr = new List<int>(); //четные
      List<int> oddArr = new List<int>(); //нечетные
      var tupleLists = (evenArr, oddArr);
      for (int i = 0; i < arr.Count; i++) {
        if (arr[i] % 2 == 0) evenArr.Add(arr[i]);
        if (arr[i] % 2 != 0) oddArr.Add(arr[i]);
      }
      return tupleLists;
    }
  }
}
