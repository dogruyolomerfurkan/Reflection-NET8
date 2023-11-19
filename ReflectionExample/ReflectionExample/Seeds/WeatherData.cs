using ReflectionExample.Items;

namespace ReflectionExample.Seeds;

public static class WeatherData
{
    public static readonly Weather[] Weathers = [
        new() { City = "London", Description = "Sunny spells", TemperatureCentrigrate = 19, RainfallInches = 0 },
        new() { City = "Paris", Description = "Very hot", TemperatureCentrigrate = 27, RainfallInches = 0 },
        new() { City = "New York", Description = "Heavy rain", TemperatureCentrigrate = 8, RainfallInches = 6.598 },
        new() { City = "Munich", Description = "Foggy", TemperatureCentrigrate = 12, RainfallInches = 2.134 },
        new() { City = "Istanbul", Description = "Sunshine and showers", TemperatureCentrigrate = 22, RainfallInches = 8.5 },
        new() { City = "Santiago", Description = "Strong winds", TemperatureCentrigrate = 15, RainfallInches = 0.125 }
    ];
}
