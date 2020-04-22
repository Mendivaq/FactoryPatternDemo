using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
       public static void Main(string[] args)
        {
            ShapeFactory shp = new ShapeFactory();
            Shape sekil1 = shp.getShape("Daire");           
            sekil1.cevrehesapla();
            Shape sekil2 = shp.getShape("Kare");
            sekil2.cevrehesapla();
            Shape sekil3 = shp.getShape("Dikdörtgen");
            sekil3.cevrehesapla();
            Console.Read();

            
            

        }
    }





}
