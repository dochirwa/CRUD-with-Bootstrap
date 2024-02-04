using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_with_Bootstrap.Models;

namespace CRUD_with_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        UniversityEntities2 db = new UniversityEntities2();


        public ActionResult EnrollmentData()
        {
            List<Enrollment> enr = db.Enrollments.ToList();
            return View(enr);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Enrollment enroll)
        {
            try
            { 
                if(enroll != null)
                {
                    Enrollment enrollData = new Enrollment();
                    enrollData.Name = enroll.Name;
                    enrollData.Course = enroll.Course;

                    db.Enrollments.Add(enrollData);
                    db.SaveChanges();
                }
                return RedirectToAction("EnrollmentData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occurred.";
                return RedirectToAction("EnrollmentData");
            }
        }

        [HttpGet]
        public ActionResult EditUpdate(int id)
        {
            try
            {
                if(id != 0)
                {
                    Enrollment enr_data = db.Enrollments.SingleOrDefault(x => x.Id == id);
                    return PartialView("_EditUpdate", enr_data);
                }
                else
                {
                    return RedirectToAction("EnrollmentData");
                }
            }
            catch(Exception)
            {
                ViewBag.msg = "Some error occurred.";
                return RedirectToAction("EnrollmentData");
            }
        }

        [HttpPost]
        public ActionResult EditUpdate(Enrollment enr_modified)
        {
            try
            {
                if (enr_modified != null)
                {
                    Enrollment enr_update = db.Enrollments.SingleOrDefault(x => x.Id == enr_modified.Id);

                    enr_update.Name = enr_modified.Name;
                    enr_update.Course = enr_modified.Course;
                    db.SaveChanges();
                }
                return RedirectToAction("EnrollmentData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occurred.";
                return RedirectToAction("EnrollmentData");
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                Enrollment enr_data = db.Enrollments.SingleOrDefault(x => x.Id == id);
                if (enr_data != null)
                {         
                    db.Enrollments.Remove(enr_data);
                    db.SaveChanges();
                }
                return RedirectToAction("EnrollmentData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occurred.";
                return RedirectToAction("EnrollmentData");
            }
        }
    }
}