﻿using Microsoft.AspNetCore.Mvc;
using SuperShop.Models;
using System.Diagnostics;

namespace SuperShop.Controllers
{
    public class ErrorsController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //Quando ele entrar pelo Route, vai executar esta action
        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
