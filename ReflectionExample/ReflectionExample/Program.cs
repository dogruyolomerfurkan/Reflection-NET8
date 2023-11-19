using ReflectionExample;
using ReflectionExample.Items;
using ReflectionExample.Seeds;

Task t1 = new CSVGenerator<Book>(BookData.Books, "Books").GenerateAsync();
Task t2 = new CSVGenerator<Weather>(WeatherData.Weathers, "Weathers").GenerateAsync();

await Task.WhenAll(t1, t2);