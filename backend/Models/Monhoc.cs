using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Monhoc
{
    public string Mamh { get; set; } = null!;

    public string Tenmh { get; set; } = null!;

    public int Sotinchi { get; set; }

    public string Mak { get; set; } = null!;

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual ICollection<Lophocphan> Lophocphans { get; set; } = new List<Lophocphan>();

    public virtual Khoa MakNavigation { get; set; } = null!;
}
