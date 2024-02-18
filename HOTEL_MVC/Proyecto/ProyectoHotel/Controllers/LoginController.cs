using ProyectoHotel.Logica;
using ProyectoHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoHotel.Controllers
{
    public class LoginController : Controller
    {
        //Quản lý đăng nhập
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string correo, string clave)
        {

            Persona ousuario = PersonaLogica.Instancia.Listar().Where(u => u.Correo == correo && u.Clave == clave && u.oTipoPersona.IdTipoPersona != 3).FirstOrDefault();

            if (ousuario == null)
            {
                ViewBag.Error = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                return View();
            }

            Session["Usuario"] = ousuario;

            return RedirectToAction("Index", "Inicio");
        }
    }
}