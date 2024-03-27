using Code_First.Context;
using Code_First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Code_First.Controllers
{

	// �lk �al��t�r�lacak komut
	// dotnet ef migrations add "initial db ops" --project Code_First

	// �kinci �al��t�r�lacak komut
	// dotnet ef database update --project Code_First


	// dotnet ef hatas� al�yorsan�z, a�a��daki komutu uygulay�n

	// Versionu kendi dotnet versionuna g�re yaz�n�z.
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

			// soy ad� s ile ba�layan  kullan�c� 

			var employee = _context.HumanResources.Where(s => s.Lastname.StartsWith("S")).FirstOrDefault();


			return View();
		}
		// Kay�t eklemek i�in browser �zerinden bu action �al��t�r�lmal�d�r.



		public IActionResult InsertData()
		{
			// veri ekleyelim 


			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Erdo�an",
				Name = "Ali"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Alp",
				Name = "Ay�e"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "�maro�lu",
				Name = "Ekin"
			});
			_context.HumanResources.Add(new DMO.HumanResource()
			{

				Lastname = "Soyer",
				Name = "Mert"
			});

			// veri taban�na ekleyelim 


			// SaveChange metodu : Eklenen kay�tlar�n  database'e kaydedilmesini sa�lar.

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
