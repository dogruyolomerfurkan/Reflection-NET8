using ReflectionExample.Items;

namespace ReflectionExample.Seeds;

public static class BookData
{
    public static readonly Book[] Books = [
        new() { Title = "Goldfinger", Author = "Ian Fleming", DateOfPublication = new DateOnly(1959, 3, 23), Rating = Rating.Excellent },
        new() { Title = "Dr No", Author = "Ian Fleming", DateOfPublication = new DateOnly(1958, 3, 31), Rating = Rating.Good },
        new() { Title = "Live and Let Die", Author = "Ian Fleming", DateOfPublication = new DateOnly(1954, 4, 5), Rating = Rating.Average },
        new() { Title = "Emma", Author = "Jane Austen", DateOfPublication = new DateOnly(1815, 12, 23), Rating = Rating.Good },
        new() { Title = "Persuasion", Author = "Jane Austen", DateOfPublication = new DateOnly(1818, 1, 1), Rating = Rating.Excellent },
        new() { Title = "Great Expectations", Author = "Charles Dickens", DateOfPublication = new DateOnly(1861, 1, 1), Rating = Rating.Excellent },
        new() { Title = "Oliver Twist", Author = "Charles Dickens", DateOfPublication = new DateOnly(1838, 1, 1), Rating = Rating.Average }
        ];
}
