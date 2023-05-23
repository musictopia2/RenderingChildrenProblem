namespace RenderingChildrenProblem.Client;
public class PersonService
{
    public Person Person = new ();
    public Action? StateChanged { get; set; }
    public bool Received { get; private set; }
    //good news is it somehow worked without that update (encouraging).
    //this is a good template for me.

    //public void UpdatePerson(string firstName, string lastName)
    //{
    //    Person = new Person()
    //    {
    //        FirstName = firstName,
    //        LastName = lastName
    //    };
    //    StateChanged?.Invoke();
    //}

    public void Process()
    {
        Received = true;
        StateChanged?.Invoke();
    }

    public void Reset()
    {
        Person = new(); //so will be reset again.
        Received = false;
        StateChanged?.Invoke();
    }
}

public class Person
{
    public string FirstName { get; set; } = "Brendan";
    public string LastName { get; set; } = "Ashby";
}

//public record Person
//{
//    public string FirstName { get; set; } = "Brendan";
//    public string LastName { get; set; } = "Ashby";
//}