using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel_Manager.Models;

namespace Travel_Manager.Controllers
{
    public class PageController : Controller
    {
        

        private readonly ApplicationPageClass _auc;

        public PageController(ApplicationPageClass auc)
        {
            _auc = auc;
        }
        
        public IActionResult Index()
        {
            return View();
        }

       

        public IActionResult AddPost()
        {
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost(AddPage uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
           
            return View();
        }

    


    }
}