using dotnet_mvc_playground.Models;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_mvc_playground.Controllers;

public class ItemsController : Controller
{
  // IActionResult is an interface in ASP.NET MVC that represents the result of an action method (all of different kinds of result).
  // ViewResult : return a html view
  // JsonResult : return a json formatted data
  // ContentResult : return a plain text result
  // RedirectResult : redirect to a URL
  // RedirectToActionResult : redirect to another actions
  // StatusCodeResult : return a spesific status code result
  public IActionResult Overview()
  {
    var item = new Item() { Name = "Clock", Id = 1 };
    return View(item);
  }

  // The param and query is working same using the same format
  // items/edit/:id
  // items/edit?id=1
  // For the routing is must be match in pattern in Program.cs, because the pattern is using id
  public IActionResult Edit(int id)
  {
    return Content("the id param is : " + id);
  }
}