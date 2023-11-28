using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CategoryDtos;
using RealHouzing.DtoLayer.ContactDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet]
		public IActionResult ContactList() 
		{
			var values = _contactService.TGetList();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteContact(int id)
		{
			var value = _contactService.TGetById(id);
			_contactService.TDelete(value);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddCategory(ResultContactDto resultContactDto)
		{
			Contact contact = new Contact()
			{
				NameSurnamw = resultContactDto.NameSurnamw,
				Subject = resultContactDto.Subject,
				Mail = resultContactDto.Mail,
				Phone = resultContactDto.Phone,
				Message = resultContactDto.Message,
			};
			_contactService.TAdd(contact);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateContact(Contact contact)
		{
			_contactService.TUpdate(contact);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetCONTACT(int id)
		{
			var values = _contactService.TGetById(id);
			return Ok(values);
		}
	}
}
