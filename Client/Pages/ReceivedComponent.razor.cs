using Microsoft.AspNetCore.Components;

namespace RenderingChildrenProblem.Client.Pages;
public partial class ReceivedComponent
{
    [Inject]
    private PersonService? Service { get; set; }

}