using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller //Controllers will always have Controller as the suffix, in this case this Controller is called Home.
    {
        //public string Index() //This is a action method that simply displays hello world when the web application is ran.
        //{
        //    return "Hello World"; 
        //}

        public ViewResult Index() //This action method creates and renders a view. The ViewResult object returned instructs the MVC to render
                                  //a view.
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");//MVC renders a view and returns the html properties. (View in this context is the view folder)
                                  //MyView is the name of the cshtml file that is returned.
        }
        [HttpGet] //This tells MVC that this method should be used only for GET requests
        public ViewResult RsvpForm()
        {
            return View(); //The RsvpForm action method calls the View method here without an argument, which tells the MVC to render the
                           //the default view associvated with the action method, which is a view with the same name as the action method.
        }
        [HttpPost] //This tells MVC that this method should be used only for POST requests
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TODO: store response from guest
            return View();
        }
    }
}
