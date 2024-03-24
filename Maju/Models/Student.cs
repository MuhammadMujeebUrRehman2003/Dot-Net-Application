using System;
using System.Collections.Generic;

namespace Maju.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Program { get; set; }

    public string? Department { get; set; }

    public int? Fee { get; set; }
}
