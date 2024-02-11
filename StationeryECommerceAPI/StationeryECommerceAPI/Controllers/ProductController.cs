using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StationeryECommerceAPI.Models;
using System.ComponentModel;

namespace StationeryECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Product>> GetProducts()
        {
            List<Product> products = new List<Product>() { 
                new Product { Id = 1, Name = "1", Description = "123"},
                new Product { Id = 2, Name = "2", Description = "456"},
                new Product { Id = 3, Name = "3", Description = "789"},
                new Product { Id = 4, Name = "4", Description = "000"},
                new Product { Id = 5, Name = "5", Description = "999"}
            };

            return Ok(products);
        }
    }
}
