namespace MathByDates;
public static class DateHelper
{
    private static readonly int _daysToAdd = Random.Shared.Next(20, 51);

    public static void RunProgram()
    {
        Console.WriteLine($"The Target Number of days is: {_daysToAdd} days.");
        DateOnly firstDate = ParseInputToDateOnly(GetUserInput(true), true);
        DateOnly secondDate = ParseInputToDateOnly(GetUserInput(false), false);

        int userGuess = SumTotalDays(firstDate, secondDate);
        DetermineResult(_daysToAdd, userGuess);
    }

    private static void DetermineResult(int daysToAdd, int userGuess)
    {
        string result = Math.Abs(userGuess - daysToAdd) <= 5 ? "You Won!" : "You Lost!";

        Console.WriteLine($"{result} The Target was: {_daysToAdd} days. Your Guess was: {userGuess} days.");
    }

    private static string GetUserInput(bool first)
    {
        Console.Write($"Enter the {(first ? "first" : "second")} date (MM/DD/YY): ");
        var output = Console.ReadLine();
        return output;
    }

    private static DateOnly ParseInputToDateOnly(string input, bool first)
    {
        bool validDate;
        DateOnly output;

        do
        {
            validDate = DateOnly.TryParse(input, out output);

            if (validDate == false)
            {
                Console.WriteLine($"\"{input}\" was not a valid date format. ex: \"MM/DD/YY\"");
                Console.WriteLine();
                input = GetUserInput(first);
            } 
        } while (validDate == false);

        return output;
    }

    private static int SumTotalDays(DateOnly firstDate, DateOnly secondDate)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        int totalDays = ( firstDate.DayNumber - today.DayNumber ) + ( secondDate.DayNumber - today.DayNumber );

        return totalDays;
    }
        
}
