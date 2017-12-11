using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceStorium.Controllers
{
    using System.IO;

    using Newtonsoft.Json;

    using SpaceStorium.Models;

    public class ProductOverviewController : Controller
    {
        public ActionResult ProductOverview()
        {
            ProductFactory productFactory = new ProductFactory(@"\App_Data\data.json");
            return this.View(productFactory.GetAllProducts());
        }
    }
}