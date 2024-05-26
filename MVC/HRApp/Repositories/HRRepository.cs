using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRConsoleApp.Context;
using HRApp.Entities;
using HRConsoleApp.Repositories.Interfaces;

namespace HRConsoleApp.Repositories
{
    public class HRRepository : IHRRepository
    {
        private HRContext _context;

        public HRRepository(HRContext context)
        {
            _context = context;
        }
        public List<Employee> GetAll()
        {
            var employees =_context.Employees.ToList();
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
           return employee;
        }

        public bool Insert(Employee employee)
        {
            bool status= false;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            status = true;
            return status;
        }

        public bool Remove(int id)
        {
            bool status = false;
            var emp = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            if(emp != null)
            {
                _context.Employees.Remove(emp);
                status = true;
            }
            return status;

        }

        public bool Update(Employee employee)
        {
            var emp = _context.Employees.FirstOrDefault(emp =>emp.Id== employee.Id);
            if(emp!=null)
            {
                emp.FirstName= employee.FirstName;
                emp.LastName= employee.LastName;
                emp.Email= employee.Email;
                emp.Contact=employee.Contact;
            }
            return true;
        }
    }
}
