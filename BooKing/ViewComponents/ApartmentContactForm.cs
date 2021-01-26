﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.ViewComponents
{
    public class ApartmentContactForm : ViewComponent
    {
        public IViewComponentResult Invoke(int apartmentId)
        {
            return View(apartmentId);
        }
    }
}
