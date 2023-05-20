namespace RenderingChildrenProblem.Client;
public class PersonService
{
    public PersonService()
    {
        FirstName = "Brendan";
        LastName = "Ashby";
    }
    public Action? StateChanged { get; set; }
    public string FirstName { get; private set; } = "";
    public string LastName { get; private set; } = "";
    public bool Received { get; private set; }
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