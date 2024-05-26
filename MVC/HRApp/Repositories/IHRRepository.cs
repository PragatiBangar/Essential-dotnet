using HRApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConsoleApp.Repositories.Interfaces
{
    public interface IHRRepository
    {
        public List<Employee> GetAll();
        public Employee GetEmployee(int id);
        public bool Insert(Employee employee);
        public bool Update(Employee employee);
        public bool Remove(int id);
    }
}
