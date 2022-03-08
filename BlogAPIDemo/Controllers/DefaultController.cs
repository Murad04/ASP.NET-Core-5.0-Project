using BlogAPIDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var data = c.Employees.Find(id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var data = c.Employees.Find(id);
            if (data is not null)
            {
                c.Remove(data);
                c.SaveChanges();
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut]
        public IActionResult EmployeeUpdate(Employee em)
        {
            using var c = new Context();
            var emp = c.Find<Employee>(em.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = em.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
