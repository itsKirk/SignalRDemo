namespace ChatApp.Data
{
  public class ChatMessage
  {
    public string? Message { get; set; }
    public string? Sender { get; set; }
    public bool IsActiveSender { get; set; }
    public string TimeSent { get; set; } = DateTime.Now.ToLocalTime().ToShortTimeString();
  }
}
