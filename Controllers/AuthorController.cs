using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAspApp.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace FinalAspApp.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private IAuthorDbRepository _authorRepository;
        public AuthorController(IAuthorDbRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(_authorRepository.GetAll());
        }

        public IActionResult Delete(int? id)
        {
            if (id is null) return NotFound();
            if (_authorRepository.DeleteById((int)id))
            {
                return RedirectToAction("List");
            }
            else return NotFound();
        }
        public IActionResult Create(string name, string surname)
        {
            _authorRepository.Create(name, surname);
            return RedirectToAction("List");
        }
        public IActionResult Details(int? id)
        {
            return id == null
                ? NotFound()
                : View(_authorRepository.GetById((int)id));
        }
        public IActionResult Update(int id, string name, string surname)
        {
            _authorRepository.Update(id, name, surname);
            //return RedirectToAction("Details", new { id = id });
            return RedirectToAction("List");
        }
    }
}
