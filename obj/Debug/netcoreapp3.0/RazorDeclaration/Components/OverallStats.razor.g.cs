#pragma checksum "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaca677e1bc9b9c8cccbf987515f1df4d5fb8678"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebGame.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 5 "C:\C#\CleanCode\WebGame_school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor"
using WebGame.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OverallStats")]
    public partial class OverallStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\C#\CleanCode\WebGame_school\Components\OverallStats.razor"
      

    string _connectionId = "";
    private HubConnection _hubConnection;

    private OverallStatsModel overallStats;
    private OverallStatsSingleModel overallStatsSingle;

    protected override async Task OnInitializedAsync()
    {
        _hubConnection = new HubConnectionBuilder()
       .WithUrl(NavigationManager.ToAbsoluteUri("/notificationHub"))
       .Build();

        overallStatsSingle = await _OverallStats.GetOverallStatsSingle(worldId, playerId); // queue matters. WorldId first, etc.


        _hubConnection.On<OverallStatsModel, string>("ReceiveOverallStats", async (_overallStats, connectionId) =>
        {
            _connectionId = connectionId;
            overallStats = _overallStats;
            StateHasChanged();

        });



        await _hubConnection.StartAsync();
    }

    public bool IsConnected =>
_hubConnection.State == HubConnectionState.Connected;



    [Parameter]
    public int worldId { get; set; }
    [Parameter]
    public int playerId { get; set; }

    [Parameter]
    public int PeopleNow { get; set; }

    [Parameter]
    public int PeopleGrowing { get; set; }

    [Parameter]
    public int SoonReturning { get; set; }

    [Parameter]
    public int FindPlayerGold { get; set; }

    [Parameter]
    public int goldForTowers { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OverallStatsLogic _OverallStats { get; set; }
    }
}
#pragma warning restore 1591
