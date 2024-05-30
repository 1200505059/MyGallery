using GallerySiteProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GallerySiteProject.Controllers
{
	public class HomeController : Controller
	{
		Context db=new Context();
		public IActionResult Index()
		{
			ViewBag.TBLGİRİS=db.tblGirises.ToList();
			ViewBag.TBLHAKKIMDA=db.tblHakkimdas.ToList();
			ViewBag.TBlRESİMLER=db.tblResimlers.ToList();
			return View();
		}
		public IActionResult PartialGiris()
		{
			ViewBag.TBLGİRİS=db.tblGirises.ToList();

            return View();
		}
		public IActionResult PartialHakkimda()
		{
			ViewBag.TBLHAKKIMDA=db.tblHakkimdas.ToList();

            return View();
		}
		public IActionResult PartialResimler()
		{
			ViewBag.TBlRESİMLER = db.tblResimlers.ToList();

			return View();
		}
		public IActionResult PartialFooter()
		{
            ViewBag.TBLGİRİS = db.tblGirises.ToList();

            return View();
		}
		
	}
}
