using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Models;
using WebApplication1.Security;

namespace WebApplication1.Controllers
{
    [EnableCors("*", "*", "GET")]
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [Route("{parametre}")]
        [BasicAuthentication]
        public List<Urun> GetUrun(string parametre)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UCCNJ9; initial Catalog=SanalMarketProjesi; Integrated Security=True;"))
            {
                var sql = "SELECT * FROM [dbo].[tbl_Urun] WHERE [UrunAd] LIKE @n";
                List<Urun> data = con.Query<Urun>(sql,new { n="%"+ parametre.Trim()+"%"}).ToList();
                if (data != null)
                    return data;
                else
                    return null;
            }
        }
        [BasicAuthentication]
        public string BarkodSorgu(double barcode)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UCCNJ9; initial Catalog=SanalMarketProjesi; Integrated Security=True;"))
            {
                var urunler=con.Get<Urun>(barcode);
                return urunler.ToString();
            }
        }
    }
}