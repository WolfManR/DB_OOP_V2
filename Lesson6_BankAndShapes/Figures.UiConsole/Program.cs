using static System.Console;

List<Figure> figures = new()
{

};

figures
    .PrintFigures()
    .MoveFigures(6,0).PrintFigures()
    ;


static class Extensions
{
    public static IEnumerable<Figure> PrintFigures(this IEnumerable<Figure> figures)
    {
        foreach (var figure in figures)
        {
            yield return figure;
        }
    }

    public static IEnumerable<Figure> MoveFigures(this IEnumerable<Figure> figures, int horizontalOffset, int verticalOffset)
    {
        foreach (var figure in figures)
        {
            yield return figure;
        }
    }
}    