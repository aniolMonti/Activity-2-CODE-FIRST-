﻿using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2__CODE_FIRST_.MODEL
{
    public class Employee
    {
        [Key]
        [Name("employeeNumber")]
        public int EmployeeNumber { get; set; } 
        [Name("lastName")]
        public string LastName { get; set; }
        [Name("firstName")]
        public string FirstName { get; set; }
        [Name("extension")]
        public string Extension { get; set; }
        [Name("email")]
        public string Email { get; set; }
        [Name("officeCode")]
        [ForeignKey(nameof(Office.OfficeCode))]
        public string OfficeCode { get; set; }
        public Office Office { get; set; }
        [Name("reportsTo")]
        [ForeignKey(nameof(Employee.EmployeeNumber))]
        public int? ReportsTo { get; set; }
        public Employee ReportedEmployee { get; set; }
        [Name("jobTitle")]
        public string JobTitle { get; set; }
        

    }
}
