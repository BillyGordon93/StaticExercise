using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        //static classes can only contain static numbers
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            //what is my goal here?
            //do some math to convert fahrenheit to celsius
            return (fahrenheit - 32) / 1.8;//this conversion will return a double

        }
        public static double CelsiusToFahren(double celsius)
        {
            //whats my goal here?
            //convert celsius tofahrenheit
            return (celsius * 9) / 5 + 32;

        }
    }
}
