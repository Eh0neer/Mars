using System;
using System.Collections.Generic;

namespace Mars;

public partial class Employeecard
{
    public int Employeecardid { get; set; }

    public int? Userid { get; set; }

    public byte[]? Photo { get; set; }

    public byte[]? Employmentcontractscan { get; set; }

    public virtual User? User { get; set; }
}
