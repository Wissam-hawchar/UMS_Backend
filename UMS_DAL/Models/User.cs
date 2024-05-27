using System;
using System.Collections.Generic;

namespace UMS_DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual Role Role { get; set; } = null!;
}
