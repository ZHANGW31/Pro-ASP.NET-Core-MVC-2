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
            return View("MyView");
        }
    }
}
