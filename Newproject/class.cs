namespace NewProject;

public record class Parson
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Parson(string name, int age)
    {
        Name = name;
        Age = age;
    }
}