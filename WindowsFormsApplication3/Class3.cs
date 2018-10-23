using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Net;

namespace WindowsFormsApplication3
{
    public class Repositorio
    {
        /*   public static void agregarCampañaSQL(Campaña camp)
            {
                try
                {
                    //Se utiliza el framework Entity, el cual se encarga de la capa de la persistencia.
                    using (var db = new CarteleriaContext())
                    {
                        db.Campañas.Add(camp);
                        db.SaveChanges();
                    }
                }
                catch { }
            }
            */
        public static void agregarProd(Producto Prod1)
        {
            try
            {
                using (var db = new TiendaContext())
                {
                    Producto prod = new Producto(Prod1.CodigoProducto, Prod1.Precio,Prod1.NombreProd);
                    db.Producto.Add(prod);
                    db.SaveChanges();
                }
            }
            catch { }
        }
        
  /*      public static void agregarBannerSQL(Banner banner1)
        {
            try
            {
                using (var db = new CarteleriaContext())
                {
                    db.Banners.Add(banner1);
                    db.SaveChanges();
                }
            }
            catch { }
        }

        public static void modificarBannerSQL(Banner ban)
        {
            try
            {
                using (var db = new CarteleriaContext())
                {
                    var bannerOriginal = db.Banners.Include(j => j.unafuente).Single(j => j.bannerID == ban.bannerID);

                    db.Entry(bannerOriginal).CurrentValues.SetValues(ban);

                    bannerOriginal.unafuente = null;
                    bannerOriginal.unafuente = ban.unafuente;
                    db.SaveChanges();

                }
            }
            catch { }
        }

        public static void eliminarBannerSQL(int idBanner)
        {
            try
            {
                Banner banner;

                using (var ctx = new CarteleriaContext())
                {
                    banner = ctx.Banners.Include(j => j.unafuente).Single(j => j.bannerID == idBanner);
                    ctx.Entry(banner).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }

            }
            catch { }
        }
        */
        public static List<Producto> obtenerProd()
        {
            List<Producto> Pro1 = new List<Producto>();
            try
            {
                using (var db = new TiendaContext())
                {
                    foreach (var rs in db.Producto)
                    {
                        Producto a = new Producto(rs.CodigoProducto, rs.Precio,rs.NombreProd);
                        Pro1.Add(a);
                    }
                }
            }
            catch { }
            return Pro1;
        }

        public static void modificarProd(int unCodigo, double unPrecio,string unNombre,int nuevoCodigo ,double nuevoPrecio, string nuevoNombre)
        {
            try
            {
                using (var db = new TiendaContext())
                {
                    var resultado = db.Producto.Where(b => b.CodigoProducto == unCodigo && b.Precio == unPrecio && b.NombreProd == unNombre).ToList();
                    if (resultado != null)
                    {
                        resultado.ForEach(a => a.CodigoProducto = nuevoCodigo);
                        resultado.ForEach(a => a.Precio = nuevoPrecio);
                        resultado.ForEach(a => a.NombreProd = nuevoNombre);
                        db.SaveChanges();
                    }
                }
            }

            catch { }
        }
        
        public static void eliminarProd(int unCodigo, double unPrecio,string unNombre )
        {
            try
            {
                using (var db = new TiendaContext())
                {
                    db.Producto.RemoveRange(db.Producto.Where(c => c.CodigoProducto== unCodigo && c.Precio== unPrecio && c.NombreProd== unNombre));
                    db.SaveChanges();
                }
            }
            catch { }
        }

        /*     public static List<Campaña> obtenerListaCampañasSQL()
             {
                 List<Campaña> listaContenidos = new List<Campaña>();

                 try
                 {
                     using (var db = new CarteleriaContext())
                     {
                         var LAcampaña = db.Campañas.Include(j => j.imagens);

                         foreach (var item in LAcampaña)
                         {
                             listaContenidos.Add(item);
                         }
                     }
                 }
                 catch { }
                 return listaContenidos;
             }

             public static Campaña obtenerCampañaSQL(int idCamp)
             {
                 Campaña laCampaña = new Campaña();

                 try
                 {
                     using (var db = new CarteleriaContext())
                     {
                         var LAcampaña = db.Campañas.Include(j => j.imagens);

                         foreach (var item in LAcampaña)
                         {
                             if (item.campañaID == idCamp)
                             {
                                 laCampaña = item;
                                 break;
                             }
                         }
                     }
                 }
                 catch { }
                 return laCampaña;
             }

             public static void eliminarCampañaSQL(int idCamp)
             {
                 try
                 {
                     Campaña campABorrar;

                     using (var ctx = new CarteleriaContext())
                     {
                         campABorrar = ctx.Campañas.Where(s => s.campañaID == idCamp).FirstOrDefault<Campaña>();
                         campABorrar.imagens.ToList().ForEach(p => ctx.Imagens.Remove(p));
                         ctx.Entry(campABorrar).State = EntityState.Deleted;
                         ctx.SaveChanges();
                     }
                 }
                 catch { }
             }

             public static void modificarCampañaSQL(Campaña campaña)
             {
                 try
                 {
                     using (var db = new CarteleriaContext())
                     {
                         var campañaOriginal = db.Campañas.Include(j => j.imagens).Single(j => j.campañaID == campaña.campañaID);

                         db.Entry(campañaOriginal).CurrentValues.SetValues(campaña);

                         campañaOriginal.imagens = null;
                         campañaOriginal.imagens = campaña.imagens;
                         db.SaveChanges();

                     }
                 }
                 catch { }
             }

             public static List<Banner> obtenerTodosLosBannersSQL()
             {
                 List<Banner> listaContenidos = new List<Banner>();

                 try
                 {
                     using (var db = new CarteleriaContext())
                     {
                         var LAcampaña = db.Banners.Include(j => j.unafuente);

                         foreach (var item in LAcampaña)
                         {
                             listaContenidos.Add(item);
                         }
                     }
                 }
                 catch { }
                 return listaContenidos;
             }
     */
        public static bool verificarRssSQL(String unRss)
        {
            try
            {
                //Crea el HttpWebRequest
                HttpWebRequest request = WebRequest.Create(unRss) as HttpWebRequest;
                //Setea el metodo Head.
                request.Method = "HEAD";
                //Se obtiene la respuesta.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Retorna  TRUE si el codigo Status es 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Cualquier exepcion retornara false.
                return false;
            }
        }

    }
}
