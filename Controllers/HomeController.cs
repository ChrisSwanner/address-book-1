using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Address_Book.Models;

namespace Address_Book.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
    List<Contact> allContacts = Contact.GetAll();
    return View(allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult CreateForm()
    {
    return View();
    }

    [HttpPost("/")]
    public ActionResult Create()
    {
    string contactName = Request.Form["contact-name"];
    string contactPhone = Request.Form["contact-phone"];
    string contactAddress = Request.Form["contact-address"];
    Contact newContact = new Contact(contactName, contactPhone, contactAddress);
    List<Contact> allContacts = Contact.GetAll();
    return View("Index", allContacts);
    }

    [HttpGet("/contacts/{id}")]
    public ActionResult Details(int id)
    {
    Contact contact = Contact.Find(id);
    return View(contact);
    }

  }
}
