using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Kare");
        }
        public void cevrehesapla()
        {
            int cevre = 4 * 3 ;
            Console.WriteLine("Kare Çevresi:{0} ", cevre);
        }
    }
}
