using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using vacancyWeb.Data;
using vacancyWeb.Models;

namespace vacancyWeb.Controllers
{	[Produces("application/json")]
	public class HomeController : Controller
	{
		private IDAO<Vacancies, int> dao { get; set; }

		public HomeController(VacansiesDAO dao)
		{
			this.dao = dao;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Vacancy application ";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

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

		public IActionResult AddVacancy(string title, DateTime date)
		{
			if (title != null && date != null)
			{
				Vacancies vacancy = new Vacancies() { Title = title, Date = date };
				dao.Add(vacancy);
			}
			return View("Index");
		}
		[HttpGet]
		public JsonResult GetAllVacansies()
		{
			List<Vacancies> res = dao.getAll().ToList();
			return Json(res);
		}
	}
}
