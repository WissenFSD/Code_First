using Code_First.Context;
using Code_First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Code_First.Controllers
{

	// Ýlk çalýþtýrýlacak komut
	// dotnet ef migrations add "initial db ops" --project Code_First

	// Ýkinci çalýþtýrýlacak komut
	// dotnet ef database update --project Code_First


	// dotnet ef hatasý alýyorsanýz, aþaðýdaki komutu uygulayýn

	// Versionu kendi dotnet versionuna göre yazýnýz.
	//dotnet tool install --global dotnet-ef --version 8.*



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

			// soy adý s ile baþlayan  kullanýcý 

			var employee = _context.HumanResources.Where(s => s.Lastname.StartsWith("S")).FirstOrDefault();


			return View();
		}
		// Kayýt eklemek için browser üzerinden bu action çalýþtýrýlmalýdýr.



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


			// SaveChange metodu : Eklenen kayýtlarýn  database'e kaydedilmesini saðlar.

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
