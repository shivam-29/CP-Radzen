using Microsoft.AspNetCore.Components;
using Radzen.Blazor;

namespace CP.Client.Shared;

public partial class MainLayout : LayoutComponentBase
{
    protected RadzenBody body0;
    protected RadzenSidebar sidebar0;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    protected async Task SidebarToggle0Click(dynamic args)
    {
        await InvokeAsync(() => { sidebar0.Toggle(); });

        await InvokeAsync(() => { body0.Toggle(); });
    }
}
