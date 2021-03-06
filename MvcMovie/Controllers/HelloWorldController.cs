﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        //
        //GET: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1) 
        {
            name = "Yannick";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        } 
    }
}
