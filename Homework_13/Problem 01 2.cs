using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_13 {
  internal class Problem_01_2 {
    /*
    ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

   Problem 01
   Реализуйте, опираясь на ранее решенную задачу, класс LinkedList<T> (обобщенный односвязный список). 
    Продемонстрируйте его работу на встроенных и пользовательских (class или struct) типах данных.

   */
    class Node<T> {
      public Node(T value) {
        Value = value;
      }
      public T Value { get; internal set; }
      public Node<T> Next { get; internal set; }
      public Node<T> Previous { get; internal set; }
    }

    class LinkedList<T> {
      private Node<T> _head;
      private Node<T> _tail;
      private int count;
      public Node<T> Head {
        get {
          return _head;
        }
      }

      public Node<T> Tail {
        get {
          return _tail;
        }
      }

      public void Add(T item) {
        AddLast(item);
      }
      public void AddFirst(T value) {
        Node<T> node = new Node<T>(value);
        if (_head == null)
          _head = _tail = node;
        else
          node.Next = _head;

        _head = node;

        count++;
      }
      public void AddLast(T value) {
        Node<T> node = new Node<T>(value);

        if (_head == null)
          _head = _tail = node;
        else
          _tail.Next = node;
        _tail = node;

        count++;
      }
      public void RemoveFirst() {
        if (_head != null) {
          Node<T> newHead = _head.Next;
          _head = newHead;
          if (--count == 0) { _tail = null; }
        } else {
          WriteLine("list is empty");
        }
      }
      public void RemoveLast() {
        if (_head != null) {
          Node<T> newTail = _head;
          for (int i = 0; i < count - 2; i++) {
            newTail = newTail.Next;
          }
          _tail = newTail;
          if (--count == 0) { _head = _tail; }
        } else {
          WriteLine("list is empty");
        }
      }
      public bool Contains(T item) {
        Node<T> current = _head;
        for (int i = 0; i < count; i++) {
          if (current.Value.Equals(item)) {
            return true;
          }
          current = current.Next;
        }
        return false;
      }
      public T[] CopyToArray() {
        T[] array = new T[count];
        Node<T> current = _head;
        for (int i = 0; i < count; i++) {
          array[i] = current.Value;
          current = current.Next;
        }
        return array;
      }
      public bool Remove(T item) {
        Node<T> current = _head;
        Node<T> previous = null;

        while (current != null) {
          if (current.Value.Equals(item)) {
            if (previous != null) {
              previous.Next = current.Next;
              if (current.Next == null)
                _tail = previous;
            } else {
              _head = _head.Next;
              if (_head == null)
                _tail = null;
            }
            count--;
            return true;
          }
          previous = current;
          current = current.Next;
        }
        return false;
      }

      public void Clear() {
        //_head = null;
        //_tail = null;
        //count = 0;
        while (count != 0) {
          RemoveFirst();
        }
      }
      public void Print() {
        Node<T> current = _head;
        for (int i = 0; i < count; i++) {
          WriteLine($"{current.Value} ");
          current = current.Next;
        }
      }

    }
    public static void Demo() {
      LinkedList<string> list = new LinkedList<string>();

      WriteLine("\n============Демонстрация на классе string============\n");

      list.Add("first");
      list.Add("second");
      list.Add("third");
      WriteLine("\nPrint all values: ");
      list.Print();

      WriteLine("\nRemove First values: ");
      list.RemoveFirst();
      list.Print();


      WriteLine("\nRemove Last values: ");
      list.RemoveLast();
      list.Print();

      WriteLine("\nRemove value \"second\": ");
      list.Remove("second");
      list.Print();

      WriteLine("\nAdd First and Add Last values:");
      list.AddFirst("zero");
      list.AddLast("fourth");
      list.Print();

      bool isContains = list.Contains("zero");
      Write($"\nIs contains (\"zero\")? {isContains}\n");

      WriteLine("\nCopy To Array and print array: ");
      string[] array = list.CopyToArray();
      Utils.PrintArrayByLines(array);

      WriteLine("\nClear list: ");
      list.Clear();
      list.Print();

      WriteLine("\n============Демонстрация на структуре DateTime============\n");

      LinkedList<DateTime> list2= new LinkedList<DateTime>();

      Random gen = new Random();
      DateTime RandomDay() {
        DateTime start = new DateTime(1995, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(gen.Next(range));
      }

      for (int i = 0; i < 10; i++) {
        list2.Add(RandomDay());
      }
      WriteLine("\nPrint all values: ");
      list2.Print();

      WriteLine("\nRemove First values: ");
      list2.RemoveFirst();
      list2.Print();

      WriteLine("\nRemove Last values: ");
      list2.RemoveLast();
      list2.Print();


      WriteLine("\nAdd First and Add Last values:");
      list2.AddFirst(new DateTime(1995, 1, 1));
      list2.AddLast(new DateTime(1998, 4, 4));
      list2.Print();

      WriteLine("\nRemove value \"1995, 1, 1\": ");
      list2.Remove(new DateTime(1995, 1, 1));
      list2.Print();

      isContains = list2.Contains(new DateTime(1995, 1, 1));
      Write($"\nIs contains (\"1995, 1, 1\")? {isContains}\n");

      WriteLine("\nCopy To Array and print array: ");
      DateTime[] array2 = list2.CopyToArray();
      Utils.PrintArrayByLines(array2);

      WriteLine("\nClear list: ");
      list2.Clear();
      list2.Print();

      WriteLine("\n============Демонстрация на Student============\n");

      LinkedList<Student> list3 = new LinkedList<Student>();

      for (int i = 0; i < 10; i++) {
        list3.Add(new Student() { StudentId = i, IIN = Math.Abs(gen.Next(int.MinValue, int.MaxValue)).ToString(), Birthday = RandomDay(), FirstName = $"Student_{i}", LastName = $"Studentov_{i}", GroupId = Math.Abs(gen.Next(int.MinValue, int.MaxValue)) });
       }
      Student Student_id_11 = new Student() { StudentId = 11, IIN = Math.Abs(gen.Next(int.MinValue, int.MaxValue)).ToString(), Birthday = RandomDay(), FirstName = $"Student_11", LastName = $"Studentov_11", GroupId = Math.Abs(gen.Next(int.MinValue, int.MaxValue)) };
      Student Student_id_12 = new Student() { StudentId = 12, IIN = Math.Abs(gen.Next(int.MinValue, int.MaxValue)).ToString(), Birthday = RandomDay(), FirstName = $"Student_12", LastName = $"Studentov_12", GroupId = Math.Abs(gen.Next(int.MinValue, int.MaxValue)) };

      WriteLine("\nPrint all values: ");
      list3.Print();

      WriteLine("\nRemove First values: ");
      list3.RemoveFirst();
      list3.Print();

      WriteLine("\nRemove Last values: ");
      list3.RemoveLast();
      list3.Print();


      WriteLine("\nAdd First and Add Last values:");
      list3.AddFirst(Student_id_11);
      list3.AddLast(Student_id_12);
      list3.Print();

      WriteLine("\nRemove value: \"StudentId = 11\": ");
      list3.Remove(Student_id_11);
      list3.Print();

      isContains = list3.Contains(Student_id_11);
      Write($"\nIs contains \"StudentId = 11\"? {isContains}\n");

      WriteLine("\nCopy To Array and print array: ");
      Student[] array3 = list3.CopyToArray();
      Utils.PrintArrayByLines(array3);

      WriteLine("\nClear list: ");
      list3.Clear();
      list3.Print();
    }
  }
}