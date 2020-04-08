﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AulaMVC.Models;

namespace AulaMVC.Controllers
{
    public class FilmesController : Controller
    {
        
        public ActionResult Random()
        {
            var filme = new Filme() { Name= "Titanic" };

            return View (filme);
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+ id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("filmes/data/{year}/{month}")]
        public ActionResult PorData(int year, int month)
        {

            return Content(year + "/" + month);

        }
    }
}
