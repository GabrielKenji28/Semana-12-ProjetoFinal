using Business.Interfaces;
using Infra.Interfaces;
using Infra.Object;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class NewViewsController : Controller
    {
        private readonly IParticipanteService _participanteService;
        private readonly ITorneioService _torneioService;
        public NewViewsController(IParticipanteService participanteService, ITorneioService torneioService)
        {
            _torneioService = torneioService;
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

        // POST: NewViewsController/
        [HttpPost]
        public ActionResult EnviaParticipantes(List<int> ids)
        {
            Console.WriteLine(ids);
            List<ParticipanteModel> listaParticipantes = new List<ParticipanteModel>();
            listaParticipantes = _torneioService.TransformaParaListaParticipantes(ids);
            listaParticipantes = _participanteService.OrganizaPorIdade(listaParticipantes);
            Console.WriteLine(listaParticipantes);
            return View("Index");

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
