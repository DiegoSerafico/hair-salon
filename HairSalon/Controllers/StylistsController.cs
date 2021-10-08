using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly ToDoListContext _db;

    public HairSalonController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}