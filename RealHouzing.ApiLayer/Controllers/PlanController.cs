using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.OptionDto;
using RealHouzing.DtoLayer.PlanDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlanController : ControllerBase
	{
		private readonly IPlanService _planService;

		public PlanController(IPlanService planService)
		{
			_planService = planService;
		}
		[HttpGet]
		public IActionResult PlanList()
		{
			var values = _planService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeletePlan(int id)
		{
			var value = _planService.TGetById(id);
			_planService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddPlan(ResultPlanDto resultPlanDto)
		{
			Plan plan = new Plan()
			{
				Title = resultPlanDto.Title,
				Icon = resultPlanDto.Icon,
				Fee = resultPlanDto.Fee,
				Time = resultPlanDto.Time,
				Property1 = resultPlanDto.Property1,
				Property2 = resultPlanDto.Property2,
				Chance = resultPlanDto.Chance,
			};
			_planService.TAdd(plan);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdatePlan(Plan plan)
		{
			_planService.TUpdate(plan);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetPlan(int id)
		{
			var values = _planService.TGetById(id);
			return Ok(values);
		}
	}
}
