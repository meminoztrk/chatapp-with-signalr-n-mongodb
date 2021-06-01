using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace chatApp.Hubs
{
    public class MyHub : Hub
    {
        public async Task AddToGroup(string geciciChatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, geciciChatId);
        }
        public Task LeaveToGroup(string geciciChatId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, geciciChatId);
        }
        public async Task SendMessageAsync(string adisoyadi,string userid, string mesaj, string geciciChatId)
        {
            // await Clients.All.SendAsync("receiveMessage",adisoyadi,userid, mesaj);
            await Clients.Group(geciciChatId).SendAsync("receiveMessage",adisoyadi,userid, mesaj);


        }
    }
}