namespace CarRental.API.Models;

public class Customer
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName  { get; set; } = null!;
    public string Email      { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation property
    public List<Reservation> Reservations { get; set; } = new();

}