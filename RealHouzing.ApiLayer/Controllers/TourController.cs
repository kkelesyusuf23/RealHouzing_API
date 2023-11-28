using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.TeamDto;
using RealHouzing.DtoLayer.TourDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TourController : ControllerBase
	{
		private readonly ITourService _tourService;

		public TourController(ITourService tourService)
		{
			_tourService = tourService;
		}
		[HttpGet]
		public IActionResult TourList()
		{
			var values = _tourService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteTour(int id)
		{
			var value = _tourService.TGetById(id);
			_tourService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddTour(ResultTourDto resultTourDto)
		{
			Tour tour = new Tour()
			{
				Title1 = resultTourDto.Title1,
				Title2 = resultTourDto.Title2,
				Description = resultTourDto.Description,
			};
			_tourService.TAdd(tour);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateTour(Tour tour)
		{
			_tourService.TUpdate(tour);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetTour(int id)
		{
			var values = _tourService.TGetById(id);
			return Ok(values);
		}
	}
}
