namespace CarRental.API.Models;

public class Car
{
    /// <summary>
    /// Represents a car available for rental.
    /// </summary>

    public Guid Id { get; set; }

    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal PricePerDay { get; set; }

    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<Reservation> Reservations { get; set; } = new();
}