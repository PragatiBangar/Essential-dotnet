using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRConsoleApp.Context
{
    public class HRContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public string connectionString = @"Data Source=DESKTOP-RQSMQ1M\SQLEXPRESS;Initial Catalog=AssessmentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
