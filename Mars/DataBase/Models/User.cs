using System;
using System.Collections.Generic;

namespace Mars;

public partial class User
{
    public int Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public int? Usertypeid { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Employeecard> Employeecards { get; } = new List<Employeecard>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Shiftassignment> Shiftassignments { get; } = new List<Shiftassignment>();

    public virtual Usertype? Usertype { get; set; }

    public virtual ICollection<Waiterassignment> Waiterassignments { get; } = new List<Waiterassignment>();
}
