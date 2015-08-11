using SkyLo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyLo.Controllers
{
  public class AdminController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public ViewResult AddStock()
    {
      StockModel model = new StockModel();

      return View(model);
    }

    [HttpGet]
    public ViewResult AddRole()
    {
      return View();
    }
  }
}