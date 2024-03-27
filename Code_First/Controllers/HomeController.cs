using Code_First.Context;
using Code_First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Code_First.Controllers
{
	public class HomeController : Controller
	{

		public DepartmentContext _context;
		public HomeController(DepartmentContext context)
		{
		
			_context = context;
		}

		public IActionResult Index()
		{
			//sjh


			return View();
		}
		public IActionResult InsertData()
		{
			// veri ekleyelim 


			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Erdoðan",
				Name = "Ali"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{
				
				Lastname = "Alp",
				Name = "Ayþe"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Ýmaroðlu",
				Name = "Ekin"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Soyer",
				Name = "Mert"
			});

			// veri tabanýna ekleyelim 

			_context.SaveChanges();
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
