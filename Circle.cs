using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Daire");
        }
        public void cevrehesapla()
        {
            double cevre = 2 * Math.PI * 2;
            Console.WriteLine("Daire Çevresi:{0} ", cevre);
        }



    }
}
