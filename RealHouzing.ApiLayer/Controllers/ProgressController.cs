using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.PlanDto;
using RealHouzing.DtoLayer.ProgressDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProgressController : ControllerBase
	{
		private readonly IProgressService _progressService;

		public ProgressController(IProgressService progressService)
		{
			_progressService = progressService;
		}
		[HttpGet]
		public IActionResult ProgressList()
		{
			var values = _progressService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteProgress(int id)
		{
			var value = _progressService.TGetById(id);
			_progressService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddProgress(ResultProgressDto resultProgressDto)
		{
			Progress progress = new Progress()
			{
				Title1 = resultProgressDto.Title1,
				Title2 = resultProgressDto.Title2,
				Description = resultProgressDto.Description,
			};
			_progressService.TAdd(progress);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateProgress(Progress progress)
		{
			_progressService.TUpdate(progress);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetProgress(int id)
		{
			var values = _progressService.TGetById(id);
			return Ok(values);
		}
	}
}
