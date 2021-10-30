using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_1.Controllers
{
    public class PaqueteController : Controller
    {
        private readonly IMemoryCache _cache;

        public PaqueteController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public List<Models.Cliente> ObtenerLosClientes()
        {
            List<Models.Cliente> ListaClientes;
            if (_cache.Get("ListaDeClientes") is null)
            {
                ListaClientes = new List<Models.Cliente>();
                _cache.Set("ListaDeClientes", ListaClientes);
            }
            else
            {
                ListaClientes = (List<Models.Cliente>)_cache.Get("ListaDeClientes");
            }
            return ListaClientes;
        }

        // GET: PaqueteController
        public ActionResult Index()
        {
            List<Models.Paquete> ListaPaquetes;
            ListaPaquetes = Utilidades.CargaPaquetes.CargaInformacionSobrePaquetes();
            return View(ListaPaquetes);
        }

        // GET: PaqueteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaqueteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaqueteController/Create
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

        // GET: PaqueteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaqueteController/Edit/5
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

        // GET: PaqueteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaqueteController/Delete/5
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
