using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.QuestionDto;
using RealHouzing.DtoLayer.SSSDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SSSController : ControllerBase
	{
		private readonly ISSSService _sSSService;

		public SSSController(ISSSService sSSService)
		{
			_sSSService = sSSService;
		}
		[HttpGet]
		public IActionResult SSSList()
		{
			var values = _sSSService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteSSS(int id)
		{
			var value = _sSSService.TGetById(id);
			_sSSService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddSSS(ResultSSSDto resultSSSDto)
		{
			SSS sSS = new SSS()
			{
				Question = resultSSSDto.Question,
				Reply = resultSSSDto.Reply,
			};
			_sSSService.TAdd(sSS);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateSSS(SSS sSS)
		{
			_sSSService.TUpdate(sSS);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetSSS(int id)
		{
			var values = _sSSService.TGetById(id);
			return Ok(values);
		}
	}
}
