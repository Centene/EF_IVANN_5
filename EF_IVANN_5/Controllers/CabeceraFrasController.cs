using EF_IVANN_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_IVANN_5.Controllers
{
    public class CabeceraFrasController : Controller
    {
        
        // GET: CabeceraFras
        public ActionResult Index(int? id)
        {
            IVANN_Entities db = new IVANN_Entities();
            List<CabeceraFras> fras = new List<CabeceraFras>();
            CabeceraFras fra = new CabeceraFras();
            var facturas = db.spGetFrasIDPaciente(id).ToList();
            //int idlineafactura = Convert.ToInt32(id);
            //var factu = db.CabeceraFras.FirstOrDefault(acc => acc.IDLINEAFRA == idlineafactura);
            foreach(var item in facturas)
            {
                fra.IDLINEAFRA = item.IDLINEAFRA;
                fra.IDPACIENTE = item.IDPACIENTE;
                fra.NOMBRE_Y_APELLIDOS = item.NOMBRE_Y_APELLIDOS;
                fra.DNI = item.DNI;
                fra.FECHA = item.FECHA;
                fra.Nº_FACTURA = item.Nº_FACTURA;
                fra.TOTAL = item.TOTAL;
                fras.Add(fra);
                fra = new CabeceraFras();

            }

            return View(fras);

        }
        
        public ActionResult Edit(int? id)
        {
            IVANN_Entities db = new IVANN_Entities();
            CabeceraFras factura = new CabeceraFras();
            int idlineafactura = Convert.ToInt32(id);
            //factura = db.CabeceraFras.Find(idlineafactura);
            var factu = db.CabeceraFras.FirstOrDefault(acc => acc.IDLINEAFRA == idlineafactura);

            return View(factu);

        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]

        public ActionResult Edit(CabeceraFras model)
        {
            IVANN_Entities db = new IVANN_Entities();
                
            CabeceraFras factura_mod = new CabeceraFras();
            factura_mod = db.CabeceraFras.Find(model.IDLINEAFRA);
            factura_mod.TOTAL = model.TOTAL;
            UpdateModel(factura_mod);
            try
            {
                db.SaveChanges();
            }
            catch(DbEntityValidationException ex)
            {
                string cadena;
            }

            return View();
        } 


    }
}