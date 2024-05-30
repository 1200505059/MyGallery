using GallerySiteProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GallerySiteProject.Controllers
{
    public class AdminController : Controller
    {
        Context db=new Context();
        public IActionResult Index()
        {
            var degerler=db.tblGirises.ToList();
            return View(degerler);
        }

        public IActionResult GirisSil(int id)
        {
            var girisSil=db.tblGirises.Find(id);
            db.tblGirises.Remove(girisSil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GirisEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult GirisEkle(TblGiris giris)
        {
            db.tblGirises.Add(giris);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult GirisGuncelle(int id)
        {
            var deger1=db.tblGirises.Find(id);

            return View(deger1);
        }
        [HttpPost]
        public IActionResult GirisGuncelle(TblGiris giris)
        {
            var deger = db.tblGirises.Find(giris.GirisID);
            deger.GirisID = giris.GirisID;
            deger.GirisAdSoyad=giris.GirisAdSoyad;
            deger.GirisAciklama=giris.GirisAciklama;
            deger.GirisFacebookURL=giris.GirisFacebookURL;
            deger.GirisLinkedinURL=giris.GirisLinkedinURL;
            giris.GirisMailURL=giris.GirisMailURL;
            giris.GirisInstagramURL=giris.GirisInstagramURL;
            db.tblGirises.Update(deger);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

       public IActionResult Hakkimda()
        {
            var degerler = db.tblHakkimdas.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult HakkimdaEkle()
        {
            return View();
        }
        [HttpPost]

        public IActionResult HakkimdaEkle(TblHakkimda hakkimda,IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Tema/web/images/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);

            hakkimda.HakkimdaImageURL = newImageName;
            db.tblHakkimdas.Add(hakkimda);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult HakkimdaSil(int id)
        {
            var sil =db.tblHakkimdas.Find(id);
            db.tblHakkimdas.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("/Admin/Hakkimda");
        }

        [HttpGet]
        public IActionResult HakkimdaGuncelle(int id)
        {
            var gnc = db.tblHakkimdas.Find(id);

            return View(gnc);
        }
        [HttpPost]
        public IActionResult HakkimdaGuncelle(TblHakkimda hakk)
        {
            var gnc = db.tblHakkimdas.Find(hakk.HakkimdaID);
            gnc.HakkimdaID=hakk.HakkimdaID;
            gnc.HakkimdaBaslik=hakk.HakkimdaBaslik;
            gnc.HakkimdaGiris=hakk.HakkimdaGiris;
            gnc.HakkimdaText=hakk.HakkimdaText;
            gnc.HakkimdaImageURL = hakk.HakkimdaImageURL;
            db.tblHakkimdas.Update(gnc);
            db.SaveChanges();

            return RedirectToAction("Hakkimda");
        }


        public IActionResult Resimler()
        {
            var resimler=db.tblResimlers.ToList();
            return View(resimler);
        }
        public IActionResult ResimSil(int id)
        {
           var resimsil=db.tblResimlers.Find(id);
            db.tblResimlers.Remove(resimsil);
            db.SaveChanges();
            return RedirectToAction("Resimler");
        }

        [HttpGet]
        public IActionResult ResimEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResimEkle(TblResimler resim, IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Tema/web/images/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            resim.ResimURL = newImageName;
            db.tblResimlers.Add(resim);
            db.SaveChanges();
            return RedirectToAction("/Admin/Resimler");
        }

        [HttpGet]
        public IActionResult GirisYap()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(TblAdmin admin)
        {
            var degerler = db.tblAdmins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName
                              &&
            x.AdminPassword == admin.AdminPassword);
            if (degerler != null)
            {
                var istek = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.AdminUserName),
                };

                return RedirectToAction("Index", "Admin");
            }
            return RedirectToAction("Index", "Home");

        }
       
        public IActionResult Admin()
        {
            var degerler=db.tblAdmins.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var ag = db.tblAdmins.Find(id);
            return View(ag);
        }
        [HttpPost]
        public ActionResult AdminGuncelle(TblAdmin p)
        {
            var ag = db.tblAdmins.Find(p.AdminID);
            ag.AdminUserName = p.AdminUserName;
            ag.AdminPassword = p.AdminPassword;
            db.tblAdmins.Update(ag);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

    }
}

