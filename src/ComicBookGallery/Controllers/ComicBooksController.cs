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