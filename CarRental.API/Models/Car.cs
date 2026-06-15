namespace CarRental.API.Models;

public class Car
{

    public Guid Id { get; set; }

    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal PricePerDay { get; set; }

    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
}