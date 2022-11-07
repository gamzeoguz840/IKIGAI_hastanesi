using IKIGAI_hastanesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKIGAI_hastanesi.Controllers
{
    public class homeController : Controller
    {
        // GET: home


        public ActionResult index()
        {
            return View();
        }

    

        public ActionResult about()
        {
            return View();
        }
        public ActionResult records()
        {
            return View();
        }


        public ActionResult contact()
        {
            return View();
        }


        //[HttpGet]
        //public ActionResult doctorsignin ()
        //{
        //    return View(new doktorlogin());
        //}
        //[HttpPost]
        //public ActionResult doctorsignin(doktorlogin doktorlogin)
        //{
        //    Modelcontext context = new Modelcontext();
        //    context.doktorlogin.Add(doktorlogin);
        //    context.SaveChanges();
        //    return RedirectToAction("doctorlogin");
        //}


        [HttpGet]
        public ActionResult appointment()
        {
            return View(new hasta());
        }

        [HttpPost]
        public ActionResult appointment( hasta hasta)
        {
            Modelcontext context = new Modelcontext();
            context.hasta.Add(hasta);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult teshisler()
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult teshisler(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||
            
            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar) ||
            x.hastadoktor.Contains(arananlar) ||
             x.hastateshis.Contains(arananlar) ||
            x.hastailac.Contains(arananlar)
            ).ToList();
            return View(Hastalist1);
        }

        [HttpGet]
        public ActionResult labaratuvar()
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult labaratuvar(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||

            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar) ||
            x.hastadoktor.Contains(arananlar) ||
             x.lab.Contains(arananlar) ||
            x.ameliyat.Contains(arananlar)
            ).ToList();
            return View(Hastalist1);
        }

        [HttpGet]
        public ActionResult ucretler()
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult ucretler(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||

            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar) ||
            x.hastadoktor.Contains(arananlar) ||
             x.ucreta.Contains(arananlar) ||
            x.ucretlab.Contains(arananlar)
            ).ToList();
            return View(Hastalist1);
        }



    }
}
         
  




    
    

