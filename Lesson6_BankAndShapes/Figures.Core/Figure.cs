using System.Drawing;

namespace Figures.Core
{
    internal abstract class Figure
    {
        public Color Color { get; set; } = new Color();
        public bool IsVisible { get; set; } = true;

        public abstract void MoveHorizontal(int offset);
        public abstract void MoveVertical(int offset);

        public abstract void ChangeColor(Color color);

        public abstract void Draw();
    }

    internal class Point : Figure
    {
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override void MoveHorizontal(int offset)
        {
        }

        public override void MoveVertical(int offset)
        {
        }

        public override void ChangeColor(Color color)
        {
        }

        public override void Draw()
        {
        }
    }

    internal sealed class Circle : Point
    {
        public double Radius { get; set; }
        public double Thickness { get; set; }
        public double Square()
        {
            return 0;
        }

        public override void Draw()
        {
            var radius = Radius;
            var thickness = Thickness;
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(Symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    internal sealed class Rectangle : Point
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double Square()
        {
            return 0;
        }

        public override void Draw()
        {
            string s = Symbol.ToString();
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += Symbol;
            }

            for (int j = 0; j < X; j++)
                temp += " ";

            s += Symbol + "\n";
            for (int i = 0; i < Height; i++)
                s += temp + Symbol + space + Symbol + "\n";

            s += temp + Symbol;
            for (int i = 0; i < Width; i++)
                s += "═";

            s += Symbol + "\n";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.CursorLeft = X;
            Console.Write(s);
            Console.ResetColor();
        }
    }
}