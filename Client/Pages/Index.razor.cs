namespace RenderingChildrenProblem.Client.Pages;
public partial class Index
{
    [Inject]
    private PersonService? Service { get; set; }

    private List<Person> _people = new();

    protected override void OnInitialized()
    {
        Service!.StateChanged = UpdateState;
        Reset();
        
    }

    void UpdateState()
    {
        StateHasChanged();
    }
    void SampleChange()
    {
        Service!.Person.FirstName = "Changed";
        Service!.Person.LastName = "Walter";
        StateHasChanged();
    }
    void Reset()
    {
        _people.Add(new Person()
        {
            LastName = "Perry",
            FirstName = "Kim"
        });
        _people.Add(new Person()
        {
            LastName = "Clark",
            FirstName = "John"
        });
    }

    void Clear()
    {
        _people.Clear();
    }

}