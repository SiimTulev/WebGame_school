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
#line 5 "C:\Lõputöö\Kood\WebGame_school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using WebGame.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using WebGame.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using WebGame.Models.WebGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
using WebGame.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game/MainGameRazor/{error}/{player1Id}/{player2Id}/{worldId}/{accountCheck}")]
    public partial class MainGameRazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 215 "C:\Lõputöö\Kood\WebGame_school\Components\MainGameRazor.razor"
       
    private HubConnection _hubConnection;

    bool _notification = false;
    string _connectionId = "";
    string _enemy = "";
    string _you = "";

    public List<TowerViewModel> towerView;
    bool _readyClicked = false;

    public List<TowerViewModel> world;

    protected override async Task OnInitializedAsync()
    {
        _hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/notificationHub"))
        .Build();
        if (_hubConnection.ConnectionId != null) _connectionId = _hubConnection.ConnectionId;
        _notification = false;
        _readyClicked = false;

        _hubConnection.On<bool, string, string, string, bool, List<TowerViewModel>>("ReceiveMessage", async (notification, connectionId,
        enemyNotification, clickerNotification, readyClicked, towerz) =>
        {
            towerView = towerz;

            _notification = notification;
            _connectionId = connectionId;

            _enemy = enemyNotification;
            _you = clickerNotification;

            _readyClicked = readyClicked;
            StateHasChanged(); // Saada teistele kasutajatele sellele URL'ile uuendus, kus nad praegu asuvad
    });
        towerView = await MainGame.MainGame(Player1Id, Player2Id, WorldId, 0);

        await _hubConnection.StartAsync();
    }

    private async Task Ready(int worldId, int playerId)
    {

        var towerz = await MainGame.PlayerReady(WorldId, playerId);

        var overallStats = await _OverallStats.GetOverallStats(worldId, towerz[0].Player1Id, towerz[0].Player2Id); // Järjekord on tähtis. WorldId esimesena jne.

        _hubConnection.SendAsync("SendOverallStats", overallStats, _hubConnection.ConnectionId);

        if (towerz[0].Player1Ready == false && towerz[0].Player2Ready == false)
        {
            _hubConnection.SendAsync("SendNotification", true, _hubConnection.ConnectionId, "ENEMY IS NOT READY", "YOU ARE NOT READY", true, towerz);
        }
        else if (towerz[0].Player1Id == playerId && towerz[0].Player1Ready == true && towerz[0].Player2Ready == false)
        {
            _hubConnection.SendAsync("SendNotification", true, _hubConnection.ConnectionId, "ENEMY IS NOT READY", "YOU ARE READY", true, towerz);
        }
        else if (towerz[0].Player1Id == playerId && towerz[0].Player1Ready == false && towerz[0].Player2Ready == true)
        {
            _hubConnection.SendAsync("SendNotification", true, _hubConnection.ConnectionId, "ENEMY IS READY", "YOU ARE NOT READY", true, towerz);
        }

        else if (towerz[0].Player2Id == playerId && towerz[0].Player1Ready == false && towerz[0].Player2Ready == true)
        {
            _hubConnection.SendAsync("SendNotification", true, _hubConnection.ConnectionId, "ENEMY IS NOT READY", "YOU ARE READY", true, towerz);
        }
        else if (towerz[0].Player2Id == playerId && towerz[0].Player1Ready == true && towerz[0].Player2Ready == false)
        {
            _hubConnection.SendAsync("SendNotification", true, _hubConnection.ConnectionId, "ENEMY IS READY", "YOU ARE NOT READY", true, towerz);
        }
    }

    public bool IsConnected =>
    _hubConnection.State == HubConnectionState.Connected;

    private int towerLvl;
    private int defence;
    private int costs;

    private int towerId;
    private int owner;
    private int player1Id;
    private int player2Id;
    private int worldId;

    private int nxtTowerLvl;
    private int nxtDefence;

    private int? attack;

    private string x;
    private string y;
    public bool showMessage2Activated = false;

    private int whoOwnsTower = 0; // 0 = neutral, 1 = Friendly, 2 = Enemy

    private void Enemy(MouseEventArgs e,
    int TowerId, int Owner, int Player1Id, int Player2Id, int WorldId)
    {
        whoOwnsTower = 2;

        x = Convert.ToString(e.ClientX + 5) + "px";
        y = Convert.ToString(e.ClientY + 5) + "px";

        towerId = TowerId;
        owner = Owner;
        player1Id = Player1Id;
        player2Id = Player2Id;
        worldId = WorldId;
        // LoggedInAccountId
        showMessage2Activated = true;
    }

    private void CloseMessage2(MouseEventArgs e, bool closed)
    {
        showMessage2Activated = false;
    }

    private void Friendly(MouseEventArgs e,
    int TowerLvl, int Defence, int Costs, int TowerId, int Owner, int Player1Id, int Player2Id, int WorldId, int NxtTowerLvl, int NxtDefence, int? Attack)
    {
        whoOwnsTower = 1;

        x = Convert.ToString(e.ClientX + 5) + "px";
        y = Convert.ToString(e.ClientY + 5) + "px";
        towerLvl = TowerLvl;
        defence = Defence;
        costs = Costs;

        towerId = TowerId;
        owner = Owner;
        player1Id = Player1Id;
        player2Id = Player2Id;
        worldId = WorldId;
        // LoggedInAccountId
        attack = Attack;

        nxtTowerLvl = NxtTowerLvl;
        nxtDefence = NxtDefence;

        showMessage2Activated = true;
    }

    [Parameter]
    public int WorldId { get; set; }
    [Parameter]
    public int Player1Id { get; set; }
    [Parameter]
    public int Player2Id { get; set; }
    [Parameter]
    public int YourId { get; set; }
    [Parameter]
    public string YourName { get; set; }
    [Parameter]
    public int EnemyId { get; set; }
    [Parameter]
    public string EnemyName { get; set; }
    [Parameter]
    public string Winner { get; set; }
    [Parameter]
    public bool IsWinner { get; set; }
    [Parameter]
    public string you { get; set; }
    [Parameter]
    public string enemy { get; set; }
    [Parameter]
    public List<WebGame.ViewModel.TowerViewModel>
    towers
    { get; set; }
    [Parameter]
    public string error { get; set; }
    [Parameter]
    public int playerIdWhoClicks { get; set; }
    [Parameter]
    public int loggedInAccountId { get; set; }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OverallStatsLogic _OverallStats { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<webgameContext> DbContextOptions { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MainGameLogic MainGame { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OverallStatsLogic OverallStats { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
