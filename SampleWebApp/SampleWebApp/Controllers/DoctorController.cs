using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApp.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
       
        public ActionResult GetAllDoctors()
        {
            //Get the Model data
            var com = new DataConnection();
            var model = com.GetAllDoctors();
            //Send it to the view
            return View(model);
        }
    }
}