using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    using Models;
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        MvcDbStokEntities1 db = new MvcDbStokEntities1();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<UrunDTO> UrunlerListesi()
        {

            var degerler = db.Ürünler.Select(x=>new UrunDTO {Urunid=x.Urunid,UrunAd=x.UrunAd,UrunKategori=x.UrunKategori,UrunFiyat=x.UrunFiyat,Marka=x.Marka,Stok=x.Stok }).ToList();
            db.SaveChanges();
            return (degerler);



        }
    }
}
