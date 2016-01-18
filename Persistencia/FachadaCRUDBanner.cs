using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;

//Hace que sea visible para el Testing y los Servicios
[assembly: InternalsVisibleTo("PersistenciaTesting")]
[assembly: InternalsVisibleTo("Servicios")]

namespace Persistencia
{
    class FachadaCRUDBanner
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor del CRUDFacade
        /// </summary>
        public FachadaCRUDBanner()
        {

        }

        /// <summary>
        /// Crea una Banner en la base de datos
        /// </summary>
        /// <param name="pBanner">Banner a almacenar en la base de datos</param>
        public virtual void Create(Banner pBanner)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                this.iUnitOfWork.BannerRepository.Insert(pBanner);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Actualiza un Banner de la base de datos
        /// </summary>
        /// <param name="pBanner">Banner a actualizar de la base de datos</param>
        public virtual void Update(Banner pBanner)
        {
            Banner databaseBanner = this.GetByCodigo(pBanner.Codigo);
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                //Rangos Fecha
                List<RangoFecha> rangosFechaEliminados = ExtesionLista.GetDeleted<RangoFecha>(databaseBanner.RangosFecha, pBanner.RangosFecha);
                List<RangoFecha> rangosFechaModificados = ExtesionLista.GetModified<RangoFecha>(databaseBanner.RangosFecha, pBanner.RangosFecha);
                List<RangoFecha> rangosFechaAInsertar = ExtesionLista.GetNew<RangoFecha>(databaseBanner.RangosFecha, pBanner.RangosFecha);
                foreach (RangoFecha pRangoFecha in rangosFechaEliminados)
                {
                    this.iUnitOfWork.RangoFechaRepository.Delete(pRangoFecha);
                }
                foreach (RangoFecha pRangoFecha in rangosFechaAInsertar)
                {
                    this.iUnitOfWork.RangoFechaRepository.Insert(pRangoFecha);
                }
                foreach (RangoFecha pRangoFecha in rangosFechaModificados)
                {
                    //Rangos Horarios
                    List<RangoHorario> rangosHorarioDatabase = databaseBanner.RangosFecha.Find(x => x == pRangoFecha).RangosHorario;
                    List<RangoHorario> rangosHorariosEliminados = ExtesionLista.GetDeleted<RangoHorario>(rangosHorarioDatabase, pRangoFecha.RangosHorario);
                    List<RangoHorario> rangosHorariosModificados = ExtesionLista.GetModified<RangoHorario>(rangosHorarioDatabase, pRangoFecha.RangosHorario);
                    List<RangoHorario> rangosHorariosAInsertar = ExtesionLista.GetNew<RangoHorario>(rangosHorarioDatabase, pRangoFecha.RangosHorario);
                    foreach (RangoHorario pRangoHorario in rangosHorariosEliminados)
                    {
                        this.iUnitOfWork.RangoHorarioRepository.Delete(pRangoHorario);
                    }
                    foreach (RangoHorario pRangoHorario in rangosHorariosAInsertar)
                    {
                        this.iUnitOfWork.RangoHorarioRepository.Insert(pRangoHorario);
                    }
                    foreach (RangoHorario pRangoHorario in rangosHorariosModificados)
                    {
                        this.iUnitOfWork.RangoHorarioRepository.Update(pRangoHorario);
                    }
                    this.iUnitOfWork.RangoFechaRepository.Update(pRangoFecha);
                    this.iUnitOfWork.BannerRepository.Update(pBanner);
                    this.iUnitOfWork.Save();
                }
            }
        }

        /// <summary>
        /// Elimina un Banner de la base de datos
        /// </summary>
        /// <param name="pBanner">Banner a eliminar</param>
        public virtual void Delete(Banner pBanner)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = new UnitOfWork();
                this.iUnitOfWork.BannerRepository.Delete(pBanner);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Obtiene todos los Banners de la base de datos
        /// </summary>
        /// <returns>Tipo de dato Lista que representa los Banners almacenados en la base de dato</returns>
        public virtual List<Banner> GetAll()
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                List<Banner> listaBanners = this.iUnitOfWork.BannerRepository.context.Banners.ToList<Banner>();
                foreach (Banner banner in listaBanners)
                {
                    this.iUnitOfWork.CampañaRepository.Queryable.Include("RangosFecha").ToList();
                    foreach (RangoFecha rangoFecha in banner.RangosFecha)
                    {
                        this.iUnitOfWork.RangoFechaRepository.Queryable.Include("RangosHorario").ToList();
                    }
                }
                return listaBanners;
            }
        }

        /// <summary>
        /// Obtiene una instancia de Banner
        /// </summary>
        /// <param name="pBannerCodigo">Código del Banner que se desea obtener</param>
        /// <returns></returns>
        public virtual Banner GetByCodigo(int pBannerCodigo)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                Banner banner = this.iUnitOfWork.BannerRepository.GetByCodigo(pBannerCodigo);
                this.iUnitOfWork.CampañaRepository.context.Entry(banner).Collection("RangosFecha").Load();
                foreach (RangoFecha rangoFecha in banner.RangosFecha)
                {
                    this.iUnitOfWork.RangoFechaRepository.context.Entry(rangoFecha).Collection("RangosHorario").Load();
                }
                return banner;
            }
        }
    }
}
