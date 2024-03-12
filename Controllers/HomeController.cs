using bfw_WebApp_ModelBinding_mit_Validierung.Models;
using Microsoft.AspNetCore.Mvc;

namespace bfw_WebApp_ModelBinding_mit_Validierung.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    
    
    [HttpGet]
    public IActionResult Anzeige(Lagerware lagerware)
    {
        return View(lagerware);
    }
    
    
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Insert(Lagerware lagerware)
    {
        if (!ModelState.IsValid)
        {
            return View(lagerware);
        }
        
        
        return RedirectToAction("Anzeige", lagerware);
    }
}