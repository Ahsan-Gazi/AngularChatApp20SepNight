using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularChatApp20SepNight.Models;
using Microsoft.AspNet.SignalR;

namespace AngularChatApp20SepNight.Hubs
{
    public class chatHub : Hub
    {
        ChatContext db = new ChatContext();
        public void send(string name,string message)
        {
            Message obj = new Message();
            obj.UserName = name;
            obj.MessageText = message;
            obj.ConnectionId = Context.ConnectionId;
            obj.MessageDate = DateTime.Now;
            db.Messages.Add(obj);
            db.SaveChanges();
            Clients.All.broadcast(name,message);
        }
    }
}