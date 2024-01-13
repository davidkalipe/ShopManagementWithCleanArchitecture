namespace Domain.Clients;

public class Client
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Client()
    {
        ClientId = Guid.NewGuid();
    }
}