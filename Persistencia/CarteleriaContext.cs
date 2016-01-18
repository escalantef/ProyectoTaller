using System.Data.Entity;

namespace Persistencia
{
    partial class CarteleriaContext : DbContext
    {
        /*
        static CarteleriaContext()
        {
            //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            Database.SetInitializer<CarteleriaContext>(null);
        }
        */
        public CarteleriaContext()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            Database.SetInitializer<CarteleriaContext>(new CreateDatabaseIfNotExists<CarteleriaContext>());
            //this.Database.CreateIfNotExists();
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Campaña> Campañas { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<InformacionAdicional> InformacionAdicional { get; set; }
        public DbSet<RangoFecha> RangosFecha { get; set; }
        public DbSet<RangoHorario> RangosHorario { get; set; }
    }
}
