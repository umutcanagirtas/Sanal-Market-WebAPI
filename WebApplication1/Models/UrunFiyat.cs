using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tbl_Urun_Fiyat")]
    public class UrunFiyat
    {
        [Key]
        public int Id { get; set; }

        public string Urun_Id { get; set; }

        public string UrunFiyati { get; set; }

        public DateTime? UrunTarihi { get; set; }
    }
}