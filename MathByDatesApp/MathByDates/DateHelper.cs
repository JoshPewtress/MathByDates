namespace MathByDates;
public static class DateHelper
{
    private static readonly DateOnly _firstDate = new();
    private static readonly DateOnly _secondDate = new();
    private static readonly int _daysToAdd = Random.Shared.Next(20, 51);
}
