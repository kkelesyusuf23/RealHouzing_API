using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ContactInfoDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactInfoController : ControllerBase
	{
		private readonly IContactInfoService _contactInfoService;

		public ContactInfoController(IContactInfoService contactInfoService)
		{
			_contactInfoService = contactInfoService;
		}
		[HttpGet]
		public IActionResult ContactInfoList() 
		{
			var values = _contactInfoService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteContactInfo(int id) 
		{
			var value = _contactInfoService.TGetById(id);
			_contactInfoService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddContactInfo(ResultContactInfoDto resultContactInfoDto)
		{
			ContactInfo contactInfo = new ContactInfo()
			{
				Title1 = resultContactInfoDto.Title1,
				Title2 = resultContactInfoDto.Title2,
				Address1 = resultContactInfoDto.Address1,
				Address2 = resultContactInfoDto.Address2,
				Mail1 = resultContactInfoDto.Mail1,
				Mail2 = resultContactInfoDto.Mail2,
				Phone1 = resultContactInfoDto.Phone1,
				Phone2 = resultContactInfoDto.Phone2,
				Icon1 = resultContactInfoDto.Icon1,
				Icon2 = resultContactInfoDto.Icon2,
				Icon3 = resultContactInfoDto.Icon3,
			};
			_contactInfoService.TAdd(contactInfo);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateContactInfo(ContactInfo contactInfo)
		{
			_contactInfoService.TUpdate(contactInfo);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetContactInfo(int id) 
		{
			var value = _contactInfoService.TGetById(id);
			return Ok(value);
		}
	}
}
