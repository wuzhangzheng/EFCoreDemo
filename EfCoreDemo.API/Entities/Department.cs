using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreDemo.API.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string? Address { get; set; }
        //[NotMapped]
        public string? Description { get; set; }
    }
}