using dotnet_mvc_playground.Models;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_mvc_playground.Controllers;

public class ItemsController : Controller
{
  // IActionResult is an interface in ASP.NET MVC that represents the result of an action method (all of different kinds of result).
  public IActionResult Overview()
  {
    var item = new Item() {Name="Clock", Id=1};
    return View(item);
  }
}