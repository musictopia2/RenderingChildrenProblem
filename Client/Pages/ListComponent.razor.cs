
namespace RenderingChildrenProblem.Client.Pages;
public partial class ListComponent
{
    [Parameter]
    public List<Person> People { get; set; } = new();
}