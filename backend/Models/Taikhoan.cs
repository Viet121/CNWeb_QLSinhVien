using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Taikhoan
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte Loaitk { get; set; }
}
