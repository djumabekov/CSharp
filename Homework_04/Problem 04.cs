using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4
{
    internal class Problem_04
    {
        public class PointClass
        {
            public int X;
            public int Y;
        }
        public struct PointStruct
        {
            public int X;
            public int Y;
        }

        //Метод, увеличивающий координаты p на x, y: 
        public static void ChangePointClass(ref PointClass p, int x, int y)
        {
            p.X += x;
            p.Y += y;
        }
        //Метод, увеличивающий координаты p на x, y: 
        public static void ChangePointStruct(ref PointStruct p, int x, int y)
        {
            p.X += x;
            p.Y += y;
        }
        //Метод, создающий p с координатами x, y:
        public static void GetNewPointClass(out PointClass p, int x, int y)
        {
            p = new PointClass();
            p.X = x;
            p.Y = y;
        }

        //Метод, создающий p с координатами x, y:
        public static void GetNewPointStruct(out PointStruct p, int x, int y)
        {
            p = new PointStruct();
            p.X = x;
            p.Y = y;
        }
    }
}
