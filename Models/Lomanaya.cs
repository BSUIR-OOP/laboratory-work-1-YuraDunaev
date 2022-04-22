namespace OOP_LAB1.Models
{
    public class MultiLine: Line 
    {
        private PointGenerator _pointGenerator;

        public MultiLine(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(pointCount);
        }
    }
}
