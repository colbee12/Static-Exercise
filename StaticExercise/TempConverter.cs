namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double fTemp)
    {
        return (fTemp - 32) * 5 / 9;
    }
    
    public static double CelsiusTOFahrenheit(double cTemp)
    {
        return (cTemp * 9) / 5 + 32;
    }
    
    
    
    
    
}