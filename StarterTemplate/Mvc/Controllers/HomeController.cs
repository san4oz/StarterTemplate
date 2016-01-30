using AutoMapper;
using StarterTemplate.Business.Entities;
using StarterTemplate.Business.InterfaceDefinitions;
using StarterTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StarterTemplate.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {           
            return View();
        }
    }
}
