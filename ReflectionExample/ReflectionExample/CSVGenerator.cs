using ReflectionExample.Attributes;
using System.Reflection;
using System.Text;

namespace ReflectionExample;

public class CSVGenerator<T>(IEnumerable<T> dataList, string fileName) where T : class
{
    private readonly IEnumerable<T> DataList = dataList;
    private readonly string FileName = fileName;
    private readonly Type Type = typeof(T);

    public async Task GenerateAsync()
    {
        var rows = new List<string>
        {
            GenerateHeader()
        };

        foreach (T data in DataList)
        {
            rows.Add(GenerateRow(data));
        }

        await File.WriteAllLinesAsync($"{FileName}.csv", rows, Encoding.UTF8);
    }

    private string GenerateHeader()
    {

        StringBuilder sb = new();

        foreach (PropertyInfo propertyInfo in GetOrderedPropertyInfos())
        {
            ReportItemAttribute attribute = propertyInfo.GetCustomAttribute<ReportItemAttribute>()!;

            sb.Append(attribute.Heading ?? propertyInfo.Name).Append(',');
        }

        return sb.ToString()[..^1];
    }

    private string GenerateRow(T item)
    {
        StringBuilder sb = new();

        foreach (PropertyInfo propertyInfo in GetOrderedPropertyInfos())
        {
            sb.Append(CreateItem(propertyInfo, item)).Append(',');
        }

        return sb.ToString()[..^1];
    }

    private IOrderedEnumerable<PropertyInfo> GetOrderedPropertyInfos()
    {
        PropertyInfo[] properties = Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        IOrderedEnumerable<PropertyInfo> orderedPropertyInfos =
                                         properties.OrderBy(p => p.GetCustomAttribute<ReportItemAttribute>()!.ColumnOrder);
        return orderedPropertyInfos;
    }

    private static string CreateItem(PropertyInfo propertyInfo, T item)
    {
        ReportItemAttribute attribute = propertyInfo.GetCustomAttribute<ReportItemAttribute>()!;

        return string.Format($"{{0:{attribute.Format}}}{attribute.Units}", propertyInfo.GetValue(item));
    }
}
