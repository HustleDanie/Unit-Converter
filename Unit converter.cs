using System;

class Program {
    static void Main() {
        Console.WriteLine("Welcome to the Unit Converter!");
        Console.WriteLine("1. Convert Celsius to Fahrenheit");
        Console.WriteLine("2. Convert Fahrenheit to Celsius");
        Console.WriteLine("3. Convert Meters to Feet");
        Console.WriteLine("4. Convert Feet to Meters");
        Console.WriteLine("Please enter your choice (1-4):");

        int choice = int.Parse(Console.ReadLine());

        switch (choice) {
            case 1:
                Console.WriteLine("Enter temperature in Celsius:");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
                break;
            case 2:
                Console.WriteLine("Enter temperature in Fahrenheit:");
                fahrenheit = double.Parse(Console.ReadLine());
                celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C.");
                break;
            case 3:
                Console.WriteLine("Enter distance in meters:");
                double meters = double.Parse(Console.ReadLine());
                double feet = MetersToFeet(meters);
                Console.WriteLine($"{meters}m is equal to {feet}ft.");
                break;
            case 4:
                Console.WriteLine("Enter distance in feet:");
                feet = double.Parse(Console.ReadLine());
                meters = FeetToMeters(feet);
                Console.WriteLine($"{feet}ft is equal to {meters}m.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }

    static double CelsiusToFahrenheit(double celsius) {
        return (celsius * 9/5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit) {
        return (fahrenheit - 32) * 5/9;
    }

    static double MetersToFeet(double meters) {
        return meters * 3.28084;
    }

    static double FeetToMeters(double feet) {
        return feet / 3.28084;
    }
}
