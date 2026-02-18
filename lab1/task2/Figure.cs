namespace lab1
{
    class Figure
    {
        private double _square;

        public Figure(double num, TypeFigure typeFigure)
        {
            if(typeFigure == TypeFigure.Circle)
            {
              _square = squareCircle(num);
            }
            if(typeFigure == TypeFigure.Square)
            {
              _square = squareSquare(num);
            }
        }

        public Figure(double num1, double num2, TypeFigure typeFigure)
        {
            if(typeFigure == TypeFigure.Rectangle)
            {
              _square = squareRectangle(num1, num2);
            }
            if(typeFigure == TypeFigure.Triangle)
            {
              _square = squareTriangle(num1, num2);
            }
            if(typeFigure == TypeFigure.Parallelogram)
            {
              _square = squareParallelogram(num1, num2);
            }
            if(typeFigure == TypeFigure.Rhombus)
            {
              _square = squareRhombus(num1, num2);
            }
        }

        public Figure(double num1, double num2, double num3, TypeFigure typeFigure)
        {
            if(typeFigure == TypeFigure.Trapezoid)
            {
              _square = squareTrapezoid(num1, num2, num3);
            }
        }

        private double squareCircle(double radius)
        {            
            return Math.PI * radius * radius;
        }

        private double squareSquare(double side)
        {            
            return side * side;
        }

        private double squareRectangle(double side1, double side2)
        {            
            return side1 * side2;
        }

        private double squareTriangle(double baseSide, double height)
        {            
            return baseSide * height / 2;
        }

        private double squareParallelogram(double baseSide, double height)
        {            
            return baseSide * height;
        }

        private double squareRhombus(double diagonal1, double diagonal2)
        {            
            return diagonal1 * diagonal2 / 2;
        }

        private double squareTrapezoid(double baseSide1, double baseSide2, double height)
        {            
            return (baseSide1 + baseSide2) * height / 2;
        }

        public double Square
        {
            get { return _square; }
        }
    }
}