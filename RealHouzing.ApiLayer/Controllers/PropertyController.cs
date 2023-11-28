using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.PropertyDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertyController : ControllerBase
	{
		private readonly IPropertyService _propertyService;

		public PropertyController(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}
		[HttpGet]
		public IActionResult PropertyList()
		{
			var values = _propertyService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteProperty(int id)
		{
			var value = _propertyService.TGetById(id);
			_propertyService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddProperty(ResultPropertyDto resultPropertyDto)
		{
			Property property = new Property()
			{
				Name = resultPropertyDto.Name
			};
			_propertyService.TAdd(property);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateProperty(Property property)
		{
			_propertyService.TUpdate(property);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetProperty(int id)
		{
			var values = _propertyService.TGetById(id);
			return Ok(values);
		}

	}
}
