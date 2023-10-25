using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Lophocphan
{
    public string Malhp { get; set; } = null!;

    public DateTime Ngaybatdau { get; set; }

    public DateTime Ngayketthuc { get; set; }

    public int Soluongsv { get; set; }

    public TimeSpan Giohocbatdau { get; set; }

    public TimeSpan Giohocketthuc { get; set; }

    public string Mak { get; set; } = null!;

    public string Mamh { get; set; } = null!;

    public string Magv { get; set; } = null!;

    public string Mahk { get; set; } = null!;

    public virtual Giangvien MagvNavigation { get; set; } = null!;

    public virtual Hocki MahkNavigation { get; set; } = null!;

    public virtual Khoa MakNavigation { get; set; } = null!;

    public virtual Monhoc MamhNavigation { get; set; } = null!;

    public virtual ICollection<Sinhvien> Masvs { get; set; } = new List<Sinhvien>();
}
