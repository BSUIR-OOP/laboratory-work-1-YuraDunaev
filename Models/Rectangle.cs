namespace OOP_LAB1.Models
{
    public class Rectangle: Line
    {
        private PointGenerator _pointGenerator;
        public Rectangle(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(2);
        }
    }
}
