using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Ketqua
{
    public string Makq { get; set; } = null!;

    public decimal Diemgk { get; set; }

    public decimal Diemck { get; set; }

    public decimal Diemtb { get; set; }

    public string Mamh { get; set; } = null!;

    public string Masv { get; set; } = null!;

    public string Mahk { get; set; } = null!;

    public virtual Hocki MahkNavigation { get; set; } = null!;

    public virtual Monhoc MamhNavigation { get; set; } = null!;

    public virtual Sinhvien MasvNavigation { get; set; } = null!;
}
