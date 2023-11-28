using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.NewsDto;
using RealHouzing.DtoLayer.OptionDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OptionController : ControllerBase
	{
		private readonly IOptionService _optionService;

		public OptionController(IOptionService optionService)
		{
			_optionService = optionService;
		}
		[HttpGet]
		public IActionResult OptionList()
		{
			var values = _optionService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteOption(int id)
		{
			var value = _optionService.TGetById(id);
			_optionService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddOption(ResultOptionDto resultOptionDto)
		{
			Option option = new Option()
			{
				Title1 = resultOptionDto.Title1,
				Title2 = resultOptionDto.Title2,
				Description = resultOptionDto.Description,
				Image1 = resultOptionDto.Image1,
				Image2 = resultOptionDto.Image2,
			};
			_optionService.TAdd(option);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateOption(Option option)
		{
			_optionService.TUpdate(option);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetOption(int id)
		{
			var values = _optionService.TGetById(id);
			return Ok(values);
		}
	}
}
