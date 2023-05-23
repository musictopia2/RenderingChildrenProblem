using Microsoft.AspNetCore.Components;

namespace RenderingChildrenProblem.Client.Pages;
public partial class Index
{
    [Inject]
    private PersonService? Service { get; set; }
    protected override void OnInitialized()
    {
        Service!.StateChanged = UpdateState;
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
}