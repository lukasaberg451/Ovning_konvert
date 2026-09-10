using System.Globalization;

namespace Övning_konvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nivå 1
            // Ö1 Temperaturomvandlare
            //double temp;

            //Console.WriteLine("Skriv in temperaturen");
            //temp = double.Parse(Console.ReadLine());

            //double fahrenheit = temp * 9 / 5 + 32;

            //Console.WriteLine(fahrenheit);



            // Ö2 Säker inmatning
            //int number;

            //Console.WriteLine("Mata in ett heltal");
            //bool isConverted = int.TryParse(Console.ReadLine(), out number);

            //if (isConverted)
            //{
            //    Console.WriteLine($"Du skrev in: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Fel inmatning");
            //}



            // Ö3 Tärningskastare
            //string choice = "";
            //Random number1 = new Random();

            //while (choice != "q")
            //{
            //    int number2 = number1.Next(1, 7);
            //    Console.WriteLine(number2);
            //    Console.WriteLine("Tryck enter för att slå igen och skriv q för att avsluta!");
            //    choice = Console.ReadLine();
            //}



            // Nivå 2
            // Ö5 Miniräknare med felhantering
            //try
            //{
            //    Console.WriteLine("Skriv första numret!");
            //    double number1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Skriv andra numret!");
            //    double number2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Skriv ett räknesätt!");
            //    char op = char.Parse(Console.ReadLine());

            //    double result = op switch
            //    {
            //        '+' => number1 + number2,
            //        '-' => number1 - number2,
            //        '*' => number1 * number2,
            //        '/' => number2 != 0 ? number1 / number2 : throw new DivideByZeroException("Kan inte dividera med noll"),
            //        _ => throw new Exception("Okänt räknesätt")
            //    };
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            // Ö6 Gissa talet
            //Random number1 = new Random();
            //int randomNumber = number1.Next(1, 101);
            //int userGuess = 0;
            //int attemps = 0;

            //while (userGuess != randomNumber)
            //{
            //    Console.WriteLine("Gissa ett nummer mellan 1 och 100");
            //    userGuess = int.Parse(Console.ReadLine());
            //    if (userGuess > randomNumber)
            //    {
            //        Console.WriteLine("Lägre");
            //    }
            //    else if (userGuess < randomNumber)
            //    {
            //        Console.WriteLine("Högre");
            //    }
            //    attemps++;
            //}
            //Console.WriteLine($"Du gissade rätt på {attemps} försök!");



            // Ö7 var vs dynamic. This is one program, please uncomment the full code before running.
            // VAR: Type is decided at compile time and cannot change thereafter. If an int is declared it will forever be an int in the program.
            //var varName = "Lukas";
            //var varAge = 27;
            //var varNumber = 19.99;

            //// DYNAMIC: It is not decided on compile time, it is decided on runtime. Since its not being checked on compile time it can have errors but it will only be shown when the program is running.
            //dynamic dynamicName = "Aberg";
            //dynamic dynamicAge = 37;
            //dynamic dynamicNumber = 29.99;

            //Console.WriteLine($"Var: {varName}, {varAge}, {varNumber}");
            //Console.WriteLine($"Dynamic: {dynamicName}, {dynamicAge}, {dynamicNumber}");

            //// Changing the dynamicName variable value from string to int
            //dynamicName = 27;
            //Console.WriteLine($"Ditt namn är nu din ålder: {dynamicName} :)");

            ////Runtime error, cant multiply a string by 5.
            //try
            //{
            //    dynamic number = "Hej";
            //    int result = number * 5; // Here
            //    Console.WriteLine(result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// Fix the error
            //dynamic number2 = 10; // Give the dynamic variable type int
            //int result2 = number2 * 5; // int can be multiplied by 5
            //Console.WriteLine(result2);



            // Nivå 3
            // Ö9 Robust registreringssystem
            //try
            //{
            //    // Collect name
            //    Console.WriteLine("vad heter du?");
            //    string name = Console.ReadLine();

            //    // Collect age and validate it
            //    Console.WriteLine("Hur gammal är du?");
            //    if (!int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        Console.WriteLine("Ogiltig ålder, skriv ett heltal");
            //        return;
            //    }
            //    if (age < 0 || age > 120)
            //    {
            //        throw new InvalidAgeException("Ålders måste vara mellan 0 och 120");
            //    }

            //    // Collect salary and validate it
            //    Console.WriteLine("Vad är din lön?");
            //    if (!double.TryParse(Console.ReadLine(), out double salary))
            //    {
            //        Console.WriteLine("Ogiltig lön, skriv ett tal");
            //        return;
            //    }

            //    // Write the info back to the user
            //    Console.WriteLine($"Dina uppgifter: {name}, {age}, {salary}");
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            // Ö10 Slumpgenererat quiz
            //    Random randomNumber = new Random();
            //    int correctAnswers = 0;


            //    for (int i = 0; i < 5; i++)
            //    {
            //        int a = randomNumber.Next(1, 11);
            //        int b = randomNumber.Next(1, 11);
            //        int correctAnswer = a * b;

            //        Console.WriteLine($"Fråga {i + 1}: Vad är {a} * {b}?");

            //        if (!int.TryParse(Console.ReadLine(), out int userAnswer))
            //        {
            //            Console.WriteLine("Fel, ogiltig inmatning");
            //            continue;
            //        }

            //        if (userAnswer == correctAnswer)
            //        {
            //            correctAnswers++;
            //            Console.WriteLine("Rätt");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Fel, rätt svar var {correctAnswer}");
            //        }
            //    }

            //    Console.WriteLine($"Du fick {correctAnswers} av 5 rätt");

            // Ö12 Felsökningsutmaning
            // I do not see any issues here. Its hard to know what to look for when you dont explain what the goal of the code is.
            // There is no errors or warning, and it is running fine.
            //int[] tal = { 5, 10, 15, 20 };
            //int summa = 0;
            //for (int i = 0; i < tal.Length; i++)
            //    summa += tal[i];
            //double medel = (double)summa / tal.Length;
            //Console.WriteLine($"Medel: {medel}");
        }
    }
    // Method for a custom exception for Ö9
    public class InvalidAgeException : Exception 
    {
        public InvalidAgeException(string message) : base(message) {}
    } 
}
