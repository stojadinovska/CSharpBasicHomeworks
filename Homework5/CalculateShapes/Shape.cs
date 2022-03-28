using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShapes
{
    internal class Shape
    {
        private string _name;
        public string Name
        {
            get
            {
                Console.WriteLine("get: " + _name);
                return _name;
            }
            set
            {
                if (value == null)
                    value = "default";

                _name = value;
                Console.WriteLine("set: " + value);
            }
        }
        private string _color;
        public string Color 
        {
            get
            {
                Console.WriteLine("get: " + _color);
                return _color;
            }
            set
            {
                if(value == null)
                {
                    value = "Black";
                }
                _color = value;
                Console.WriteLine("set: " + value);
            }
        }

        public int[] Position = new int[2];

        public virtual void GetArea()
        {
            Console.WriteLine("No special implementation for this area");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("No special implementation for this perimeter");
        }
        public void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
        }
    }
}
