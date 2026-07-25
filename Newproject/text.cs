namespace NewProject;

public class Mentor
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public Mentor(string name, int age, string description)
    {
        Name = name;
        Age = age;
        Description = description;
    }

}