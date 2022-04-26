using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Data
{
  public class ChatHub : Hub
  {
    public async Task SendMessage(string sender, string message) => await Clients.All.SendAsync("ReceiveMessage", sender, message);
  }
}
