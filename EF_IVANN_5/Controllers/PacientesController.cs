using EF_IVANN_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_IVANN_5.Controllers
{
    public class PacientesController : Controller
    {
        Pacientes paciente = new Pacientes();
        CabeceraFras factura = new CabeceraFras();
        // GET: Pacientes
        public ActionResult Index()
        {
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            PACI_FRA.FacturasGlob = factura.GetAllFras().ToList();
            return View(PACI_FRA);
        }
        [HttpPost]
        public ActionResult Index(Pacientes info)
        {
            var id = info.IDPACIENTE;
            return View();
        }
    }
}