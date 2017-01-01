using EF_IVANN_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_IVANN_5.Controllers
{
    public class CabeceraFrasController : Controller
    {
        
        // GET: CabeceraFras
        public ActionResult Index()
        {
            //IVANN_Entities db = new IVANN_Entities();
            //CabeceraFras factura = new CabeceraFras();
            //int idlineafactura = Convert.ToInt32(id);
            //var factu = db.CabeceraFras.FirstOrDefault(acc => acc.IDLINEAFRA == idlineafactura);
            return View();

        }

        public ActionResult Edit(int? id)
        {
            IVANN_Entities db = new IVANN_Entities();
            CabeceraFras factura = new CabeceraFras();
            int idlineafactura = Convert.ToInt32(id);
            var factu = db.CabeceraFras.FirstOrDefault(acc => acc.IDLINEAFRA == idlineafactura);
            return View(factu);

        }
    }
}