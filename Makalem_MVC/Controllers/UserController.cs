using Makalem.BLL.Services.Abstract;
using Makalem.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makalem_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userservice;
        private readonly IService<User> service;

        public UserController(IUserService _userservice, IService<User> _service)
        {
            userservice = _userservice;
            service = _service;
        }

        // GET: UserController
        public ActionResult Index()
        {
            var users = service.GetAll();
            return View(users);
        }

        public IActionResult Admin()
        {
            var users = service.GetAll();
            ViewBag.sonuc = HttpContext.Session.GetString("ad");
            return View(users);
        }

        public IActionResult Writer()
        {
            ViewBag.sonuc = HttpContext.Session.GetString("ad");
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User _user)
        {
            User user = userservice.CheckUser(_user);

            if (user == null)
            {
                TempData["Message"] = "Hatalı giriş. Lütfen bilgilerinizi kontrol ediniz";
                return View();
            }
            if (user.Id == 1)
            {
                HttpContext.Session.SetString("ad", user.FirstName);
                HttpContext.Session.SetInt32("id", user.Id);

                return RedirectToAction(nameof(Admin));
            }
            HttpContext.Session.SetString("ad", user.FirstName);
            HttpContext.Session.SetInt32("id", user.Id);
            return RedirectToAction(nameof(Writer));
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ad");
            return RedirectToAction("Index", "Home");
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            User user = service.GetById(id);
            return View(user);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                service.Add(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            User user = service.GetById(id);
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                service.Update(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            User user = service.GetById(id);
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                service.Delete(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
