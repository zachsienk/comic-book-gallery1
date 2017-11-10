using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //action controller using System.Web.Mvc
    public class ComicBooksController : Controller
    {
        //public method to give detail
        //ActionReuslt type is usually action return type press alt f12 if there is an error
        public ActionResult Detail()
        {

                    ViewBag.SeriesTitle = "The Amazing Spider-Man";
                    ViewBag.IssueNumber = 700;
                    ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
                    ViewBag.Artists = new string[]
                        {
                    "Script: Dan Slott",
                    "Pencils: Humberto Ramos",
                    "Inks: Victor Olazaba",
                    "Colors: Edgar Delgado",
                    "Letters: Chris Eliopoulos"
                         };

            return View();

            /*
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                //redirect is a method in Controller class of mvc
                return Redirect("/");
                
            }

            //content is method isController class of mvc
            return Content("Hello from the comic book controller!");
           */

        
        
        }
    }
}