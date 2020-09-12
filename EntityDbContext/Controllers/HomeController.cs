using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityDbContext.Models;

namespace EntityDbContext.Controllers
{
    public class HomeController : Controller
    {
        
        private EFCoreContext _dbContext;

        public HomeController(EFCoreContext dbContext)  
        {  
                    _dbContext = dbContext;  
        }  
  
        public IActionResult Index()
        {
         
               var _emplst = (from i in _dbContext.EMPLOYEE 
                                select i).ToList();  
            
              
            IList<Employee> emplst  = _emplst;  
            return View(emplst);  
           
        }

        public IActionResult Create()
        {
               var _emplst = (from i in _dbContext.EMPLOYEE 
                                select i).ToList();  
            
         
            return View();
        }

        [HttpPost]
           public IActionResult Create(Employee emp)
        {
         
              _dbContext.EMPLOYEE.Add(emp);

             _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
          public IActionResult Delete(int? id)
        {
              Employee emp =  _dbContext.EMPLOYEE.Find(id);
               
                return View(emp);
              
           
        }

        [HttpPost]
         public IActionResult Delete(int id)
        {
            Employee emp =  _dbContext.EMPLOYEE.Find(id);
            _dbContext.EMPLOYEE.Remove(emp);

             _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
