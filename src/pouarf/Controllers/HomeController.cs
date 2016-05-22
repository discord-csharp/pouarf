using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pouarf.DataAccess;
using Pouarf.Models;

namespace Pouarf.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;                                   
        }
        
        public IActionResult Index()
        {
            var result = _repo.GetAll<Person>();
            foreach (var p in result)
            {
                var x = p.FirstName;
                var y = p.LastName;
            }
            
            return View();
        }
    }
}
