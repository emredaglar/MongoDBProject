using Microsoft.AspNetCore.Mvc;
using MongoDBProject.Services;

namespace MongoDBProject.Controllers
{
	public class CustumerController : Controller
	{
		private readonly ICustomerService _customerService;

		public CustumerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		public async Task<IActionResult> CustomerList()
		{
			var values=await _customerService.GetAllCustomerAsync();
			return View(values);
		}
	}
}
