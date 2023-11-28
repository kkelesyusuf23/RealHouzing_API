using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CategoryDtos;
using RealHouzing.DtoLayer.FindDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FindController : ControllerBase
	{
		private readonly IFindService _findService;

		public FindController(IFindService findService)
		{
			_findService = findService;
		}
		[HttpGet]
		public IActionResult FindList()
		{
			var values = _findService.TGetList();
			return Ok(values);
		}
		[HttpDelete] 
		public IActionResult DeleteFind(int id)
		{
			var value = _findService.TGetById(id);
			_findService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddFind(ResultFindDto resultFindDto)
		{
			Find find = new Find()
			{
				Title1 = resultFindDto.Title1,
				Title2 = resultFindDto.Title2,	
				Description1 = resultFindDto.Description1,
				Description2 = resultFindDto.Description2,
				ImageURL = resultFindDto.ImageURL,
			};
			_findService.TAdd(find);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateFind(Find find)
		{
			_findService.TUpdate(find);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetFind(int id)
		{
			var values = _findService.TGetById(id);
			return Ok(values);
		}
	}
}
