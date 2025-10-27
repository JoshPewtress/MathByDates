using MathByDates;

Console.WriteLine(
    """
    Math by Dates -- A C# date guessing game
    You will be shown a target number of days
    You will guess two dates and the amount of days from today to your guesses will be totalled.
    If the total number of days for your guesses are within 5 of the target, You Win!

    """);

DateHelper.RunProgram();
Console.ReadLine();