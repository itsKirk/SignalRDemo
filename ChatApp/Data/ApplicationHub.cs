using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Data;
public class ApplicationHub : Hub
{
  public async Task SendMessage(string sender, string message) => await Clients.All.SendAsync("GetMessage", sender, message);
}