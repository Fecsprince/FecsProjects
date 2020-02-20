using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BirthdayParty.Models;

namespace BirthdayParty.Controllers
{
    public class PartyInviteController : Controller
    {
        // GET: PartyInvite
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(guestModel GuestModel)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", GuestModel);
            }
            else
            { 
            return View();
            }
        }

    }
}