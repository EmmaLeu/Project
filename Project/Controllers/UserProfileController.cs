﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult Index()
        {
            return View();
        }
    }
}