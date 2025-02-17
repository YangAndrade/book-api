namespace BookStore.Communication.Request;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Autrhor { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Stok { get; set; }
}
