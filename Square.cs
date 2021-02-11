using System;

namespace SOLID
{
    public class Square : IShape
    {
        public double Area()
        {
            // based on some value some formula will be here
            return 0;
        }

        public double Volume()
        {
            // volume can't be implented here
            throw new NotImplementedException();
        }
    }
}