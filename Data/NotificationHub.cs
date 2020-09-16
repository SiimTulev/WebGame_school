using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGame.Models.WebGame;
using WebGame.ViewModel;

namespace WebGame.Data
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(bool notification, string connectionId, string enemyNotification, string clickerNotification, bool readyClicked, List<TowerViewModel> towerz)
        {
            await Clients.All.SendAsync("ReceiveMessage", notification, connectionId, enemyNotification, clickerNotification, readyClicked, towerz);
        }

        public async Task SendOverallStats(OverallStatsModel overallStats, string connectionId)
        {
            await Clients.All.SendAsync("ReceiveOverallStats", overallStats, connectionId);
        }
    }
}
