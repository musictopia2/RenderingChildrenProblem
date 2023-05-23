namespace RenderingChildrenProblem.Client;

public class PersonService
{
    public Person Person = new Person();
    public Action? StateChanged { get; set; }
    public bool Received { get; private set; }

    public void UpdatePerson(string firstName, string lastName)
    {
        Person = new Person()
        {
            FirstName = firstName,
            LastName = lastName
        };
        StateChanged?.Invoke();
    }

    public void Process()
    {
        Received = true;
        StateChanged?.Invoke();
    }

    public void Reset()
    {
        Received = false;
        StateChanged?.Invoke();
    }
}

public record Person
{
    public string FirstName { get; set; } = "Brendan";
    public string LastName { get; set; } = "Ashby";
}