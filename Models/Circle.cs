namespace OOP_LAB1.Models
{
    public class Circle: Line
    {
        private PointGenerator _pointGenerator;

        public Circle(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(1);
        }
    }
}
