using EmployeeApplication.DBContext;
using EmployeeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //[HttpGet]
        //public ActionResult ShowEmployees()
        //{
        //    try
        //    {
        //        EmployeeDBContext employeeDbContext = new EmployeeDBContext();
        //        List<Employee> employees = employeeDbContext.Employees.ToList();

        //        //employees.ForEach(t => t.DOB = t.DateOfBirth.Date.ToString("MM/dd/yyyy"));
        //        return View(employees);
        //    }
        //    catch (Exception ex)
        //    {
        //        return View(ex.Message);
        //    }
        //}

        [HttpGet]
        public ActionResult AddEmployee()
        {
            EmployeeDBContext employeeDbContext = new EmployeeDBContext();
            List<Employee> employees = employeeDbContext.Employees.ToList();
            return View(employees);
        }

        // POST: Employee
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            try
            {
                Employee newEmployee = new Employee()
                {
                    Name = employee.Name,
                    DateOfBirth = employee.DateOfBirth,
                    Salary = employee.Salary
                };

                EmployeeDBContext employeeDbContext = new EmployeeDBContext();
                employeeDbContext.Employees.Add(newEmployee);
                employeeDbContext.SaveChanges();
                return RedirectToAction("AddEmployee");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

    }
}