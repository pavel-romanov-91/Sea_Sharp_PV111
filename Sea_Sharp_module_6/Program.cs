namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManyFigure mf = new ManyFigure(3);
            mf.DrawFigureSide();
        }
    }

    abstract class GeometryFigure
    {
        protected int FigureSquare;
        protected int FigurePreimeter;
    }
    class Triangle : GeometryFigure
    {
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int SideLenght { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Quadro : GeometryFigure
    {
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Romb : GeometryFigure
    {
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int SideLenght { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Rectangle : GeometryFigure
    {
        public int height { get; set; }
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Paralellogramm : GeometryFigure
    {
        public int height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Trapecia : GeometryFigure
    {
        public int height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int SideLenght { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Circle : GeometryFigure
    {
        public int Radius { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    class Elipse : GeometryFigure
    {
        public int height { get; set; }
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
    }
    interface ISimpleNAngle
    {
        int height { get; set; }
        int Base { get; set; }
        int BaseSideAngle { get; set; }
        int NumberSide { get; set; }
        int SideLenght { get; set; }
        int Area { get; set; }
        int Perimeter { get; set; }
    }
    class ManyFigure : ISimpleNAngle
    {
        char[] drawchar = new char[11] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public int height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int NumberSide { get; set; }
        public int SideLenght { get; set; }
        public int Area { get; set; }
        public int Perimeter { get; set; }

        public ManyFigure(int numberSide)
        {
            NumberSide = numberSide;
            double angle = 360 / NumberSide;

        }
        public void DrawFigureSide()
        {

            for (int i = 1; i <= drawchar.Length; i += 2)
            {
                int temp = (int)Math.Floor((double)(drawchar.Length / 2) - (int)Math.Floor((double)i) / 2);
                for (int j = 0; j < i; j++)
                {
                    drawchar[temp + j] = '*';
                }
                Console.WriteLine(drawchar);
            }
        }

        double FindArea()
        {
            return Area;
        }
    }
}

