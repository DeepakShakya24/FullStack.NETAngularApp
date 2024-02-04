using angularbackend.Data;
using angularbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace angularbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ngDBContext _context;
        public EmployeesController(ngDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees() {
            try
            {
                IQueryable<Employees> employees = _context.AngularEmployee;
                return Ok(employees);
            }
            catch (Exception)
            {

                throw;
            }
       
        
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employees employees)
        {
            employees.id=Guid.NewGuid().ToString();
            await _context.AngularEmployee.AddAsync(employees);
            await _context.SaveChangesAsync();
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateEmployee(string id,Employees updateEmployee)
        {
            var employee=_context.AngularEmployee.Find(id);
            employee.firstName=updateEmployee.firstName;
            employee.lastName=updateEmployee.lastName;
            employee.email=updateEmployee.email;
            employee.department=updateEmployee.department;
            _context.AngularEmployee.Update(employee);
            await _context.SaveChangesAsync();
            return Ok(updateEmployee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmp(string id)
        {
            var employee = _context.AngularEmployee.Find(id);
            _context.AngularEmployee.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }


    }
}
