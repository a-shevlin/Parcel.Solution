using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      List<ParcelCheck> allParcel = ParcelCheck.GetAll();
      return View(allParcel);
    }

    [HttpGet("/parcel/new")]
    public ActionResult ParcelForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Index(string length, string width, string height, string weight)
    {
      ParcelCheck newParcel = new ParcelCheck();
      newParcel.Length = length;
      newParcel.Width = width;
      newParcel.Height = height;
      newParcel.Weight = weight;
      newParcel.GetVolume();
      newParcel.CostToShip();
      return RedirectToAction("Index");
    }
  }
}