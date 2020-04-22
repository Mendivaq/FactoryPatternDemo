using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)            
                return null;
            if (shapeType == "Daire")
                return new Circle();
            if (shapeType == "Kare")
                return new Square();
            if (shapeType == "Dikdörtgen")
                return new Rectangle();
            return null;

            

        }
    }
}
