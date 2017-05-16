using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotivateMeAPI.DataAccess.Interface;
using MotivateMeAPI.DataAccess.Models;

namespace MotivateMeAPI.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategory cat;
        public CategoriesController(ICategory cat)
        {
            this.cat = cat;

        }
        // GET: Categories
        public ActionResult Index()
        {
            var category = cat.GetAll();
            return View(category);
        }

        // GET: Categories/Details/5
        public ActionResult Details(string id)
        {
            var category = cat.GetByID(id);
            return View(category);

        }

        // GET: Categories/Create
        public ActionResult Create()

        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories catModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    var result = cat.Post(catModel);
                    return View(catModel);

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(catModel);

            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(string id)
        {
            var catresult = cat.GetByID(id);
            return View(catresult);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Categories catmodel)
        {
            try
            {
                // TODO: Add update logic here
                if (string.IsNullOrEmpty(id))
                {
                    return RedirectToAction("Index");
                }
                if (!ModelState.IsValid)
                {
                    return View(catmodel);
                }
                cat.Put(id, catmodel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(catmodel);
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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