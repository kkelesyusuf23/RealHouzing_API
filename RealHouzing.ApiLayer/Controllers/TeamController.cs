using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.SSSDto;
using RealHouzing.DtoLayer.TeamDto;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TeamController : ControllerBase
	{
		private readonly ITeamService _teamService;

		public TeamController(ITeamService teamService)
		{
			_teamService = teamService;
		}
		[HttpGet]
		public IActionResult TeamList()
		{
			var values = _teamService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteTeam(int id)
		{
			var value = _teamService.TGetById(id);
			_teamService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddTeam(ResultTeamDto resultTeamDto)
		{
			Team team = new Team()
			{
				NameSurname = resultTeamDto.NameSurname,
				Departmant = resultTeamDto.Departmant,
				ImageURL = resultTeamDto.ImageURL,
				Icon1 = resultTeamDto.Icon1,
				Icon2 = resultTeamDto.Icon2,
				Icon3 = resultTeamDto.Icon3,
			};
			_teamService.TAdd(team);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateTeam(Team team)
		{
			_teamService.TUpdate(team);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetTeam(int id)
		{
			var values = _teamService.TGetById(id);
			return Ok(values);
		}
	}
}
