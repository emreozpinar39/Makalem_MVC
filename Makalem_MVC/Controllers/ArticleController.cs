using Makalem.BLL.Services.Abstract;
using Makalem.Core.Entities;
using Makalem_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makalem_MVC.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IService<Article> service;
        private readonly IService<Subject> subjectService;
        private readonly IArticleService articleService;
        public ArticleController(IService<Article> _service, IArticleService _articleService, IService<Subject> _subjectService)
        {
            service = _service;
            articleService = _articleService;
            subjectService = _subjectService;
        }

        // GET: ArticleController
        public ActionResult Index()
        {
            var articles = articleService.GetAllIncludeUsers();
            return View(articles);
        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            Article article = articleService.GetArticleIncludeUser(id);
            return View(article);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            ArticleSubjectVM articleSubjectVM = new ArticleSubjectVM();
            articleSubjectVM.Subjects = subjectService.GetAll();
            return View(articleSubjectVM);
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleSubjectVM articleSubjectVM)
        {

            service.Add(articleSubjectVM.Article);
            return RedirectToAction(nameof(Index));
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = service.GetById(id);
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Article article)
        {
            service.Update(article);
            return RedirectToAction(nameof(Index));
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            Article article = service.GetById(id);
            return View(article);
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Article article)
        {
            service.Delete(article);
            return RedirectToAction(nameof(Index));
        }
    }
}
