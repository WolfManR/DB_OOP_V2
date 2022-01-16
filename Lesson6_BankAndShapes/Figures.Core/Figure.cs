namespace Figures.Core
{
    internal abstract class Figure
    {
        public Color Color { get; set; } = new Color();
        public bool IsVisible { get; set; } = true;

        public abstract void MoveHorizontal(int offset);
        public abstract void MoveVertical(int offset);

        public abstract void ChangeColor(Color color);
    }

    internal class Point : Figure
    {
        public override void MoveHorizontal(int offset)
        {
        }

        public override void MoveVertical(int offset)
        {
        }

        public override void ChangeColor(Color color)
        {
        }
    }

    internal sealed class Circle : Point
    {
        public double Square()
        {
            return 0;
        }
    }

    internal sealed class Rectangle : Point
    {
        public double Square()
        {
            return 0;
        }
    }
}