namespace OOP_LAB1.Models
{
    public class Line: Figure
    {
        private PointGenerator _pointGenerator;

        public Line(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(pointCount);
        }
    }
}
