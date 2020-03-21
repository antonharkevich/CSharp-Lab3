using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct Dimensions
    {
        public Dimensions(int m)
        {
            width = m;
            height = m;
            length = m;
        }
        public double width;
        public double height;
        public double length;
    };
}
