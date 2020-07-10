using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DataAccesLayer
{
    public class UserDll
    {
        public bool Login(string username, string password)
        {
            
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1UCCNJ9; initial Catalog=SanalMarketProjesi; Integrated Security=True;");
                var sql = "SELECT Kullanici,Sifre FROM [dbo].[tbl_User] WHERE Kullanici=@n AND Sifre=@m";
                var kullanici = con.Query<User>(sql,new { n=""+username+"",m=""+password+""});
                if (kullanici != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}