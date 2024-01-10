using System;
using System.Collections.Generic;

namespace Mars;

public partial class Usertype
{
    public int Usertypeid { get; set; }

    public string Usertypename { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
    
    
}
