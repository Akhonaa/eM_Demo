using System;
using System.Collections.Generic;

namespace eM_Demo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? ContactNumber { get; set; }

    public string? Department { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }
}
