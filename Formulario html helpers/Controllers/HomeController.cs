using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Formulario_html_helpers.Models;

namespace Formulario_html_helpers.Controllers
{
    public class UserController : Controller
    {
        // GET : /User/Index
        public ActionResult Index()
        {
            return View(new Formulario());
        }


        public ActionResult Profile(Formulario user)
        {
            return View(user);
        }

        [HttpPost]
        // GET : /User/Create
        public ActionResult Index(Formulario user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            return View("Profile", user);
        }

    }
}