﻿using EF_IVANN_5.Models;
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
            IVANN_Entities db = new IVANN_Entities();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            return View(PACI_FRA);
        }
        
        [HttpPost]
        public ActionResult Index(Pacientes info)
        {
            CabeceraFras fra = new CabeceraFras();
            Pacientes paci = new Pacientes();
            IVANN_Entities db = new IVANN_Entities();
            Pacientes paciente = new Pacientes();

            var id = info.IDPACIENTE;
            int idpaciente = Convert.ToInt32(id);
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paci.GetALLPacientes().ToList();
            PACI_FRA.FacturasGlob = fra.GetFrasByIDPACIENTE(idpaciente);
            return View(PACI_FRA);
        }

    }
}