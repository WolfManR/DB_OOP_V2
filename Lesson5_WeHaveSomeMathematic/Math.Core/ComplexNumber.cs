namespace Math.Core;

public class ComplexNumber
{
    public double RealPart { get; set; }
    public double ImaginaryPart { get; set; }
    public double ImaginaryUnit { get; } = MathF.Sqrt(-1);

    public ComplexNumber() : this(0, 0) { }

    public ComplexNumber(double realPart, double imaginaryPart)
    {
        RealPart = realPart;
        ImaginaryPart = imaginaryPart;
    }

    // Описать класс комплексных чисел.
    // Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел.
    // Переопределить метод ToString() для комплексного числа.
    // Протестировать на простом примере.


    public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
    {
        return new ComplexNumber(left.RealPart - right.RealPart, left.ImaginaryPart - right.ImaginaryPart);
    }
    public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)//(a + bi)(c + di) =(ac - bd) + (bc + ad)i.
    {
        return new ComplexNumber
        (
            left.RealPart * right.RealPart - left.ImaginaryPart * right.ImaginaryPart,
            left.ImaginaryPart * right.RealPart + left.RealPart * right.ImaginaryPart
        );
    }

    public override string ToString()
    {
        return (ImaginaryPart < 0) ? $"{RealPart}{ImaginaryPart}i" : $"{RealPart}+{ImaginaryPart}i";
    }
}