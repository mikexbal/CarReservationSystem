namespace CarRental.API.DTOs;

public class PostCarDto
{
    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;

    public int Year { get; set; }
    public decimal PricePerDay { get; set; }
    
}