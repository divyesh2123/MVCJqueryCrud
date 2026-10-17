using System;
using System.Collections.Generic;

namespace MVCJqueryCrud.Models;

public partial class Institute
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Course { get; set; }
}
