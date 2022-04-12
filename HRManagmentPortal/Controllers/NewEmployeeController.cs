using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagmentPortal.Controllers
{
    public class NewEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
