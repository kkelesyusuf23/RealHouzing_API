using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.JoinDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JoinController : ControllerBase
	{
		private readonly IJoinService _joinService;

		public JoinController(IJoinService joinService)
		{
			_joinService = joinService;
		}
		[HttpGet]
		public IActionResult JoinList() 
		{
			var values = _joinService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteJoin(int id) 
		{
			var value = _joinService.TGetById(id);
			_joinService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddJoin(ResultJoinDto resultJoinDto)
		{
			Join join = new Join()
			{
				Title1 = resultJoinDto.Title1,
				Title2 = resultJoinDto.Title2,
				Description=resultJoinDto.Description,
			};
			_joinService.TAdd(join);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateJoin(Join join)
		{
			_joinService.TUpdate(join);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetJoin(int id)
		{
			var values = _joinService.TGetById(id);
			return Ok(values);
		}
	}
}
