using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks saperated by space (Then press enter to submit): ");
        var input = Console.ReadLine();

        // check if the input is null or empty
        if(string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No marks entered.");
            return;
        } 

        var marks = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var mark in marks)
        {
            if (int.TryParse(mark, out int score))
            {

                var grade = GetGrade(score);
                Console.WriteLine($"Mark: {score}, Grade: {grade}");
            }
            else
                Console.WriteLine($"Invalid input: {mark}");

        }
    }

    static string GetGrade(int score)
    {
        return score switch
        {
          > 100 or < 0 => "Invalid Score",  
          >= 90 => "A",
          >= 80 => "B",
          >= 70 => "C",  
          >= 60 => "D",
          _   => "F"
        };
    }
}