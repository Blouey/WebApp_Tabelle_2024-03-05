using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebApp_Tabelle_2024_03_05.Models;

namespace WebApp_Tabelle_2024_03_05.Controllers;

public class HomeController : Controller
{
    private List<Artikel> _artikelListe = Program.artikelListe; 
    
    // GET
    public IActionResult Index()
    {
        return View(_artikelListe);
    }
    
    public IActionResult Details(int aid)
    {
        Artikel artikel = _artikelListe.FirstOrDefault(a => a.Aid == aid)!;
        return View(artikel);
    }
    
    public IActionResult Edit(int aid)
    {
        Artikel artikel = _artikelListe.FirstOrDefault(a => a.Aid == aid)!;
        return View(artikel);
    }
    
    public IActionResult Delete(int aid)
    {
        _artikelListe.Remove(_artikelListe.FirstOrDefault(a => a.Aid == aid)!);
        return RedirectToAction("Index");
    }
}