using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.MissionDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MissionController : ControllerBase
	{
		private readonly IMissionService _missionService;

		public MissionController(IMissionService missionService)
		{
			_missionService = missionService;
		}
		[HttpGet]
		public IActionResult MissionList()
		{
			var values = _missionService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMission(int id) 
		{
			var value = _missionService.TGetById(id);
			_missionService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddMission(ResultMissionDto resultMissionDto)
		{
			Mission mission = new Mission()
			{
				Title = resultMissionDto.Title,
				Icon = resultMissionDto.Icon,
				Description = resultMissionDto.Description,
			};
			_missionService.TAdd(mission);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateMission(Mission mission)
		{
			_missionService.TUpdate(mission);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetMission(int id)
		{
			var values = _missionService.TGetById(id);
			return Ok(values);
		}
	}
}
