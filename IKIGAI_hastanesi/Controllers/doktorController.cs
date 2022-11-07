using IKIGAI_hastanesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKIGAI_hastanesi.Controllers
{
    public class doktorController : Controller
    {
        // GET: doktor
        public ActionResult index()
        {
            return View();
        }
        public ActionResult records()
        {
            return View();
        }


        [HttpGet]
        public ActionResult doctorsignin()
        {
            return View(new doktorlogin());
        }
        [HttpPost]
        public ActionResult doctorsignin(doktorlogin doktorlogin)
        {
            Modelcontext context = new Modelcontext();
            context.doktorlogin.Add(doktorlogin);
            context.SaveChanges();
            return RedirectToAction("doctorlogin");
        }
        [HttpGet]
        public ActionResult doctorlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult doctorlogin(string doktortc, string doktorsifre)
        {
            Modelcontext context = new Modelcontext();
            var doktorvarmi = context.doktorlogin.Where(o => o.doktortc == doktortc && o.doktorsifre == doktorsifre).FirstOrDefault();

            if (doktorvarmi != null)
            {
                Session["doktorlogin"] = doktorvarmi;
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.hata = "Geçersiz TC veya şifre";
                return View();
            }

        }

        [HttpGet]
        public ActionResult infopattient()
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist = context.hasta.ToList();
            return View(Hastalist);
        }

        [HttpPost]
        public ActionResult infopattient(string aranan)
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist = context.hasta.Where(x => x.hastaad.Contains(aranan) ||
            x.hastasoyad.Contains(aranan) ||
            x.hastatc.Contains(aranan) ||
            x.hastadogum.Contains(aranan) ||
            x.hastabolum.Contains(aranan)
            ).ToList();
            return View(Hastalist);
        }


        [HttpGet]
        public ActionResult delete(int id)
        {
            Modelcontext context = new Modelcontext();
            var hastasil = context.hasta.Where(x => x.hastaid == id).FirstOrDefault();
            context.hasta.Remove(hastasil);
            context.SaveChanges();
            return RedirectToAction("infopattient");


        }

        [HttpGet]
        public ActionResult updated(int id)
        {
            Modelcontext context = new Modelcontext();
            var hastaguncelle = context.hasta.Where(x => x.hastaid == id).FirstOrDefault();
            return View(hastaguncelle);


        }
        [HttpPost]
        public ActionResult updated(hasta hasta)
        {

            Modelcontext context = new Modelcontext();
            var hastaguncelle = context.hasta.Where(x => x.hastaid == hasta.hastaid).FirstOrDefault();
            hastaguncelle.hastaad = hasta.hastaad;
            hastaguncelle.hastasoyad = hasta.hastasoyad;
            hastaguncelle.hastatc = hasta.hastatc;
            hastaguncelle.hastadogum = hasta.hastadogum;
            hastaguncelle.hastabolum = hasta.hastabolum;

            context.SaveChanges();
            return RedirectToAction("infopattient");
        }


        [HttpGet]
        public ActionResult tahlil()
        {
            return View(new hastasonuc());
        }

        [HttpPost]
        public ActionResult tahlil(hastasonuc hastasonuc)
        {
            Modelcontext context = new Modelcontext();
            context.hastasonuc.Add(hastasonuc);
            context.SaveChanges();
            return RedirectToAction("allpattient");
        }




        [HttpGet]
        public ActionResult allpattient()
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult allpattient(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hastasonuc> Hastalist1 = context.hastasonuc.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||
            x.hastatc.Contains(arananlar) ||
            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar) ||
             x.hastateshis.Contains(arananlar) ||
            x.hastailac.Contains(arananlar) ||
            x.lab.Contains(arananlar) ||
            x.ameliyat.Contains(arananlar) ||
            x.ucreta.Contains(arananlar) ||
            x.ucretlab.Contains(arananlar)
            ).ToList();
            return View(Hastalist1);
        }

        [HttpGet]
        public ActionResult listele()
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist1 = context.hasta.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult listele(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist1 = context.hasta.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||
            x.hastatc.Contains(arananlar) ||
            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar) 
            
            ).ToList();
            return View(Hastalist1);
        }

        [HttpGet]
        public ActionResult updated1(int id)
        {
            Modelcontext context = new Modelcontext();
            var hastaguncelle = context.hastasonuc.Where(x => x.hastasonucid == id).FirstOrDefault();
            return View(hastaguncelle);


        }
        [HttpPost]
        public ActionResult updated1(hastasonuc hastasonuc)
        {

            Modelcontext context = new Modelcontext();
            var hastaguncelle = context.hastasonuc.Where(x => x.hastasonucid == hastasonuc.hastasonucid).FirstOrDefault();
            hastaguncelle.hastaad = hastasonuc.hastaad;
            hastaguncelle.hastasoyad = hastasonuc.hastasoyad;
            hastaguncelle.hastatc = hastasonuc.hastatc;
            hastaguncelle.hastadogum = hastasonuc.hastadogum;
            hastaguncelle.hastabolum = hastasonuc.hastabolum;
            hastaguncelle.hastadoktor = hastasonuc.hastadoktor;
            hastaguncelle.hastateshis = hastasonuc.hastateshis;
            hastaguncelle.hastailac = hastasonuc.hastailac;
            hastaguncelle.lab = hastasonuc.lab;
            hastaguncelle.ameliyat = hastasonuc.ameliyat;
            hastaguncelle.ucreta = hastasonuc.ucreta;
            hastaguncelle.ucretlab = hastasonuc.ucretlab;


            context.SaveChanges();
            return RedirectToAction("allpattient");
        }

        [HttpGet]
        public ActionResult delete1(int id)
        {
            Modelcontext context = new Modelcontext();
            var hastasil = context.hastasonuc.Where(x => x.hastasonucid == id).FirstOrDefault();
            context.hastasonuc.Remove(hastasil);
            context.SaveChanges();
            return RedirectToAction("allpattient");


        }

        [HttpGet]
        public ActionResult addpattient1()
        {
            if (Session["doktorlogin"] == null)
            {
                return RedirectToAction("doctorlogin");
            }
            else
            {
                Modelcontext context = new Modelcontext();
                List<hasta> hasta = context.hasta.ToList();
                return View(hasta);
            }
        }
        public ActionResult doctorselect(int id)
        {
            if (Session["doktorlogin"] == null)
            {
                return RedirectToAction("doctorlogin");
            }
            else
            {
                Modelcontext context = new Modelcontext();
                doktorlogin doktorlogin = (doktorlogin)Session["doktorlogin"];

                hepsi hepsitablo = new hepsi();
                {
                    hepsitablo.doktorid = doktorlogin.doktorid;
                    hepsitablo.hastaid = id;
                };

                context.hepsi.Add(hepsitablo);
                context.SaveChanges();
                return RedirectToAction("listpattient1");
            }
        }
        [HttpPost]
        public ActionResult addpattient1(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist1 = context.hasta.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||
            x.hastatc.Contains(arananlar) ||
            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar)

            ).ToList();
            return View(Hastalist1);
        }

        [HttpGet]
        public ActionResult listpattient1()
        {
            if (Session["doktorlogin"] == null)
            {
                return RedirectToAction("doctorlogin");
            }
            else
            {
                Modelcontext context = new Modelcontext();
                doktorlogin doktorlogin = (doktorlogin)Session["doktorlogin"];

                List<hepsi> hepsi = context.hepsi.Where(x => x.doktorid == doktorlogin.doktorid).ToList();


                return View(hepsi);
            }
        }

        [HttpGet]
        public ActionResult exportexcel()
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist1 = context.hasta.ToList();
            return View(Hastalist1);
        }

        [HttpPost]
        public ActionResult exportexcel(string arananlar)
        {
            Modelcontext context = new Modelcontext();
            List<hasta> Hastalist1 = context.hasta.Where(x => x.hastaad.Contains(arananlar) ||
            x.hastasoyad.Contains(arananlar) ||
            x.hastatc.Contains(arananlar) ||
            x.hastadogum.Contains(arananlar) ||
            x.hastabolum.Contains(arananlar)

            ).ToList();
            return View(Hastalist1);
        }





    }

}






