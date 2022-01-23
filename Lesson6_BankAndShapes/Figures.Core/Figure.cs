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
            X += offset;
        }

        public override void MoveVertical(int offset)
        {
            Y += offset;
        }

        public override void ChangeColor(Color color)
        {
            Color = color;
        }

        public override void Draw()
        {
            PrintAndReset(() =>
            {
                Console.SetCursorPosition(X, Y);
                Console.ForegroundColor = Color.ToConsoleColor();
                Console.Write(Symbol);
            });
        }

        protected virtual void PrintAndReset(Action draw)
        {
            var defaultColor = Console.ForegroundColor;
            var (left, top) = Console.GetCursorPosition();
            draw.Invoke();
            Console.ForegroundColor = defaultColor;
            Console.SetCursorPosition(left, top);
        }
    }

    internal sealed class Circle : Point
    {
        private IEnumerable<Point> Paint { get; }

        public double Radius { get; set; }
        public double Thickness { get; set; }
        public double Square()
        {
            return Math.PI * Radius * 2;
        }

        public override void Draw()
        {
            PrintAndReset(() =>
            {
                var radius = Radius;
                var thickness = Thickness;
                double rIn = radius - thickness;
                double rOut = radius + thickness;
                double doubleRIn = rIn * rIn;
                double doubleROut = rOut * rOut;

                var posX = X;
                var posY = Y;
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = Color.ToConsoleColor();

                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= doubleRIn && value <= doubleROut)
                        {
                            Console.Write(Symbol);
                        }
                        else
                        {
                            Console.CursorLeft++;
                        }
                    }
                    Console.SetCursorPosition(posX, ++posY);
                }
            });
        }
    }

    internal sealed class Rectangle : Point
    {
        private IEnumerable<Point> Paint { get; }

        public int Width { get; set; }
        public int Height { get; set; }

        public double Square()
        {
            return Width * Height;
        }

        public override void Draw()
        {
            PrintAndReset(() =>
            {
                var posX = X;
                var posY = Y;
                var symbol = Symbol;

                var farBorderPosX = posX + Width;

                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = Color.ToConsoleColor();

                for (int i = 0; i < Width; i++)
                {
                    Console.Write(symbol);
                }

                for (var i = 0; i < Height - 2; i++)
                {
                    Console.SetCursorPosition(posX, ++posY);
                    Console.Write(symbol);
                    Console.SetCursorPosition(farBorderPosX, posY);
                    Console.Write(symbol);
                }

                Console.SetCursorPosition(posX, ++posY);

                for (int i = 0; i < Width; i++)
                {
                    Console.Write(symbol);
                }
            });
        }
    }
}