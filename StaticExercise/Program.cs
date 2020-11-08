using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the temp you wish to convert from Fahrenheit to Celsius.");
            double numOne = double.Parse(Console.ReadLine());

            double cel = TempConverter.FahrenheitToCelsius(numOne);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Celsius :  {cel, 0:N2}");
            Console.ResetColor();

            Console.WriteLine("Please give me a temp you wish to convert from Celsius to Fahrenheit");
            double numTwo = double.Parse(Console.ReadLine());


            double fahrenheit = TempConverter.CelsiusToFahren(numTwo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Fahrenheit : {fahrenheit,0:N2}");
            Console.ResetColor();

        }
    }
}
