namespace Buildings.Core;

public class Building
{
    private readonly Guid _id;
    private double _height;
    private int _numberOfStoreys;
    private int _countOfEntrances;
    private int _countOfApartments;

    public Building()
    {
        _id = Guid.NewGuid();
    }

    public Guid Id => _id;

    public double Height { get => _height; set => _height = value; }
    public int NumberOfStoreys { get => _numberOfStoreys; set => _numberOfStoreys = value; }
    public int CountOfEntrances { get => _countOfEntrances; set => _countOfEntrances = value; }
    public int CountOfApartments { get => _countOfApartments; set => _countOfApartments = value; }

    public double CalculateHeightOfStorey() => Height / NumberOfStoreys;
    public double CalculateNumberOfApartmentsInEntrace() => (double)CountOfApartments / CountOfEntrances;
    public double CalculateNumberOfApartmentsOnStorey() => (double)CountOfApartments / NumberOfStoreys;
}