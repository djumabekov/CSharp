namespace Exam;
public static class Utils {

  public static int[] GetIntArray(int size, int min = 0, int max = int.MaxValue) {
    int[] arr = new int[size];
    var rnd = new Random(0);
    for (int i = 0; i < size; i++) {
      arr[i] = rnd.Next(min, max);
    }
    return arr;
  }



  public static void PrintArray<T>(T[] arr, int width = 8, int decimals = 0) {
    string format = "{0," + width.ToString() + "}";
    format = "{0," + width.ToString() + "}";
    if (typeof(T) == typeof(double))
      format = "{0," + width.ToString() + ":N" + decimals.ToString() + "}";

    int size = arr.Length;
    if (size <= 8) {
      for (int i = 0; i < size; i++) {
        Write(format, arr[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        Write(format, arr[i]);
      }
      Write(" . . . . . ");
      for (int i = size - 4; i < size; i++) {
        Write(format, arr[i]);
      }
    }
    WriteLine();
  }


  public static void PrintArrayByLines<T>(T[] arr, bool printAll = false) {
    int size = arr.Length;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine(arr[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        WriteLine(arr[i]);
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 4; i < size; i++) {
        WriteLine(arr[i]);
      }
    }
    WriteLine();
  }




  public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
    PrintArray<T>(list.ToArray(), width, decimals);
  }



  public static void PrintListByLines<T>(List<T> list, bool printAll = false) {
    int size = list.Count;
    if (size <= 8 || printAll) {
      for (int i = 0; i < size; i++) {
        WriteLine(list[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        WriteLine(list[i]);
      }
      WriteLine(". . . . . . . . . . . . ");
      for (int i = size - 4; i < size; i++) {
        WriteLine(list[i]);
      }
    }
    WriteLine();
  }
}
