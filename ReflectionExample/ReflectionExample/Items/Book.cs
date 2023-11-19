using ReflectionExample.Attributes;

namespace ReflectionExample.Items;

public class Book
{
    [ReportItem(2)]
    public required string Author { get; set; }

    [ReportItem(1)]
    public required string Title { get; set; }

    [ReportItem(3, Format = "dd-MM-yyyy", Heading = "Date of Publication")]
    public DateOnly DateOfPublication { get; set; }

    [ReportItem(4)]
    public Rating Rating { get; set; }
}

public enum Rating { Rubbish, Poor, Average, Good, Excellent }

