﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace acesscorpform.Controllers
{
    public class FormCreationController : Controller
    {
        // GET: FormCreation
        public ActionResult Index()
        {
            return View();
        }

        // GET: FormCreation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormCreation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormCreation/Create
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

        // GET: FormCreation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormCreation/Edit/5
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

        // GET: FormCreation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormCreation/Delete/5
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

        [HttpPost]
        public ActionResult AddAttributes(int? atributoId)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public JsonResult GetAll()
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}
