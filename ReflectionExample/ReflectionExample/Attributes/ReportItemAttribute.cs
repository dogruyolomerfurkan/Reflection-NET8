namespace ReflectionExample.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ReportItemAttribute(int columnOrder) : Attribute
{
    public string? Heading { get; set; }
    public string? Units { get; set; }
    public string? Format { get; set; }
    public int ColumnOrder { get; } = columnOrder;
}
