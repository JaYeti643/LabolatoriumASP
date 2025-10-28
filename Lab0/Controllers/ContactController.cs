using Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class ContactController : Controller
{
    private IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    private static int i = 2;

    // GET
    public IActionResult Index()
    {
        return View(_contactService.GetContacts());
    }

    [HttpGet] //Formularz
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost] //Odbiór danych z formularza
    public IActionResult Create(Contact contact)
    {
        if (ModelState.IsValid)
        {
            //zapamiętanie nowego kontaktu
            _contactService.CreateContact(contact);
            return RedirectToAction("Index");
        }

        return View(contact);
    }

    public IActionResult Details(int id)
    {
        var contact = _contactService.GetContactById(id);
        if (contact is not null)
        {
            return View(contact);
        }


        return NotFound();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var contact = _contactService.GetContactById(id);
        if (contact is not null)
        {
            return View(contact);
        }

        return NotFound();
    }

    [HttpPost]
    public IActionResult Edit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            _contactService.UpdateContact(contact);
            return RedirectToAction("Index");
        }

        return View(contact);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var contact = _contactService.GetContactById(id);
        if (contact is not null)
        {
            return View(contact);
        }

        return NotFound();
    }

    [HttpPost]
    public IActionResult Delete(Contact contact)
    {
        var sucess = _contactService.DeleteContactById(contact.Id);
        if (sucess)
        {
            return RedirectToAction("Index");
        }
        return BadRequest();
    }
}