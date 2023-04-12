using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class Manager
{
    public int Id { get; set; }

    public string UserName { get; set; } = string.Empty;

    public string Login { get; set; } = string.Empty;

    public string HashPassword { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;
}
