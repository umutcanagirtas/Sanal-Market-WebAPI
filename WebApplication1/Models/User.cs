using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table ("tbl_User")]
    public class User
    {
        [ExplicitKey]
        public string  Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}