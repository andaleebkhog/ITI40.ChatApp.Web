using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ITI40.ChatApp.Web
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}