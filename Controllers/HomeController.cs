using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Address_Book.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
    return View();
    }
  }
}
