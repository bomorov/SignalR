using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string tittle, Status status)
        {
            await this.Clients.All.SendAsync("Send", message,status);
        }
        public enum Status
        {
            Success,
            Warning,
        }
    }
}
