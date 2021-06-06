using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoVanThang_52.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]

        public int MaSinhVien { get; set; }
        public string TenNhanVien { get; set; }
        public int MaTinhThanh { get; set; }
    }
}