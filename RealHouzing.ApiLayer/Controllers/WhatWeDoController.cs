using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.TourDtos;
using RealHouzing.DtoLayer.WhatWeDoDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WhatWeDoController : ControllerBase
	{
		private readonly IWhatWeDoService _whatWeDoService;

		public WhatWeDoController(IWhatWeDoService whatWeDoService)
		{
			_whatWeDoService = whatWeDoService;
		}
		[HttpGet]
		public IActionResult WhatWeDoList()
		{
			var values = _whatWeDoService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteWhatWeDo(int id)
		{
			var value = _whatWeDoService.TGetById(id);
			_whatWeDoService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddWhatWeDo(ResultWhatWeDoDto resultWhatWeDoDto)
		{
			WhatWeDo whatWeDo = new WhatWeDo()
			{
				Title = resultWhatWeDoDto.Title,
				Description = resultWhatWeDoDto.Description,
				Icon = resultWhatWeDoDto.Icon,
			};
			_whatWeDoService.TAdd(whatWeDo);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateWhatWeDo(WhatWeDo whatWeDo)
		{
			_whatWeDoService.TUpdate(whatWeDo);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetWhatWeDo(int id)
		{
			var values = _whatWeDoService.TGetById(id);
			return Ok(values);
		}
	}
}
