using System;
using System.Collections.Generic;

namespace eM_Demo.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? ContactNumber { get; set; }

    public string? Department { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
