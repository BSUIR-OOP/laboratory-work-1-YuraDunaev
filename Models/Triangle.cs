namespace OOP_LAB1.Models
{
    public class Triangle: Line
    {
        private PointGenerator _pointGenerator;
        public Triangle(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(pointCount);
        }

    }
}
