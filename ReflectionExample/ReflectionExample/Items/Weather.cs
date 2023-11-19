using ReflectionExample.Attributes;

namespace ReflectionExample.Items;

public class Weather
{
    [ReportItem(1)]
    public required string City { get; set; }

    [ReportItem(2)]
    public required string Description { get; set; }

    [ReportItem(3, Heading = "Temperature", Units = "°C")]
    public double TemperatureCentrigrate { get; set; }

    [ReportItem(4, Heading = "Rainfall", Units = " Inches", Format = "N2")]
    public double RainfallInches { get; set; }
}
