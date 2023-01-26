using Business.Interfaces;
using Infra.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class NewViewsController : Controller
    {
        private readonly IParticipanteService _participanteService;
        public NewViewsController(IParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }


        // GET: NewViewsController
        public ActionResult Index()
        {
            return View(_participanteService.ListandoParticipantes());
        }

        // GET: NewViewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewViewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewViewsController/Create
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

        // GET: NewViewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewViewsController/Edit/5
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

        // GET: NewViewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewViewsController/Delete/5
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
