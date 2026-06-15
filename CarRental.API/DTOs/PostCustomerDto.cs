namespace CarRental.API.DTOs;

public class PostCustomerDto
{
    
    public string FirstName { get; set; } = null!;
    public string LastName  { get; set; } = null!;
    public string Email      { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    
}