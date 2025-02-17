namespace BookStore.Communication.Responses;

public class ResponseCreateJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Autrhor { get; set; } = string.Empty;
    public string Message {  get; set; } = string.Empty;
}
