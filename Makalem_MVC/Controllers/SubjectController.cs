using Makalem.BLL.Services.Abstract;
using Makalem.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makalem_MVC.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IService<Subject> service;
        public SubjectController(IService<Subject> _service)
        {
            service = _service;
        }


        // GET: SubjectController
        public ActionResult Index()
        {
            var subjects = service.GetAll();
            return View(subjects);
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            Subject subject = service.GetById(id);
            return View(subject);
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subject)
        {
            service.Add(subject);
            return RedirectToAction("Index");
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            Subject subject = service.GetById(id);
            return View(subject);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Subject subject)
        {
            service.Update(subject);
            return RedirectToAction(nameof(Index));
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            Subject subject = service.GetById(id);
            return View(subject);
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Subject subject)
        {
            service.Delete(subject);
            return RedirectToAction(nameof(Index));
        }
    }
}
