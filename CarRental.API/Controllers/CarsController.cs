using CarRental.API.Data;
using CarRental.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using CarRental.API.Models;

namespace CarRental.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CarsController(AppDbContext context) : ControllerBase
{
   

    [HttpGet]
    public IActionResult GetCars()
    {
        return Ok(context.Cars);
    }
    
    [HttpPost("create")]
    public IActionResult CreateCar([FromBody]PostCarDto payload)
    {
        var car = new Car()
        {
            Make = payload.Make,
            Model = payload.Model,
            Year = payload.Year,
            PricePerDay = payload.PricePerDay,
            IsAvailable = true,
            CreatedAt = DateTime.UtcNow,
        };
        
        context.Cars.Add(car);
        context.SaveChanges();
        
        return Ok(car);
    }
}