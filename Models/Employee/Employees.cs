﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CORE.Models.Employee
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required] public required string FirstName { get; set; }
        [Required] public required string LastName { get; set; }
        [Required] public required DateTime HireDate { get; set; }

        // Navigation property
        [Required] public required List<EmployeePhones> EmployeePhones { get; set; }
        [Required] public required List<EmployeeAddresses> EmployeeAddresses { get; set; }
    }
}