using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tbl_Urun")]
    public class Urun
    {
        [ExplicitKey]
        public string UrunId { get; set; }

        public string UrunAd { get; set; }

        public string UrunFiyat { get; set; }

        public string UrunURL { get; set; }

        public string ShopId { get; set; }

        public DateTime? UrunTarih { get; set; }
        
    }
}