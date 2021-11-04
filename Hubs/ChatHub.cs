using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using SignalRExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Clients.Client(Context.ConnectionId).SendAsync("ReceiveConnectionID", Context.ConnectionId);
            return base.OnConnectedAsync();
        }
        public async Task SendMessageAsync(string message)
        {
            var messageObj = JsonConvert.DeserializeObject<Message>(message);
            if (messageObj.to == string.Empty)
            {
                await Clients.All.SendAsync("ReceiveMessage", message);
            }
            else
            {
                await Clients.Client(messageObj.to).SendAsync("ReceiveMessage", message);
            }
        }
    }
}
