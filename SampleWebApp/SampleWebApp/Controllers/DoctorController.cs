using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var con = new DataConnection();
            var model = con.GetAllDoctors();
            //Send it to the view
            return View(model);
        }
        public ActionResult OnEdit(string id)
        {
            int Id = Convert.ToInt32(id);
            var con = new DataConnection();
            try
            {
                var doc = con.FindEmployee(Id);
                return View(doc);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult OnEdit(Doctor postedData)
        {
            var con = new DataConnection();
            try
            {
                con.Update(postedData);
                return RedirectToAction("GetAllDoctors");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult AddNewDoctor()
        {
            var con = new DataConnection();
            return View(new Doctor());
        }
        [HttpPost]
        public ActionResult AddNewDoctor(Doctor postedData)
        {
            var con = new DataConnection();
            try
            {
                con.AddNewDoctor(postedData);
                return RedirectToAction("GetAllDoctors");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                ViewBag.ErrorMessage = message;
                return View(new Doctor());
            }
        }
        public ActionResult RemoveDoctor(string id)
        {
            var con = new DataConnection();
            int Id = Convert.ToInt32(id);
            try
            {
                con.RemoveDoctor(Id);
                return RedirectToAction("GetAllDoctors");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}