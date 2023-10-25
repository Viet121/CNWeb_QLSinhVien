using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Giangvien
{
    public string Magv { get; set; } = null!;

    public string Tengv { get; set; } = null!;

    public string Sodienthoai { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mak { get; set; } = null!;

    public virtual ICollection<Lophocphan> Lophocphans { get; set; } = new List<Lophocphan>();

    public virtual Khoa MakNavigation { get; set; } = null!;
}
