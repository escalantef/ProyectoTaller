using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Persistencia
{
    class FachadaCRUDCampaña
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor del CRUDFacade
        /// </summary>
        public FachadaCRUDCampaña()
        {

        }

        /// <summary>
        /// Crea (guarda) una Campaña junto con sus Imágenes y Rangos de Fecha en la base de datos
        /// </summary>
        /// <param name="pCampaña">Campaña a almacenar en la base datos</param>
        public virtual void Create(Campaña pCampaña)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                this.iUnitOfWork.CampañaRepository.Insert(pCampaña);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Actualiza una Campaña de la base de datos
        /// </summary>
        /// <param name="pCampaña">Campaña a actualizar</param>
        public virtual void Update(Campaña pCampaña)
        {
            Campaña databaseCampaña = this.GetByCodigo(pCampaña.Codigo);
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                //IMÁGENES
                List<Imagen> imagenesEliminadas = ExtesionLista.GetDeleted<Imagen>(databaseCampaña.Imagenes, pCampaña.Imagenes);
                List<Imagen> imagenesModificadas = ExtesionLista.GetModified<Imagen>(databaseCampaña.Imagenes, pCampaña.Imagenes);
                List<Imagen> imagenesAInsertar = ExtesionLista.GetNew<Imagen>(databaseCampaña.Imagenes, pCampaña.Imagenes);
                foreach (Imagen pImagen in imagenesModificadas)
                {
                    this.iUnitOfWork.ImagenRepository.Update(pImagen);
                }
                foreach (Imagen pImagen in imagenesEliminadas)
                {
                    this.iUnitOfWork.ImagenRepository.Delete(pImagen);
                }
                foreach (Imagen pImagen in imagenesAInsertar)
                {
                    this.iUnitOfWork.ImagenRepository.Insert(pImagen);
                }
                //RANGOS FECHA y HORARIO
                List<RangoFecha> rangosFechaEliminados = ExtesionLista.GetDeleted<RangoFecha>(databaseCampaña.RangosFecha, pCampaña.RangosFecha);
                List<RangoFecha> rangosFechaModificados = ExtesionLista.GetModified<RangoFecha>(databaseCampaña.RangosFecha, pCampaña.RangosFecha);
                List<RangoFecha> rangosFechaAInsertar = ExtesionLista.GetNew<RangoFecha>(databaseCampaña.RangosFecha, pCampaña.RangosFecha);
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
                    List<RangoHorario> rangosHorarioDatabase = databaseCampaña.RangosFecha.Find(x => x == pRangoFecha).RangosHorario;
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
                }
                this.iUnitOfWork.CampañaRepository.Update(pCampaña);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Elimina una Campaña de la base de datos
        /// </summary>
        /// <param name="pCampaña">Campaña a eliminar</param>
        public virtual void Delete(Campaña pCampaña)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = new UnitOfWork();
                this.iUnitOfWork.CampañaRepository.Delete(pCampaña);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Obtiene todos las Campañas de la base de datos
        /// </summary>
        /// <returns>Tipo de dato Lista que representa todas las Campañas almacenadas en la base de datos</returns>
        public virtual List<Campaña> GetAll()
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                List<Campaña> listaCampañas = this.iUnitOfWork.CampañaRepository.context.Campañas.ToList<Campaña>();
                foreach (Campaña campaña in listaCampañas)
                {
                    this.iUnitOfWork.CampañaRepository.Queryable.Include("Imagen").ToList();
                    this.iUnitOfWork.CampañaRepository.Queryable.Include("RangosFecha").ToList();
                    foreach (RangoFecha rangoFecha in campaña.RangosFecha)
                    {
                        this.iUnitOfWork.RangoFechaRepository.Queryable.Include("RangosHorario").ToList();
                    }
                }
                return listaCampañas;
            }
        }

        /// <summary>
        /// Obtiene una instancia de Campaña
        /// </summary>
        /// <param name="pCampañaCodigo">Código de la Campaña que se desea obtener</param>
        /// <returns></returns>
        public virtual Campaña GetByCodigo(int pCampañaCodigo)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                Campaña campaña = this.iUnitOfWork.CampañaRepository.GetByCodigo(pCampañaCodigo);
                this.iUnitOfWork.CampañaRepository.context.Entry(campaña).Collection("Imagenes").Load();
                this.iUnitOfWork.CampañaRepository.context.Entry(campaña).Collection("RangosFecha").Load();
                foreach(RangoFecha rangoFecha in campaña.RangosFecha)
                {
                    this.iUnitOfWork.RangoFechaRepository.context.Entry(rangoFecha).Collection("RangosHorario").Load();
                }
                return campaña;
            }
        }
    }
}
