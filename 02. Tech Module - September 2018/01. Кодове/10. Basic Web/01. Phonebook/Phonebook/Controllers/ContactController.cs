using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data.Models;
using Phonebook.Data;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                DataAccsess.Contacts.Add(contact);
            }
            else
            {
                TempData["ErrorMessage"] = "Name and number are required!";
            }
            return RedirectToAction("Index", "Home");
        }
    }
}