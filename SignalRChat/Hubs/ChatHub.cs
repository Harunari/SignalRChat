using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if (String.IsNullOrEmpty(user))
            {
                throw new ArgumentNullException();
            }
            if (message == null)
            {
                message = "";
            }
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
