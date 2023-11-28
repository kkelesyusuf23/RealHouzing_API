using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CategoryDtos;
using RealHouzing.DtoLayer.ExpertDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExpertController : ControllerBase
	{
		private readonly IExpertService _expertService;

		public ExpertController(IExpertService expertService)
		{
			_expertService = expertService;
		}
		[HttpGet]
		public IActionResult ExpertList()
		{
			var values = _expertService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteExpert(int id) 
		{
			var value = _expertService.TGetById(id);
			_expertService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddExpert(ResultExpertDto resultExpertDto)
		{
			Expert expert = new Expert()
			{
				Title1 = resultExpertDto.Title1,
				Title2 = resultExpertDto.Title2,
				Description1 = resultExpertDto.Description1,
				Description2 = resultExpertDto.Description2,
				ImageURL = resultExpertDto.ImageURL,	
			};
			_expertService.TAdd(expert);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateExpert(Expert expert)
		{
			_expertService.TUpdate(expert);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetExpert(int id)
		{
			var values = _expertService.TGetById(id);
			return Ok(values);
		}
	}
}
