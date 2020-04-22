using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class Rectangle : Shape
    {
        public void cevrehesapla()
        {
            int cevre = 2 * 3 * 4;
            Console.WriteLine("Dikdörtgen Çevresi:{0} ",cevre);
        }

        public void draw()
        {
            Console.WriteLine("Dikdörtgen");
        }
    }
}
