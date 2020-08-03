using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace Pegasus.UI.Admin
{
    public class BroadcastHub:Hub
    {
        public  string _mess { get; set; }
        public async Task SendMessage(string user, string message)
        {
            _mess = message;
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendContact(int id)
        {
          
            await Clients.All.SendAsync("ReceiveContact", id);
        }


    }
}
