namespace CarRental.API.Models;

public class Reservation
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public Guid CarId { get; set; }
    public Car Car { get; set; } = null!;

    public DateTime PickupDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public decimal TotalPrice { get; set; }

    public bool IsReturned { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public int GetTotalDays()
    {
        return (int)Math.Ceiling((ReturnDate - PickupDate).TotalDays);;
    }

    public decimal GetTotalPrice(int days, decimal pricePerDay)
    {
        return days * pricePerDay;
    }
}