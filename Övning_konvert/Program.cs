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
            //    Console.WriteLine("Bra");
            //}
            //else
            //{
            //    Console.WriteLine("Fel inmatning");
            //}



            // Ö3 Tärningskastare
            //string choice = "";

            //while (choice != "q")
            //{
            //    Random number1 = new Random();
            //    int number2 = number1.Next(1, 6);
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
            //        '/' => number1 / number2,
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
            //int randomNumber = number1.Next(1, 100);
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



            //// Ö7 var vs dynamic. This is one program, please uncomment the full code before running.
            //// VAR: var is decided at compile time and cannot change thereafter. If an int is declared it will forever be an int in the program.
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


        }
    }
}
