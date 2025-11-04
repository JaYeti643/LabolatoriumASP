using Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class ProducentController(AppDbContext context) : Controller
{
    // GET
    public IActionResult Index()
    {
        return View(context.Producents.ToList());
    }

    [HttpGet]
    public IActionResult AddContactsToProducent(int id)
    {
        return View(new ProducentContactModel()
        {
            producent = context.Producents.Find(id),
            contacts = context.Contacts.ToList()
        });
    }

    [HttpPost]
    public IActionResult AddContactsToProducent(List<int>contactsId)
    {
        return View();
    }
}