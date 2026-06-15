using CarRental.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using CarRental.API.Models;
using Microsoft.AspNetCore.Identity;

namespace CarRental.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CustomersController : ControllerBase
{
    PasswordHasher<Customer> hasher = new();
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from CustomerController");
    }

    [HttpPost("create")]
    public IActionResult CreateUser([FromBody]PostCustomerDto payload)
    {
        
        var customer = new Customer()
        {
            FirstName = payload.FirstName,
            LastName = payload.LastName,
            Email = payload.Email,
            CreatedAt = DateTime.UtcNow,
            Reservations = null
        };
        
        customer.PasswordHash = hasher.HashPassword(customer, payload.PasswordHash);
        return Ok(customer);
    }
}