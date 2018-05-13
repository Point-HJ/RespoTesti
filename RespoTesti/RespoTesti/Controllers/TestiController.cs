using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RespoTesti.Controllers
{
    public class TestiController : Controller
    {
        // GET: Testi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Testi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Testi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testi/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Testi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Testi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Testi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Testi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
