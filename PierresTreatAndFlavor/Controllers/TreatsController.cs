using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PierresTreatAndFlavor.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreatAndFlavor.Controllers
{
  // [Authorize]
  public class TreatsController : Controller
  {
    private readonly PierresTreatAndFlavorContext _db;

    public TreatsController(PierresTreatAndFlavorContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.JoinEntities)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(Treat => Treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddFlavor(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
          return View(thisTreat);
      }

      [HttpPost]
      public ActionResult AddFlavor(Treat treat, int FlavorId)
      {
          if (FlavorId != 0)
          {
          _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
          }
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

      [HttpPost]
      public ActionResult DeleteFlavor(int joinId)
      {
        var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
        _db.TreatFlavor.Remove(joinEntry);
        _db.SaveChanges();
      return RedirectToAction("Index");
      }
  }
}