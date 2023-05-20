using Microsoft.AspNetCore.Components;

namespace RenderingChildrenProblem.Client.Pages;
public partial class Index
{
    [Inject]
    private PersonService? Service { get; set; }
    protected override void OnInitialized()
    {
        Service!.StateChanged = StateHasChanged;
    }
}