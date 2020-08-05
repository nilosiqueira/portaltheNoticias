using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortaltheNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: NoticiaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NoticiaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoticiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoticiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoticiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoticiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoticiaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoticiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
