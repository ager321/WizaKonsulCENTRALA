﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WizaKonsulCENTRALA.Controllers
{
    public class RaportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}