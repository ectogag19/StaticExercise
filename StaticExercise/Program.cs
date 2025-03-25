namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FarenheitToCelsius(68); //20
            
            Console.WriteLine($"Celsius: {celcius}");

            var farenheit = TempConverter.CelsiusToFarenheit(20); //68
            
            Console.WriteLine($"Farenheit: {farenheit}");

        }
    }
}
