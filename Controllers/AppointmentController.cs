using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //string TodayDate = DateTime.Today.ToShortDateString();
            //return Ok(TodayDate);
            return View();
        }
    }
}
