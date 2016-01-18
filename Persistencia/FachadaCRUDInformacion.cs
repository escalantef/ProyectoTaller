using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    class FachadaCRUDInformacion
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor del CRUDFacade
        /// </summary>
        public FachadaCRUDInformacion()
        {

        }

        /// <summary>
        /// Crea (guarda) una Información Adicional
        /// </summary>
        /// <param name="pInformacionAdicional">Información Adicional a agregar a la base datos</param>
        public virtual void Create(InformacionAdicional pInformacionAdicional)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                this.iUnitOfWork.InformacionAdicionalRepository.Insert(pInformacionAdicional);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Actualiza una Información Adicional de la base de datos
        /// </summary>
        /// <param name="pInformacionAdicional">Información Adicional a actualizar de la base de datos</param>
        public virtual void Update(InformacionAdicional pInformacionAdicional)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                this.iUnitOfWork.InformacionAdicionalRepository.Update(pInformacionAdicional);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Elimina una Información Adicional de la base de datos
        /// </summary>
        /// <param name="pInformacionAdicional">Información Adicional a eliminar</param>
        public virtual void Delete(InformacionAdicional pInformacionAdicional)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = new UnitOfWork();
                this.iUnitOfWork.InformacionAdicionalRepository.Delete(pInformacionAdicional);
                this.iUnitOfWork.Save();
            }
        }

        /// <summary>
        /// Obtiene toda la Informacion Adicional de la base de datos
        /// </summary>
        /// <returns>Tipo de datos Lista que representa la Información Adicional almacenada</returns>
        public virtual List<InformacionAdicional> GetAll()
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                List<InformacionAdicional> listaInformacionAdicional = this.iUnitOfWork.InformacionAdicionalRepository.context.InformacionAdicional.ToList<InformacionAdicional>();
                return listaInformacionAdicional;
            }
        }

        /// <summary>
        /// Obtiene una instancia de Persona
        /// </summary>
        /// <param name="pInformacionAdicionalCodigo">Id de la persona que se desea obtener</param>
        /// <returns></returns>
        public virtual InformacionAdicional GetByCodigo(int pInformacionAdicionalCodigo)
        {
            using (UnitOfWork pUnitOfWork = new UnitOfWork())
            {
                this.iUnitOfWork = pUnitOfWork;
                InformacionAdicional informacionAdicional = this.iUnitOfWork.InformacionAdicionalRepository.GetByCodigo(pInformacionAdicionalCodigo);
                return informacionAdicional;
            }
        }
    }
}
