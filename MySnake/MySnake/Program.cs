using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw();

            HorizontalLine LineG = new HorizontalLine(5, 10, 8, '+');
            LineG.Draw();

            VerticalLine LineV = new VerticalLine(2, 7, 11, '@');
            LineV.Draw();

            Console.ReadLine();
 
        }

      
       
    }
}
