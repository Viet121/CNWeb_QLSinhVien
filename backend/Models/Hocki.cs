using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Hocki
{
    public string Mahk { get; set; } = null!;

    public string Tenhk { get; set; } = null!;

    public string Namhoc { get; set; } = null!;

    public DateTime Ngaybatdau { get; set; }

    public DateTime Ngayketthuc { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual ICollection<Lophocphan> Lophocphans { get; set; } = new List<Lophocphan>();
}
