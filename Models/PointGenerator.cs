namespace OOP_LAB1.Models
{
    public class PointGenerator
    {
        private Random _r = new Random();
        private int c1 = 100;
        private int c2 = 200;
        private int c3 = 300;
        private int c4 = 400;
        private int c5 = 500;
        private int c6 = 600;
        private int c7 = 700;
        public int[] Generate(int count)
        {
            if (count == 1)
            {
                return new[] {c2+ _r.Next(c5), c2 + _r.Next(c4) };
            }
            if (count == 2)
            {
                return new[] { c6+ _r.Next(c3), c4 + _r.Next(c3), c6 + _r.Next(c3), c4 + _r.Next(c3) };
            }
            if (count == 3)
            {
                return new[] { c7+ _r.Next(c1), _r.Next(c1), c7 + _r.Next(c1),
                    _r.Next(c1) , c7 + _r.Next(c3), _r.Next(c3)};
            }
            if (count == 4)
            {
                return new[] { c1 + _r.Next(c1), _r.Next(c1), c1 + _r.Next(c1),
                    _r.Next(c1) , c1 + _r.Next(c1),
                    _r.Next(c1), c1+ _r.Next(c1), _r.Next(c1)};
            }
            if (count == 11)
            {
                return new[] { c1 + _r.Next(c3), c1 + _r.Next(c3), c1 + _r.Next(c3),
                    _r.Next(c3) , c1 + _r.Next(c3), c1 + _r.Next(c3),
                    c1 + _r.Next(c3), c1 + _r.Next(c3), c1 + _r.Next(c3),c1 + _r.Next(c3),
                    c1 + _r.Next(c3), c1 + _r.Next(c3), c1 + _r.Next(c3),c1 + _r.Next(c3),
                    c1 + _r.Next(c3), c1 + _r.Next(c3), c1 + _r.Next(c3),c1 + _r.Next(c3),
                    c1 + _r.Next(c3), c1 + _r.Next(c3), c1 + _r.Next(c3),c1 + _r.Next(c3)};
            }
            return null;
        }
    }
}
