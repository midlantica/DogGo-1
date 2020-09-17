﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogGo.Controllers
{
    public class TacoController : Controller
    {
        // GET: TacoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TacoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TacoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TacoController/Create
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

        // GET: TacoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TacoController/Edit/5
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

        // GET: TacoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TacoController/Delete/5
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
