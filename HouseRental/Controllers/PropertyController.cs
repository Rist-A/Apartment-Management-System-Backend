using HouseRental.Interfaces;
using HouseRental.Modules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyController(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        [HttpGet]
        [AllowAnonymous] // Public access
        public IActionResult GetAllProperties()
        {
            var properties = _propertyRepository.GetAllProperties();
            return Ok(properties);
        }

        [HttpPost]
        [Authorize(Roles = "Staff")] // Staff-only access
        public IActionResult AddProperty([FromBody] Property property)
        {
            _propertyRepository.AddProperty(property);
            return CreatedAtAction(nameof(GetAllProperties), new { id = property.PropertyId }, property);
        }

        [HttpPut("{id}/status")]
        [Authorize(Roles = "Staff")] // Staff-only access
        public IActionResult UpdatePropertyStatus(int id, [FromBody] string newStatus)
        {
            _propertyRepository.UpdatePropertyStatus(id, newStatus);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")] // Staff-only access
        public IActionResult DeleteProperty(int id)
        {
            _propertyRepository.DeleteProperty(id);
            return NoContent();
        }
    }
}
