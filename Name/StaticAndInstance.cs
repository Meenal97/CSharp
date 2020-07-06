using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    class StaticAndInstance
    {
        static float _PI;
        int _Radius;
        
        static StaticAndInstance()
        {
            Console.WriteLine("Static Method Called");
            StaticAndInstance._PI = 3.141F;
        }
        public StaticAndInstance(int Radius)
        {
            Console.WriteLine("Instance Method Called");
            this._Radius = Radius;
        }

        public float Area()
        {
            return StaticAndInstance._PI * _Radius * _Radius;
        }
    }

}


