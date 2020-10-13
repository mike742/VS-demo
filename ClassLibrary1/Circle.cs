using System;

namespace ClassLibrary1
{
    public class Circle
    {
        private float _radius;
        private static float _pi; 

        static Circle()
        {
            Console.WriteLine("this is the Static Constructor");
            _pi = 3.14f;
        }

        public Circle(float radius)
        {
            _radius = radius;
        }

        public float Area()
        {
            return _radius * _radius * _pi;
        }
    }
}
