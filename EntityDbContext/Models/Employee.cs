using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDbContext
{ 
 
    public class Employee
    {
        [Key]
        public int EMPID { get; set; }
        public string EMPNAME { get; set; }
        
      
    }
}